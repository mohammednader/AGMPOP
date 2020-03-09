using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Inventory
{
    public class InventoryExport
    {
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public string DepartmentName { get; set; }
      //  public string Type { get; set; }
    }
}
