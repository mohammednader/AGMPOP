using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Transaction
{
    public class TransactionExport
    {
    
        [Display(Name ="Cycle Name")]
        public string CycleName { get; set; }
        public string FromUserName { get; set; }
        public string ToUser { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string  Type { get; set; }
        public int TotalItem { get; set; }

    }
}
