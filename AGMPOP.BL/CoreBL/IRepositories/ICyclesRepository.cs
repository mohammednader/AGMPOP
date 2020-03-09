using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ICyclesRepository : IGenericRepository<Cycles>
    {

        //get cycle status
        List<object> CycleStatusList();
        //get cycle type

        List<object> CycleTypeList();
        List<Cycles> CycleSearch(CycleVM search, List<int> selectedTerr);
        List<Cycles> GetCycleWithProduct(Expression<Func<Cycles, bool>> predicate = null);
        // get cycle product with amount

        List<CycleProduct> GetProductwithQnt(int cycleid);

        // get cycle with department name
        Cycles GetCyclewithDep(int cycleid);
        void AttachTerritories(int cycleId, List<int> territories);
        void DetachTerritories(int cycleId, List<int> territories = null);
        void AttachUsers(int cycleId, List<int> users);
        void DetachUsers(int cycleId, List<int> users = null);
        Cycles GetCycleDetails(int cycleid);

        // get cycles assigend to this user
        List<CycleUser> GetUserCyclesUserByJobName(int cycleId, string jobTitleName);


    }
}
