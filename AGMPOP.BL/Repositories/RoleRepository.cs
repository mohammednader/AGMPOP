using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(AGMPOPContext context) : base(context)
        { }

        public List<Role> SearchRoles(RoleSC search)
        {
            var result = new List<Role>();
            try
            {
                var query = Context.Role
                                   .Where(r => r.IsDeleted != true && r.IsSysRole != true);

                if (search != null)
                {
                    if (!string.IsNullOrWhiteSpace(search.Name))
                    {
                        query = query.Where(r => r.Name.Contains(search.Name));
                    }
                    if (search.CreatedBy?.Count > 0 && !search.CreatedBy.Contains(0))
                    {
                        query = query.Where(r => search.CreatedBy.Contains(r.CreatedBy.GetValueOrDefault()));
                    }
                    if (search.CreationDateFrom != null)
                    {
                        query = query.Where(r => r.CreationDate >= search.CreationDateFrom);
                    }
                    if (search.CreationDateTo != null)
                    {
                        query = query.Where(r => r.CreationDate <= search.CreationDateTo);
                    }
                }

                result = query.ToList();
            }
            catch { }
            return result;
        }

        public List<Role> GetUserRoles(int userId)
        {
            var result = new List<Role>();
            try
            {
                result = Context.Role
                                .Where(r => r.IsDeleted != true && r.LnkUserRole.Any(lnk => lnk.UserId == userId))
                                .ToList();
            }
            catch { }
            return result;
        }

        public List<Role> GetUserRoles(List<int> users)
        {
            var result = new List<Role>();
            try
            {
                if (users?.Count > 0)
                {
                    result = Context.Role
                                    .Where(r => r.IsDeleted != true && r.LnkUserRole.Any(lnk => users.Contains(lnk.UserId)))
                                    .ToList();
                }
            }
            catch { }
            return result;
        }

        public void AttachPermissions(int roleId, List<int> permissions)
        {
            try
            {
                if (permissions != null)
                {
                    var links = permissions.Select(p => new LnkRolePermission
                    {
                        RoleId = roleId,
                        PermissionId = p
                    });
                    Context.LnkRolePermission.AddRange(links);
                }
            }
            catch { }
        }

        public void DetachPermissions(int roleId, List<int> permissions = null)
        {
            try
            {
                var links = Context.LnkRolePermission
                                   .Where(lnk => lnk.RoleId == roleId);

                if (permissions != null)
                {
                    links = links.Where(lnk => permissions.Contains(lnk.PermissionId));
                }

                Context.LnkRolePermission.RemoveRange(links.ToList());
            }
            catch { }
        }

        public override List<Role> Find(Expression<Func<Role, bool>> predicate)
        {
            var result = new List<Role>();
            try
            {
                result = Context.Role
                                .Where(r => r.IsDeleted != true && r.IsSysRole != true)
                                .Where(predicate)
                                .Include(c => c.DefaultPage)
                                .ToList();
            }
            catch { }
            return result;
        }

        public override List<Role> GetAll()
        {
            var result = new List<Role>();
            try
            {
                result = Context.Role
                                .Where(r => r.IsDeleted != true && r.IsSysRole != true)
                                .Include(c => c.DefaultPage)
                                .ToList();
            }
            catch { }
            return result;
        }

        public override void Remove(Role role)
        {
            try
            {
                DetachPermissions(role.Id);
                base.Remove(role);
            }
            catch { }
        }
    }
}
