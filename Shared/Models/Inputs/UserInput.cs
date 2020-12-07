using System.ComponentModel.DataAnnotations;

namespace BugTracker.Shared.Models.Inputs
{
    public class UserInput
    {
        [EmailAddress]
        [Required(ErrorMessage = "Please fill in the email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You need to set a password.")]
        public string Password { get; set; }
    }
}
