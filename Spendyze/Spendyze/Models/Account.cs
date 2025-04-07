using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spendyze.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Account is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Account must be between 3 and 50 characters")]
        public string AccountName { get; set; }

        public Boolean IsActive {  get; set; } = true;

        public int Balance { get; set; } = 0;

    }
}
