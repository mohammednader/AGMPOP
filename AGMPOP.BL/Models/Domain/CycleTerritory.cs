using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class CycleTerritory
    {
        public int Id { get; set; }
        public int TerritoryId { get; set; }
        public int CycleId { get; set; }

        public virtual Cycles Cycle { get; set; }
        public virtual Territories Territory { get; set; }
    }
}
