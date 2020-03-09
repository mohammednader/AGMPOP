using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IRequestsRepository : IGenericRepository<Request>
    {

        // custom 

        List<Request> GetAllRequests(Expression<Func<Request, bool>> predicate=null);
        // request details
        List<RequestDetail> GetRequestDetails(Expression<Func<RequestDetail, bool>> predicate);

        // get cycles for one user
        List<CycleUser> GetUserCycles(Expression<Func<CycleUser, bool>> predicate);
 
        
        void UpdateRequestDetalis(RequestDetail requestDetail);

        IEnumerable<Request> FilterRequest(Request request, DateTime to_Date);
      
        

    }
}
