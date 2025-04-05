using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Spendyze.Data
{
    public class AuthDbContext:IdentityDbContext
    {
        
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }

    }
}
