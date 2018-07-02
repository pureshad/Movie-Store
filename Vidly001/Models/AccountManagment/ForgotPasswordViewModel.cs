using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.AccountManagment
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
