﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.AccountManagment
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
    }
}
