using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class TransactionCycle
    {
        public string FromUserName { get; set; }
        
        public string ToUserName { get; set; }
      
        public int Type { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public long TransId { get; set; }
        public List<TransactionDetail> TotalItem { get; set; }
        [Display(Name = "Cycle Name")]

        public string CycleName { get; set; }
        public int CycleId { get; set; }
        public List<int>  types  { get; set; }
        public List<int> status { get; set; }
        public string Product { get; set; }
        public int userId { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }


    }
}
