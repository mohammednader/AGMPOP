using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Request
    {
        public Request()
        {
            RequestDetail = new HashSet<RequestDetail>();
        }

        public int RequestId { get; set; }
        public int? CycleId { get; set; }
        public bool Status { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModfiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedById { get; set; }

        public virtual AppUser CreatedBy { get; set; }
        public virtual Cycles Cycle { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
    }
}
