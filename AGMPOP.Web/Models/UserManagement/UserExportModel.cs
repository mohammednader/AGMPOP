using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.UserManagement
{
    public class UserExportModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DisplayName("Role(s)")]
        public string Roles { get; set; }
        public string JobTitle { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public UserExportModel() { }

        public UserExportModel(AppUser u)
        {
            Id = u.Id;
            Name = u.FullName;
            Email = u.Email;
            PhoneNumber = u.PhoneNumber;
            JobTitle = u.JobTitle?.Name;
            IsActive = u.IsActive ?? false;
            CreationDate = u.CreationDate;
            LastModifiedDate = u.LastModificationDate;
        }
    }
}
