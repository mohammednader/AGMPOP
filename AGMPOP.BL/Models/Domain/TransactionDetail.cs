using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class TransactionDetail
    {
        public int Id { get; set; }
        public long TransactionId { get; set; }
        public int ProductId { get; set; }
        public int TransAmount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
