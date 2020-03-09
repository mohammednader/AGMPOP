using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        AppUser Login(string email, string password);
        List<AppUser> SearchUsers(UserSC search);
        bool ValidateUser(AppUser user, out string errorMessage);
        void AttachTerritories(int userId, List<int> territories);
        void DetachTerritories(int userId, List<int> territories = null);
        bool ChangePassword(string email, string password, string newPassword, out string errorMessage);
        bool ResetPassword(int userId, string password, out string errorMessage);
        List<AppUser> GetActiveUsersByTerritoriesAndDepartment(List<int> territories, int? department = null);
        List<AppUser> GetAllByCycleId(int cycleId);
         AppUser  GetUserWithJobTitle(int userId);
        List<AppUser> GetHrUsers(List<int> selectedusers);
        bool UserAssignToJobTitle(int id);
        AppUser GetUserWithDetails(int userId);


    }
}
