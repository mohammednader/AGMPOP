using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Inventory
{
    public class InventoryTransaction
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal OldQuantity { get; set; }
        public decimal NewQuantity { get; set; }
        public decimal Quantity { get; set; }

        public string CreatedDate { get; set; }
        public string Type { get; internal set; }

        public string date { get; set; }
        public string createdBy { get; set; }
        public string productName { get; set; }
        public string image { get; set; }
        public int typeId { get; internal set; }
        public string CycleName { get; set; }

        public InventoryTransaction(InventoryLog log)
        {
            ProductId = log.ProductId.GetValueOrDefault();
            image = log.Product.Image;
            Name = log.Product.Name;
            CycleName = log.Transaction?.Cycle.Name;
            Quantity = log.Quantity.GetValueOrDefault();
            OldQuantity = log.OldQnty.GetValueOrDefault();
            NewQuantity = log.NewQnty.GetValueOrDefault();
            typeId = log.ActionType.GetValueOrDefault();
            date = log.CreatedDate.GetValueOrDefault().ToString();
        }
    }


    public class InventoryTransactionExport
    {
        public string ProductName { get; set; }
        public decimal OldQuantity { get; set; }
        public decimal NewQuantity { get; set; }
        public decimal Quantity { get; set; }
        public string ActionType { get; set; }
        public string CreatedDate { get; set; }
        public string createdBy { get; set; }

        public string CycleName { get; set; }

    }


}
