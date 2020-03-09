using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Department
    {
        public Department()
        {
            AppUser = new HashSet<AppUser>();
            Cycles = new HashSet<Cycles>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<Cycles> Cycles { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
