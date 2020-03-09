using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IPermissionRepository : IGenericRepository<Permission>
    {
        List<Permission> GetPermissions(int userId);
        List<Permission> GetAllByRole(int roleId);
        List<LnkRolePermission> GetRolePermissions(int roleId);
        bool UserHasPermission(int userId, string permissionName);
    }
}
