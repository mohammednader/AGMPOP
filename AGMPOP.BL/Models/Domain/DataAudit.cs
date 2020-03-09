using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class DataAudit
    {
        public int Id { get; set; }
        public int? AuditId { get; set; }
        public string SessionId { get; set; }
        public int? UserId { get; set; }
        public string TableName { get; set; }
        public string ObjectKey { get; set; }
        public int? ActionTypeId { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime? Date { get; set; }

        public virtual AppUser User { get; set; }
    }
}
