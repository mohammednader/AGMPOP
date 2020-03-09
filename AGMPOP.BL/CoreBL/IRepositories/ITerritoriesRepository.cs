using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ITerritoriesRepository : IGenericRepository<Territories>
    {

        //custom

        long Save(Territories territory);
        List<AppUser> userTerritory(int id);
        List<Territories> GetAllByUserId(int userId);
        List<Territories> GetAllActive();
        List<TreeModel> InitTerritoies(int? cycleId = null);

        List<TreeModel> CycleTerritoies(int? cycleId = null);

        List<Territories> GetAllByCycleId(int cycleId);
        List<Cycles> GetCycleInTerr(int TerrId);


    }
}
