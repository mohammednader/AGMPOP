using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
   public class AuditSearchVM
    {


        public List<int?> Users { get; set; }
        [Display(Name = "Department")]

        public List<int?> DepartmentIds { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Start Date")]

        public string StartDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "End Date")]

        public string EndDate { get; set; }

        public List<int?> Actions { get; set; }

       
        public string SessionId { get; set; }
        public string UserName{ get; set; }
        public string TableName { get; set; }
        public string ObjectKey { get; set; }
        public string  ActionName { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime? Date { get; set; }


    }
}
