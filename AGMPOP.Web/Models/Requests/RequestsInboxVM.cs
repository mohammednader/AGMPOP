using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Requests
{
    public class RequestsInboxVM
    {

        public int ReqAmount { get; set; }
         public int CycleID { get; set; }
         public string CycleName { get; set; }
        public int CycleType { get; set; }
        public int ReqID { get; set; }

        public int ReqByID { get; set; }
        public DateTime ReqDate { get; set; }
        public bool ReqStatus { get; set; }
        public string CreartedByName { get; set; }


    }
}
