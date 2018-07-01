using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.AccountManagment
{

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
