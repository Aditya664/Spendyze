using System.ComponentModel.DataAnnotations;

namespace Spendyze.DTOs
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 50 characters")]
        public string Password { get; set; }
    }
}
