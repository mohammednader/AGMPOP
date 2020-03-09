using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class RequestDetail
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public int? ProductId { get; set; }
        public int? RequestAmount { get; set; }
        public int? ApprovedAmount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }
    }
}
