using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            AppUser = new HashSet<AppUser>();
        }

        public int JobTitleId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public virtual ICollection<AppUser> AppUser { get; set; }
    }
}
