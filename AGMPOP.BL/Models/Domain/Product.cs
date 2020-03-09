using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Product
    {
        public Product()
        {
            CycleProduct = new HashSet<CycleProduct>();
            InventoryLog = new HashSet<InventoryLog>();
            RequestDetail = new HashSet<RequestDetail>();
            TransactionDetail = new HashSet<TransactionDetail>();
            UserClearance = new HashSet<UserClearance>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? TypeId { get; set; }
        public string Image { get; set; }
        public string ImageSize { get; set; }
        public bool IsActive { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? InventoryQnty { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CycleProduct> CycleProduct { get; set; }
        public virtual ICollection<InventoryLog> InventoryLog { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetail { get; set; }
        public virtual ICollection<UserClearance> UserClearance { get; set; }
    }
}
