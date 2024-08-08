using Microsoft.EntityFrameworkCore;

namespace BankSystem.Context;

public class AccountContext : DbContext
{
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
    }
    public DbSet<BankSystem.Models.Account> Accounts { get; set; }
}