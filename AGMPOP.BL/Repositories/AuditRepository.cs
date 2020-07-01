using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGMPOP.BL.Repositories
{
   public class AuditRepository : GenericRepository<DataAudit>, IAuditRepository
    {
        public AuditRepository(AGMPOPContext context) : base(context)
        {

        }


        public List<DataAudit> AuditSearch(AuditSearchVM search)
        {

            List<DataAudit> results = new List<DataAudit>();
            try
            {
                var CurrentDate = DateTime.Now;
                var query = Context.DataAudit.Include(f => f.User)
                                             .AsQueryable();
                if (search != null)
                {
                    if (search.DepartmentIds?.Count > 0)
                    {
                  query = query.Where(c => search.DepartmentIds.Contains(c.User.DepartmentId));
                    }
                    if (search.Users?.Count > 0)
                    {
                        query = query.Where(c => search.Users.Contains(c.UserId));
                    }
                    if (search.StartDate != null)
                    {
                        DateTime StartDate = DateTime.ParseExact(search.StartDate, "dd/MM/yyyy HH:mm", null);
                        query = query.Where(u => u.Date >= StartDate);
                    }
                    if (search.StartDate != null)
                    {
                        DateTime EndDate = DateTime.ParseExact(search.EndDate, "dd/MM/yyyy HH:mm", null);
                        query = query.Where(u => u.Date <= EndDate);
                    }
                    if (search.Actions?.Count > 0)
                    {
                        query = query.Where(c => search.Actions.Contains(c.ActionTypeId));
                    }

                }
                results = query.OrderByDescending(au => au.Date).ToList();
            }
            catch (Exception e)
            {

            }
            return results;
        }

    }
}
