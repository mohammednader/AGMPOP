using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class InventoryLog
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public decimal? OldQnty { get; set; }
        public decimal? NewQnty { get; set; }
        public decimal? Quantity { get; set; }
        public int? TransactionType { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ActionType { get; set; }
        public long? TransactionId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
