using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class CycleDto_Users
    {
        public List<UserItem> Items { get; set; }

        public CycleDto_Users()
        {
            Items = new List<UserItem>();
        }
    }

    public class UserItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public int TerritoryId { get; set; }
        public int DepartmentId { get; set; }
        public bool Selected { get; set; }
        public int ids { get; internal set; }
    }
}
