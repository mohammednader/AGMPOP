using AGMPOP.BL.Models.Domain;
using AGMPOP.Web.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Phone number")]
        [RegularExpression("01[0-9]{9}",ErrorMessage = "Please enter valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Display(Name = "Job title")]
        public int? JobTitle { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Display(Name = "Role(s)")]
        public List<int?> Roles { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public int? Department { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public string SelectedTerritories { get; set; }

        public UserDto()
        {
            IsActive = true;
            Roles = new List<int?>();
        }

        public UserDto(AppUser u)
        {
            if (u != null)
            {
                Id = u.Id;
                Name = u.FullName;
                Email = u.Email;
                PhoneNumber = u.PhoneNumber;
                JobTitle = u.JobTitleId;
                IsActive = u.IsActive ?? false;
                Department = u.DepartmentId;
                Roles = u.LnkUserRole.Select(lnk => (int?)lnk.RoleId).ToList();
            } else
            {
                IsActive = true;
                Roles = new List<int?>();
            }
        }
    }

    public class AddUserDto : UserDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [MinLength(6, ErrorMessage = "Password should be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        [DataType(DataType.Password)]
        [Display(Name= "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public AddUserDto() : base()
        {
        }

        public AddUserDto(AppUser u) : base(u)
        {
        }
    }
}
