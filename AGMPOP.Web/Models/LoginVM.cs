using System.ComponentModel.DataAnnotations;

namespace AGMPOP.Web.Models
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
