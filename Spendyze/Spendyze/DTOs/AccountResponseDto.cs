using System.ComponentModel.DataAnnotations;

namespace Spendyze.DTOs
{
    public class AccountResponseDto
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public Boolean IsActive { get; set; }
        public int Balance { get; set; }
    }
}
