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
    public class CycleUserRepository : GenericRepository<CycleUser>, ICycleUserRepository
    {
        public CycleUserRepository(AGMPOPContext context) : base(context)
        {

        }

        public List<int> GetBBXUserCycle(Expression<Func<CycleUser, bool>> predicate)
        {
            var query = Context.CycleUser
                                       .Include(c => c.Cycle)
                                       .Include(c => c.User)
                                       .AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            var result = query.Select(c => c.UserId).ToList();
            return result;

        }
        public List<UserDetailsDto> GetUserCycle(Expression<Func<CycleUser, bool>> predicate)
        {
            var query = Context.CycleUser
                                       .Include(c => c.Cycle)
                                       .Include(c => c.User).ThenInclude(u => u.JobTitle)
                                       .AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            var result = query.Select(c => new UserDetailsDto
            {
                Id = c.User.Id,
                Name = c.User.FullName,
                JobTitleId = c.User.JobTitleId ?? 0,
                JobTitleName = c.User.JobTitle.Name,
                DepartmentId = c.User.DepartmentId ?? 0,

            }).ToList();
            return result;

        }

        public List<CycleVM> GetCycleById(Expression<Func<CycleUser, bool>> predicate)
        {
            var result = new List<CycleVM>();
            try
            {
                var query = Context.CycleUser
                                           .Include(c => c.Cycle)
                                           .Include(c => c.User).ThenInclude(u=>u.JobTitle)
                                           .AsQueryable();
                if (predicate != null)
                {
                    query = query.Where(predicate);
                }
                result = query.Select(c => new CycleVM
                {
                    CycleId = c.CycleId,
                    Name = c.Cycle.Name,
                    StartDate = c.Cycle.StartDate.ToUniversalTime().AddTicks(1),
                    ReconciliationDate = c.Cycle.ReconciliationDate.ToUniversalTime().AddTicks(1),
                    EndDate = c.Cycle.EndDate.ToUniversalTime().AddTicks(1),
                    CycleType = c.Cycle.Type,
                    UserTitle = c.User.JobTitle.Name,
                }).ToList();
                return result;
            }
            catch (Exception e)
            {
                return result;

            }
        }

    }
}
