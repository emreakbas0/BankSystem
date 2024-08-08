using Microsoft.EntityFrameworkCore;

namespace BankSystem.Context;

public class TransactionContext : DbContext
{
    public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
    {
    }
    public DbSet<BankSystem.Models.Transaction> Transactions { get; set; }
}