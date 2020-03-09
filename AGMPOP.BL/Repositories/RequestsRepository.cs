using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class RequestsRepository : GenericRepository<Request>, IRequestsRepository
    {
        public RequestsRepository(AGMPOPContext context) : base(context)
        {

        }

        public IEnumerable<Request> FilterRequest(Request request, DateTime to_Date)
        {

            var query = Context.Request
                                        .Include(f => f.Cycle)
                                        .Include(f => f.RequestDetail)
                                        .Include(f => f.CreatedBy.JobTitle).AsQueryable();
            if (request.Status != null)
            {
                query = query.Where(p => p.Status == request.Status);
            }

            if (request.CreateDate != null)
            {
                query = query.Where(p => p.CreateDate >= request.CreateDate);

            }

            if (to_Date != DateTime.MinValue)
            {
                query = query.Where(p => p.CreateDate <= to_Date);
            }

            return query.ToList();
        }

        public List<Request> GetAllRequests(Expression<Func<Request, bool>> predicate)
        {
            // where user id 
            //  var UserId = Context.AppUser.Where(f => f.Id == 1).FirstOrDefault();
            var query = Context.Request.Include(f => f.RequestDetail)
                                       .Include(f => f.Cycle)
                                       .Include(f => f.CreatedBy.JobTitle)
                                       .OrderByDescending(f => f.CreateDate).AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);

            }
            return query.ToList();
        }

        public List<RequestDetail> GetRequestDetails(Expression<Func<RequestDetail, bool>> predicate= null)
        {
            var query = Context.RequestDetail
                                             .Include(f => f.Product)
                                             .Include(f => f.Request).ThenInclude(f=>f.Cycle)                                                                  
                                            .AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ToList();
        }

        public List<CycleUser> GetUserCycles(Expression<Func<CycleUser, bool>> predicate)
        {
            var query = Context.CycleUser
                                        .Include(f => f.Cycle)
                                        .Include(f => f.User)
                                        .AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ToList();
        }

        
       

        public void UpdateRequestDetalis(RequestDetail requestDetail)
        {
            Context.RequestDetail.Update(requestDetail);

        }
    }
}
