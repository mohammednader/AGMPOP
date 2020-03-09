using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Notifications
{
    public class TransactionNotifcation
    {
        public int ProductId { get; set; }
 
        public string ProductName { get; set; }
 
        public decimal Quantity { get; set; }
 
        public string ProductImg { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Code { get; internal set; }
    }
}
