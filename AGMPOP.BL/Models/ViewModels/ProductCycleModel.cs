using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class ProductCycleModel
    {
        public int ProductId { get; set; }
        public int CycleId { get; set; }
        public string ProductName { get; set; }
        public string CycleName { get; set; }
        public int Quantity { get; set; }
        public int RemainingQuant { get; set; }
        public string ProductImg { get; set; }
      //  public int TypeId { get; set; }
        public string Code { get; internal set; }
        public int InventoryQuantity { get; set; }
    }
}
