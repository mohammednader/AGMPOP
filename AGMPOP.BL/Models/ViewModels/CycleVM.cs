using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class CycleVM
    {

        public int CycleId { get; set; }
        [Display(Name = "Cycle Name")]

        public string Name { get; set; }
        public List<int?> Type { get; set; }
        public int CycleType { get; set; }

        public int? Status { get; set; }
        public int CycleStatus { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Display(Name = "Reconciliation Date")]
        public DateTime? ReconciliationDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Active/InActive")]
        public List<bool?> IsActive { get; set; }
        public bool CycleIsActive { get; set; }
        public string SelectedTerritories { get; set; }
        public int StockAmount { get; set; }
        public int TotalItems { get; set; }
        public string Department { get; set; }
        public List<int?> DepartmentIds { get; set; }
        public int AvailableItems { get; internal set; }
        public string UserTitle { get; internal set; }
        public string DepartmentName { get; set; }
        public string SearchStartDate { get; set; }
        public string SearchEndDate { get; set; }
        public CycleVM()
        {
            Type = new List<int?>();
            IsActive = new List<bool?>();
            DepartmentIds = new List<int?>();
        }
        public CycleVM(Cycles c)
        {
            CycleId = c.CycleId;
            Name = c.Name;
            CycleType = c.Type;
            StartDate = c.StartDate;
            ReconciliationDate = c.ReconciliationDate;
            EndDate = c.EndDate;
            CycleStatus = c.Status;
            CycleIsActive = c.IsActive;
            StockAmount = c.CycleProduct.Sum(d => d.Qunt).GetValueOrDefault();
            DepartmentName = c.Department?.Name;
        }
    }
}
