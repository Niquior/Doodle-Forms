using System.ComponentModel.DataAnnotations;

namespace Doodle_Forms.Models.Account
{
    public class LoginUserViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email is incorrect!")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
