using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Transaction
    {
        public Transaction()
        {
            InventoryLog = new HashSet<InventoryLog>();
            Notifications = new HashSet<Notifications>();
            TransactionDetail = new HashSet<TransactionDetail>();
        }

        public long TransactionId { get; set; }
        public int? CycleId { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public int? FromTerritoryId { get; set; }
        public int? ToTerritoryId { get; set; }
        public int? TransType { get; set; }
        public int? Status { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModfiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? RequestId { get; set; }

        public virtual Cycles Cycle { get; set; }
        public virtual AppUser FromUser { get; set; }
        public virtual AppUser ToUser { get; set; }
        public virtual ICollection<InventoryLog> InventoryLog { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetail { get; set; }
    }
}
