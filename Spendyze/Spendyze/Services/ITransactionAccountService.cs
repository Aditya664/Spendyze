using Spendyze.DTOs;

namespace Spendyze.Services
{
    public interface ITransactionAccountService
    {
        public Task<List<AccountResponseDto>> GetTransactionAccountsAsync();
        public Task<AccountResponseDto> GetTransactionAccountByIdAsync(int id);
        public Task<AccountResponseDto> DeleteTransactionAccountByIdAsync(int id);
        public Task<AccountResponseDto?> AddTransactionAccount(AccountRequestDto accountReque);

    }
}
