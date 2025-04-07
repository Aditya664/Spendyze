using Microsoft.EntityFrameworkCore;
using Spendyze.Data;
using Spendyze.DTOs;
using Spendyze.Models;

namespace Spendyze.Services
{
    public class TransactionAccountService : ITransactionAccountService
    {
        private readonly AppDbContext _context;

        public TransactionAccountService(AppDbContext context) {  _context = context; }
        public Task<AccountResponseDto?> AddTransactionAccount(AccountRequestDto accountReque)
        {
            throw new NotImplementedException();
        }

        public Task<AccountResponseDto> DeleteTransactionAccountByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AccountResponseDto> GetTransactionAccountByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AccountResponseDto>> GetTransactionAccountsAsync()
        {
            try
            {
                var accounts = await _context.Accounts.ToListAsync();
                var accountsList = new List<AccountResponseDto>();
                if (accounts != null)
                {
                    foreach (var account in accounts)
                    {
                        var dto = new AccountResponseDto
                        {
                            Id = account.Id,
                            AccountName = account.AccountName,
                            Balance = account.Balance,
                            IsActive = account.IsActive,
                        };

                        accountsList.Add(dto);
                    }
                }
                return accountsList;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to fetch transaction accounts.", ex);
            }
        }
    }
}
