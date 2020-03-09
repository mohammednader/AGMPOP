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
}
