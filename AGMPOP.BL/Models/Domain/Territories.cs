using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Territories
    {
        public Territories()
        {
            CycleTerritory = new HashSet<CycleTerritory>();
            InverseParent = new HashSet<Territories>();
            UserTerritory = new HashSet<UserTerritory>();
        }

        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }
        public int? ParentId { get; set; }

        public virtual Territories Parent { get; set; }
        public virtual ICollection<CycleTerritory> CycleTerritory { get; set; }
        public virtual ICollection<Territories> InverseParent { get; set; }
        public virtual ICollection<UserTerritory> UserTerritory { get; set; }
    }
}
