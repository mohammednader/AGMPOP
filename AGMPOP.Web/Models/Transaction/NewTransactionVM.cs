using AGMPOP.BL.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public class NewTransactionVM
    {
        
        public int CycleId { get; set; }
        public int UserId { get; set; }
        public IEnumerable<SelectListItem> CycleList { get; set; }
        //public IEnumerable<SelectListItem> UserList { get; set; }



    }

    public  class TransactionVM
    {

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

        public TransactionVM(AGMPOP.BL.Models.Domain.Transaction trans)
        {
            TransactionId = trans.TransactionId;
            CycleId = trans.CycleId;
            FromUserId = trans.FromUserId;
            TransType = trans.TransType;

        }

    }


}
