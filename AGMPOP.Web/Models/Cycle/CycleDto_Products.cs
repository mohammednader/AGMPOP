using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class CycleDto_Products
    {
        public List<ProductItem> Items { get; set; }

        public CycleDto_Products()
        {
            Items = new List<ProductItem>();
        }
    }

    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int Quantity { get; set; }
        public int MaxQuantity { get; set; }
        public bool Selected { get; set; }
    }
}
