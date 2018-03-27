using System.ComponentModel.DataAnnotations;

namespace final_project_cmpickle.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
