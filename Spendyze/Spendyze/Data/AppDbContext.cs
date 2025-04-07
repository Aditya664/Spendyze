using Microsoft.EntityFrameworkCore;
using Spendyze.Models;

namespace Spendyze.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().HasData(
               new Account { Id = 1,AccountName = "Cash", Balance = 0 ,IsActive = true},
               new Account {Id=2,  AccountName = "Bank", Balance = 0, IsActive = true },
               new Account {Id=3,  AccountName = "Credit Cards", Balance = 0, IsActive = true }
           );
        }
    }
}
