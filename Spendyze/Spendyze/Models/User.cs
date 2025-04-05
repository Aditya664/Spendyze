using System.ComponentModel.DataAnnotations;

namespace Spendyze.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string Username { get; set; } 

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Password hash cannot exceed 255 characters")]
        public string PasswordHash { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}