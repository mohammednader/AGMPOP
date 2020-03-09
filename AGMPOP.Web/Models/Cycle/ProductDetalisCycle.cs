using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class ProductDetalisCycle
    {
        public int Id { get; set; }
        public int CycleId { get; set; }
        public string CycleName { get; set; }
        public decimal? Quantity { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }

    }
}
