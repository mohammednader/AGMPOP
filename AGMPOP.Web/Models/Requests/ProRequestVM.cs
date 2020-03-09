using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Requests
{
    public class ProRequestVM
    {

        public int RequestAmount { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CycleName { get; set; }
        public int CycleId { get; set; }
        public decimal InventoryQuantity { get; set; }

    }
}
