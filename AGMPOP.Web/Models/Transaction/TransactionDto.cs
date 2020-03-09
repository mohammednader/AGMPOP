
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Transaction
{
    public class TransactionDto
    {
        public string cycle_id { get; set; }
        public string to_user_id { get; set; }
        public string action_id { get; set; }
        public List<TransactionProduct> transaction_items { get; set; }

    }

    public class TransactionProduct
    {
        public int productId { get; set; }
        public int count { get; set; }
        public TransactionProduct() { }
        public TransactionProduct(BL.Models.Domain.TransactionDetail transactionDetail)
        {
            productId = transactionDetail.ProductId;
            count = transactionDetail.TransAmount;
        }
    }

    public class ClearnceDTo
    {
        public int cycle_id { get; set; }
        public int NotificationId { get; set; }
        public int TransactionId { get; set; }
        public List<TransactionProduct> transaction_items { get; set; }

    }

}
