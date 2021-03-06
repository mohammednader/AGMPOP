﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public class ResetPasswordDto
    {
        [Required(AllowEmptyStrings = false)]
        public int Id { get; set; }

        [DisplayName("New Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [MinLength(6, ErrorMessage = "Password should be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm New Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Compare(nameof(Password), ErrorMessage = "Password doesn't match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
