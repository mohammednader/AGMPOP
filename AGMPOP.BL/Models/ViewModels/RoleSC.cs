using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.BL.Models.ViewModels
{
    public class RoleSC
    {
        public string Name { get; set; }
        public List<int> CreatedBy { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }

        public RoleSC()
        {
            CreatedBy = new List<int>();
        }
    }
}
