using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spendyze.DTOs;
using Spendyze.Services;

namespace Spendyze.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionAccountController : ControllerBase
    {
        private readonly ITransactionAccountService _transactionAccountService;
        
        public TransactionAccountController(ITransactionAccountService transactionAccountService) { _transactionAccountService = transactionAccountService; }

        [HttpGet]
        [Route("GetAllAccounts")]
        public async Task<ActionResult<List<AccountResponseDto>>> GetAll()
        {
            var accounts = await _transactionAccountService.GetTransactionAccountsAsync();
            return Ok(accounts);
        }
    }
}
