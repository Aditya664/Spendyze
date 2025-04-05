using Microsoft.AspNetCore.Identity;

namespace Spendyze.Repositories
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user);
    }
}
