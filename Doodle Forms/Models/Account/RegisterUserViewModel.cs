using System.ComponentModel.DataAnnotations;

namespace Doodle_Forms.Models.Account
{
    public class RegisterUserViewModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "User name must consist at least of 1 character.")]
        [MaxLength(100, ErrorMessage = "User name must not exceed 100 characters.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must consist at least of 8 characters.")]
        [MaxLength(100, ErrorMessage = "Password must not exceed 100 characters.")]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must consist at least of 8 characters.")]
        [MaxLength(100, ErrorMessage = "Password must not exceed 100 characters.")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
