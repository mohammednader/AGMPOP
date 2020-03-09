using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class CycleProduct
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? CycleId { get; set; }
        public int? Qunt { get; set; }
        public int? RemainQunt { get; set; }

        public virtual Cycles Cycle { get; set; }
        public virtual Product Product { get; set; }
    }
}
