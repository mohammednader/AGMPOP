using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class CycleExport
    {
        public string Name { get; set; }
        public string CycleType { get; set; }

        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ReconciliationDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Display(Name = "Active/InActive")]

        public string IsActive { get; set; }
        public int StockAmount { get; set; }

        public CycleExport(CycleVM obj)
        {
            Name = obj.Name;
            CycleType = Enum.GetName(typeof(POPEnums.CycleType), obj.CycleType).ToString();
            StartDate = obj.StartDate.Value.Date;
            ReconciliationDate = obj.ReconciliationDate.Value;
            EndDate = obj.EndDate.Value;
            Status = Enum.GetName(typeof(POPEnums.CycleStatus), obj.CycleStatus).ToString();
            IsActive = (obj.CycleIsActive == true) ? "Active" : "Inactive";
            StockAmount = obj.TotalItems;
        }

    }
}
