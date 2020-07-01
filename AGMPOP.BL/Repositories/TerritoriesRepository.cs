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
    public class TerritoriesRepository : GenericRepository<Territories>, ITerritoriesRepository
    {

        public TerritoriesRepository(AGMPOPContext Context) : base(Context)
        {

        }

        public long Save(Territories territory)
        {
            if (territory.TerritoryId == 0)
            {
                
                territory.IsActive = true;
                Context.Territories.Add(territory);
            }
            else
            {
                var EditTerritory = Context.Territories.FirstOrDefault(c => c.TerritoryId == territory.TerritoryId);

                if (!string.IsNullOrEmpty(territory.Name))
                    EditTerritory.Name = territory.Name;
                if (territory.ParentId != null)
                    EditTerritory.ParentId = territory.ParentId;
             }


             return territory.TerritoryId;
        }

        public List<AppUser> userTerritory(int id)
        {
            return Context.UserTerritory
                .Where(f => f.TerritoryId == id)
                .Include(f => f.User)
                .Select(f=>f.User)
                .ToList();
        }

        public List<Territories> GetAllByUserId(int userId)
        {
            var result = new List<Territories>();
            try
            {
                result = Context.Territories
                                .Where(t =>  t.IsActive !=false && t.UserTerritory.Any(ut => ut.UserId == userId))
                                .ToList();
            }
            catch
            { }
            return result;
        }

        public List<Territories> GetAllActive()
        {
            var result = new List<Territories>();
            try
            {
                result = Context.Territories
                                .Where(t => t.IsActive != false)
                                .ToList();
            }
            catch (Exception e)
            { }
            return result;
        }

        public List<TreeModel> InitTerritoies(int? cycleId = null)
        {

            List<TreeModel> TreeLst = new List<TreeModel>();

            try
            {
                var allTerritories = Context.Territories
                                            .Where(s => s.IsActive != false)
                                            .ToList();

                var grantedTerritories = Context.CycleTerritory
                                                .Where(c => c.CycleId == cycleId)
                                                .Include(c => c.Territory)
                                                .Select(c => c.Territory)
                                                .ToList();

                for (int i = 0; i < allTerritories.Count; i++)
                {
                    var item = allTerritories[i];
                    var node = new TreeModel
                    {
                        id = item.TerritoryId.ToString(),
                        state = new TreeNodeStatus(),
                        text = item.Name,
                    };
                    if (item.ParentId == null)
                    {
                        node.parent = "#";
                        node.icon = "fa fa-globe-africa";
                    }
                    else
                    {
                        node.parent = item.ParentId.ToString();
                        node.icon = "fa fa-map-marker-alt";
                    }

                    if (grantedTerritories.Contains(item) && allTerritories.All(n => n.ParentId != item.TerritoryId))
                    {
                        node.state.opened = true;
                        node.state.selected = true;
                    }

                    TreeLst.Add(node);
                }


                TreeLst.OrderBy(c => c.text).ToList();
                return TreeLst;
            }

            catch (Exception e)
            {
                return TreeLst = null;

            }
        }

        public List<TreeModel> CycleTerritoies(int? cycleId = null){
 
            List<TreeModel> TreeLst = new List<TreeModel>();
            try { 
            var selectedTerritories = Context.CycleTerritory.Where(c => c.CycleId == cycleId)
                                              .Where(c => c.CycleId == cycleId)
                                              .Include(c => c.Territory)
                                              .Select(c => c.Territory)
                                              .ToList();
                for (int i = 0; i < selectedTerritories.Count; i++)
                {
                    var item = selectedTerritories[i];
                    var node = new TreeModel
                    {
                        id = item.TerritoryId.ToString(),
                        state = new TreeNodeStatus(),
                        text = item.Name,
                    };
                    if (item.ParentId == null)
                    {
                        node.parent = "#";
                        node.icon = "fa fa-globe-africa";
                    }
                    else
                    {
                        node.parent = item.ParentId.ToString();
                        node.icon = "fa fa-map-marker-alt";
                    }
                    node.state.opened = true;
                    node.state.selected = true;
                    TreeLst.Add(node);

                }
                    return TreeLst;
                
            }
            catch (Exception ex) {  }
            return TreeLst;

        }


        public List<Territories> GetAllByCycleId(int cycleId)
        {
            var result = new List<Territories>();
            try
            {
                result = Context.Territories
                                .Where(t => t.IsActive != false && t.CycleTerritory.Any(ut => ut.CycleId == cycleId))
                                .ToList();
            }
            catch
            { }
            return result;
        }

        public List<Cycles> GetCycleInTerr(int TerrId)
        {
            return Context.CycleTerritory
                .Where(f => f.TerritoryId == TerrId)
                .Include(f => f.Cycle)
                .Select(f => f.Cycle)
                .ToList();

        }
    }
}
