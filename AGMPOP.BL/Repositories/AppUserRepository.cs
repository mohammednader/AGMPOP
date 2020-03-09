using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Helpers;
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
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(AGMPOPContext context) : base(context)
        { }

        public AppUser Login(string email, string password)
        {
            var passHash = PEncryption.Encrypt(password);
            var user = FindOne(u => u.Email == email && u.PasswordHash == passHash && u.IsDeleted != true);
            if (user != null)
            {
                Context.Entry(user).Reference(u => u.JobTitle).Load();
                Context.Entry(user).Reference(u => u.Department).Load();

            }
            return user;
        }

        public List<AppUser> SearchUsers(UserSC search)
        {
            var result = new List<AppUser>();
            try
            {
                var query = Context.AppUser
                                   .Where(u => u.IsDeleted != true && u.IsSysAdmin != true)
                                   .Include(u => u.JobTitle)
                                   .Include(u => u.Department)
                                   .AsQueryable();

                query = query.Where(u => u.Department.IsActive == true);
                if (search != null)
                {
                    if (!string.IsNullOrWhiteSpace(search.Name))
                    {
                        query = query.Where(u => u.FullName != null && u.FullName.Contains(search.Name));
                    }
                    if (!string.IsNullOrWhiteSpace(search.Email))
                    {
                        query = query.Where(u => u.Email != null && u.Email.Contains(search.Email));
                    }
                    if (!string.IsNullOrWhiteSpace(search.PhoneNumber))
                    {
                        query = query.Where(u => u.PhoneNumber != null && u.PhoneNumber.Contains(search.PhoneNumber));
                    }
                    if (search.Role?.Count > 0 && !search.Role.Contains(0))
                    {
                        query = query.Where(u => u.LnkUserRole.Any(lnk => search.Role.Contains(lnk.RoleId)));
                    }
                    if (search.JobTitle?.Count > 0 && !search.JobTitle.Contains(0))
                    {
                        query = query.Where(u => search.JobTitle.Contains(u.JobTitleId.GetValueOrDefault()));
                    }
                    if (search.Department?.Count > 0 && !search.Department.Contains(0))
                    {
                        query = query.Where(u => search.Department.Contains(u.DepartmentId.GetValueOrDefault()));
                    }
                    if (search.Status > 0)
                    {
                        query = query.Where(u => (search.Status == 1 && u.IsActive == true)
                                                || (search.Status == 2 && u.IsActive != true));
                    }
                }
                result = query.ToList();
            }
            catch { }
            return result.OrderByDescending(p => p.Id).ToList();
        }

        public bool ValidateUser(AppUser user, out string errorMessage)
        {
            errorMessage = string.Empty;
            bool result = true;

            /*if (CheckExist(u => u.Id != user.Id && u.Username == user.Username))
            {
                result = false;
                errorMessage = "Username already exists";
            }
            */
            if (CheckExist(u => u.Id != user.Id && u.Email == user.Email))
            {
                result = false;
                errorMessage = "Email already exists";
            }
            else if (CheckExist(u => u.Id != user.Id && u.PhoneNumber == user.PhoneNumber))
            {
                result = false;
                errorMessage = "Phone number already exists";
            }
            else
            {
                var jobtitle = Context.JobTitle.Find(user.JobTitleId);
                if (jobtitle?.Name.ToLower() == "bbx" && CheckExist(u => u.Id != user.Id && u.JobTitle != null && u.JobTitle.Name.ToLower() == "bbx" && u.DepartmentId == user.DepartmentId))
                {
                    result = false;
                    errorMessage = "Department already has BBX";
                }
            }

            return result;
        }

        public void AttachTerritories(int userId, List<int> territories)
        {
            try
            {
                if (territories != null)
                {
                    var links = territories.Select(t => new UserTerritory
                    {
                        UserId = userId,
                        TerritoryId = t
                    });
                    Context.UserTerritory.AddRange(links);
                }
            }
            catch { }
        }

        public void DetachTerritories(int userId, List<int> territories = null)
        {
            try
            {
                var links = Context.UserTerritory
                                   .Where(lnk => lnk.UserId == userId);

                if (territories != null)
                {
                    links = links.Where(lnk => territories.Contains(lnk.TerritoryId));
                }

                Context.UserTerritory.RemoveRange(links.ToList());
            }
            catch { }
        }

        public bool ChangePassword(string email, string password, string newPassword, out string errorMessage)
        {
            errorMessage = string.Empty;
            string oldHash = PEncryption.Encrypt(password);

            var user = FindOne(u => u.IsActive == true && u.Email.ToLower() == email.ToLower() && u.PasswordHash == oldHash);
            if (user != null)
            {
                string newHash = PEncryption.Encrypt(newPassword);
                user.PasswordHash = newHash;
                user.IsChangedPassword = true;
                Update(user);
                return true;
            }
            else
            {
                errorMessage = "Incorrect password";
                return false;
            }
        }

        public bool ResetPassword(int userId, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            var user = GetByID(userId);
            if (user != null)
            {
                string newHash = PEncryption.Encrypt(password);
                user.PasswordHash = newHash;
                Update(user);
                return true;
            }
            else
            {
                errorMessage = "User not found";
                return false;
            }
        }

        public List<AppUser> GetActiveUsersByTerritoriesAndDepartment(List<int> territories, int? department = null)
        {
            var results = new List<AppUser>();
            try
            {
                if (territories?.Count > 0)
                {
                    results = Context.AppUser
                                     .Include(u => u.JobTitle)
                                     .Where(u => u.IsActive == true
                                                && u.IsDeleted != true
                                                && u.UserTerritory.Any(ut => territories.Contains(ut.TerritoryId))
                                                && u.JobTitleId != null
                                                && (department == null || u.DepartmentId == department))
                                    .ToList();
                }
            }
            catch { }
            return results;
        }

        public List<AppUser> GetAllByCycleId(int cycleId)
        {
            var result = new List<AppUser>();
            try
            {
                result = Context.AppUser
                                .Where(t => t.CycleUser.Any(ut => ut.CycleId == cycleId))
                                .ToList();
            }
            catch
            { }
            return result;
        }

        public override List<AppUser> Find(Expression<Func<AppUser, bool>> predicate)
        {
            var result = new List<AppUser>();
            try
            {
                result = Context.AppUser
                                .Where(u => u.IsSysAdmin != true && u.IsDeleted != true)
                                .Where(predicate)
                                .Include(u => u.JobTitle)
                                .ToList();
            }
            catch
            { }
            return result;
        }

        public override List<AppUser> GetAll()
        {
            var result = new List<AppUser>();
            try
            {
                result = Context.AppUser
                                .Where(u => u.IsDeleted != true && u.IsSysAdmin != true)
                                .Include(u => u.JobTitle)
                                .ToList();
            }
            catch (Exception e)
            { }
            return result;
        }

        public AppUser GetUserWithJobTitle(int userId)
        {
            var model = Context.AppUser.Where(f => f.Id == userId).Include(f => f.JobTitle).FirstOrDefault();
            return model;
        }

        public AppUser GetUserWithDetails(int userId)
        {
            var model = Context.AppUser
                                    .Where(f => f.Id == userId)
                                    .Include(f => f.Department)
                                    .Include(u => u.LnkUserRole)
                                    .FirstOrDefault();
            return model;
        }
        public List<AppUser> GetHrUsers(List<int> selectedusers)
        {
            var list = new List<AppUser>();

            var model = Context.AppUser.ToList();

            model = model.Where(u => selectedusers.Contains(u.Id) && u.JobTitle.Name.ToLower() == "hr").ToList();

            //foreach (var item in selectedusers)
            //{
            //     model =model.Where(u => u.Id == item && u.JobTitle.Name.ToLower()=="hr").ToList();
            //    if (model !=null)
            //    {
            //        list.Add(model);
            //    }

            //}
            return model;
        }
        public bool UserAssignToJobTitle(int id)
        {
            var data = Context.AppUser.Include(u => u.JobTitle).Include(u => u.CycleUser).Where(u => u.JobTitleId == id).Select(u => u.Id);
            if (data.Count() > 0)
            {
                return true;
            }
            else
                return false;

        }
    }
}
