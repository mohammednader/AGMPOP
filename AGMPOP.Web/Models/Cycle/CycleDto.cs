using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class CycleDto
    {
        public int Id { get; set; }

        [Required]
        public _CycleDetalisTab Details { get; set; }
        [Required]
        public string Territories { get; set; }
        [Required]
        public List<ProductItem> Products { get; set; }
        [Required]
        public List<int> Users { get; set; }
        public int HRUser { get; set; }
        public int BBXUser { get; set; }
        public CycleDto()
        {
            Products = new List<ProductItem>();
            Users = new List<int>();
        }
    }
}
