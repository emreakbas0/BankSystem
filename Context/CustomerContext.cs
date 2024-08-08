using Microsoft.EntityFrameworkCore;

namespace BankSystem.Context;

public class CustomerContext : DbContext
{
    public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
    {
    }
    public DbSet<BankSystem.Models.Customer> Customers { get; set; }

}