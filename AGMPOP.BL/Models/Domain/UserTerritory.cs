using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class UserTerritory
    {
        public int UserId { get; set; }
        public int TerritoryId { get; set; }

        public virtual Territories Territory { get; set; }
        public virtual AppUser User { get; set; }
    }
}
