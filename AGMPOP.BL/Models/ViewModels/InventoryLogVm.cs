using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
  public  class InventoryLogVm
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal OldQuantity { get; set; }
        public decimal NewQuantity { get; set; }
        public decimal Quantity { get; set; }

        public string CreatedDate { get; set; }
        public string Type { get; set; }

        public string createdDate { get; set; }
        public string createdBy { get; set; }
        public string productName { get; set; }
        public string image { get; set; }
        public int typeId { get;  set; }
        public int userId { get;  set; }

    }
}
