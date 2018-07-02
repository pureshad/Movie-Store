using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.ViewModelsManagment
{

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}