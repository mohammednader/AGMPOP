using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class CycleUser
    {
        public int UserId { get; set; }
        public int CycleId { get; set; }

        public virtual Cycles Cycle { get; set; }
        public virtual AppUser User { get; set; }
    }
}
