using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        List<Role> SearchRoles(RoleSC search);
        List<Role> GetUserRoles(int userId);
        List<Role> GetUserRoles(List<int> users);
        void AttachPermissions(int roleId, List<int> permissions);
        void DetachPermissions(int roleId, List<int> permissions = null);
        bool IsRelatedToUser(int roleId);
    }
}
