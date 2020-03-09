using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
   public class TransactionDetailsAPI
    {

        public string FromUserName { get; set; }

        public string ToUserName { get; set; }

        public int Type { get; set; }
        public DateTime? Date { get; set; }
        public int Status { get; set; }
      //  public long TransId { get; set; }
        public string CycleName { get; set; }
        public int CycleId { get; set; }
        public string Product { get; set; }
        public int userId { get; set; }
        public int TotalItem { get; internal set; }
        public string TypeName { get; internal set; }
        public string statusName { get; internal set; }
        public int TransactionId { get; internal set; }
        public string JobTitleId { get; internal set; }
    }
}
