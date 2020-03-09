using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Cycle
{
    public class _CycleDetalisTab
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Display(Name = "Cycle Name")]
        public string Name { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "This field is required")]
        public int? Type { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "This field is required")]
        public int? Department { get; set; }

        [Display(Name = "Start Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DataType(DataType.Text)]
        public string StartDate { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Reconciliation Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string ReconciliationDate { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "End Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string EndDate { get; set; }

        public bool StartDateDisabled { get; set; }

        public _CycleDetalisTab()
        {

        }

        public _CycleDetalisTab(Cycles cycle)
        {
            if (cycle != null)
            {
                Id = cycle.CycleId;
                Name = cycle.Name;
                Type = cycle.Type;
                Department = cycle.DepartmentId;
                StartDate = cycle.StartDate.ToString("dd/MM/yyyy HH:mm");
                ReconciliationDate = cycle.ReconciliationDate.ToString("dd/MM/yyyy HH:mm");
                EndDate = cycle.EndDate.ToString("dd/MM/yyyy HH:mm");

                StartDateDisabled = cycle.StartDate <= DateTime.Now;
            }
        }

    }
}
