using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class UserClearance
    {
        public int UserId { get; set; }
        public int CycleId { get; set; }
        public int ProductId { get; set; }
        public decimal? ClearanceQuantity { get; set; }
        public decimal? TotalQuantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
