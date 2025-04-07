namespace Spendyze.DTOs
{
    public class AccountRequestDto
    {
        public string AccountName { get; set; }
        public Boolean IsActive { get; set; }
        public int Balance { get; set; }
    }
}
