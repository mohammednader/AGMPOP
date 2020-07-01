using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.BL.Repositories
{
    public class CyclesRepository : GenericRepository<Cycles>, ICyclesRepository
    {
        public CyclesRepository(AGMPOPContext context) : base(context)
        {

        }

        public List<Cycles> CycleSearch(CycleVM search, List<int> selectedTerr)
        {
            List<Cycles> results = new List<Cycles>();
            try
            {
                var CurrentDate = DateTime.Now;
                var query = Context.Cycles.Include(f => f.CycleProduct)
                                          .Include(f => f.Department)
                                          .Where(c => c.Department.IsActive == true)
                                          .AsQueryable();
                if (search != null)
                {
                    if (!string.IsNullOrWhiteSpace(search.Name))
                    {
                        query = query.Where(u => u.Name != null && u.Name.Contains(search.Name));
                    }
                    if (search.SearchStartDate != null)
                    {
                        DateTime StartDate = DateTime.ParseExact(search.SearchStartDate, "dd/MM/yyyy HH:mm", null);
                        query = query.Where(u => u.StartDate >= StartDate);
                    }
                    if (search.SearchEndDate != null)
                    {
                        DateTime EndDate = DateTime.ParseExact(search.SearchEndDate, "dd/MM/yyyy HH:mm", null);
                        query = query.Where(u => u.EndDate <= EndDate);
                    }
                    if (search.Status != null)
                    {
                        if (search.Status == (int)POPEnums.CycleStatus.Running)
                        {
                            query = query.Where(c => c.StartDate < CurrentDate && c.EndDate > CurrentDate);
                        }
                        if (search.Status == (int)POPEnums.CycleStatus.Ended)
                        {
                            query = query.Where(c => c.EndDate < CurrentDate);
                        }
                        else if (search.Status == (int)POPEnums.CycleStatus.Upcoming)
                        {
                            query = query.Where(c => c.StartDate > CurrentDate);
                        }

                    }
                    if (search.IsActive?.Count > 0)
                    {
                        query = query.Where(c => search.IsActive.Contains(c.IsActive));
                    }
                    if (search.Type?.Count > 0 && !search.Type.Contains(0))
                    {
                        query = query.Where(c => search.Type.Contains(c.Type));

                    }
                    if (search.DepartmentIds?.Count > 0)
                    {
                        query = query.Where(c => search.DepartmentIds.Contains(c.DepartmentId));
                    }

                    if (selectedTerr.Count > 0)
                    {
                        query = query.Where(c => c.CycleTerritory.Any(t => selectedTerr.Contains(t.TerritoryId)));
                        //query = query.Where(u => u.LnkUserRole.Any(lnk => search.Role.Contains(lnk.RoleId)));

                        //foreach (var item in selectedTerr)
                        //{
                        //    var model = Context.CycleTerritory.Where(f => f.TerritoryId == item).Select(f => f.CycleId).Distinct();
                        //    query = query.Where(c => c.CycleId == item);

                        //}

                    }
                }
                results = query.OrderByDescending(d => d.StartDate)
                               .ThenBy(d => d.EndDate)
                               .ToList();
            }
            catch { }
            return results;
        }

        public List<object> CycleStatusList()
        {
            var result = new List<object>();
            Enum.GetValues(typeof(CycleStatus))
                .Cast<CycleStatus>()
                .ToList()
                .ForEach(e =>
                {
                    result.Add(new { Id = (int)e, Name = e.ToString() });
                });

            return result;
        }
        public List<object> CycleTypeList()
        {
            var result = new List<object>();
            Enum.GetValues(typeof(CycleType))
                .Cast<CycleType>()
                .ToList()
                .ForEach(e =>
                {
                    result.Add(new
                    {
                        TypeId = (int)e,
                        Name = e.ToString().Replace("_", " "),
                    });
                });

            return result;
        }

        public Cycles GetCycleDetails(int cycleid)
        {

            var model = Context.Cycles
                        .Where(f => f.CycleId == cycleid)
                        .Include(f => f.Department)
                        .Include(f => f.CycleTerritory)
                        .Include(f => f.CycleProduct)
                        .Include(f => f.CycleUser)
                        .FirstOrDefault();
            return model;
        }

        public Cycles GetCyclewithDep(int cycleid)
        {
            return Context.Cycles.Where(f => f.CycleId == cycleid).Include(f => f.Department).FirstOrDefault();
        }

        public List<Cycles> GetCycleWithProduct(Expression<Func<Cycles, bool>> predicate = null)
        {
            var query = Context.Cycles.Include(f => f.CycleProduct)
                                      .AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query.OrderByDescending(d => d.StartDate)
                        .ThenBy(d => d.EndDate)
                        .ToList();
        }

        public List<CycleProduct> GetProductwithQnt(int cycleid)
        {
            return Context.CycleProduct.Where(f => f.CycleId == cycleid).Include(f => f.Product).ToList();
        }

        public void AttachTerritories(int cycleId, List<int> territories)
        {
            try
            {
                if (territories != null)
                {
                    var links = territories.Select(t => new CycleTerritory
                    {
                        CycleId = cycleId,
                        TerritoryId = t
                    });
                    Context.CycleTerritory.AddRange(links);
                }
            }
            catch { }
        }

        public void DetachTerritories(int cycleId, List<int> territories = null)
        {
            try
            {
                var links = Context.CycleTerritory
                                   .Where(lnk => lnk.CycleId == cycleId);

                if (territories != null)
                {
                    links = links.Where(lnk => territories.Contains(lnk.TerritoryId));
                }

                Context.CycleTerritory.RemoveRange(links.ToList());
            }
            catch { }
        }

        public void AttachUsers(int cycleId, List<int> users)
        {
            try
            {
                if (users != null)
                {
                    var links = users.Select(u => new CycleUser
                    {
                        CycleId = cycleId,
                        UserId = u,
                    });
                    Context.CycleUser.AddRange(links);
                }
            }
            catch { }
        }

        public void DetachUsers(int cycleId, List<int> users = null)
        {
            try
            {
                var links = Context.CycleUser
                                   .Where(lnk => lnk.CycleId == cycleId);

                if (users != null)
                {
                    links = links.Where(lnk => users.Contains(lnk.UserId));
                }

                Context.CycleUser.RemoveRange(links.ToList());
            }
            catch { }
        }

        public List<CycleUser> GetUserCyclesUserByJobName(int cycleId, string jobTitleName)
        {
            var model = Context.CycleUser
                                    .Include(c => c.User)
                                        .ThenInclude(u => u.JobTitle)
                                     .Where(c =>
                                                     c.CycleId == cycleId &&
                                                     c.User.JobTitle.Name.ToLower() == jobTitleName.ToLower())
                                     .ToList();
            return model;
        }
    }
}
