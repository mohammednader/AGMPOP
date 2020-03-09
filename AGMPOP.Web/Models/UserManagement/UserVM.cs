using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Roles { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public bool IsActive { get; set; }

        public UserVM(AppUser u)
        {
            Id = u.Id;
            Name = u.FullName;
            Email = u.Email;
            PhoneNumber = u.PhoneNumber;
            JobTitle = u.JobTitle?.Name;
            Department = u.Department?.Name;
            IsActive = u.IsActive ?? false;
        }
    }
}
