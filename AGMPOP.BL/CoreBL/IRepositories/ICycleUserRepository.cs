using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ICycleUserRepository:IGenericRepository<CycleUser>
    {
        List<int> GetBBXUserCycle(Expression<Func<CycleUser, bool>> predicate);
        List<UserDetailsDto> GetUserCycle(Expression<Func<CycleUser, bool>> predicate);
        List<CycleVM> GetCycleById(Expression<Func<CycleUser, bool>> predicate);
      
    }
}
