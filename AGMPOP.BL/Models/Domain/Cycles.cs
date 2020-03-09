using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Cycles
    {
        public Cycles()
        {
            CycleProduct = new HashSet<CycleProduct>();
            CycleTerritory = new HashSet<CycleTerritory>();
            CycleUser = new HashSet<CycleUser>();
            Request = new HashSet<Request>();
            Transaction = new HashSet<Transaction>();
        }

        public int CycleId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReconciliationDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CycleProduct> CycleProduct { get; set; }
        public virtual ICollection<CycleTerritory> CycleTerritory { get; set; }
        public virtual ICollection<CycleUser> CycleUser { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
