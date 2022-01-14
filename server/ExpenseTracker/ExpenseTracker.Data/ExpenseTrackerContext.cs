using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Persistence;
public class ExpenseTrackerContext : DbContext
{
    public DbSet<Account> Accounts { get; set; } = default!;
    public DbSet<Category> Categories { get; set; } = default!;
    public DbSet<Group> Groups { get; set; } = default!;
    public DbSet<Transaction> Transactions { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    public ExpenseTrackerContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountMapping());
        modelBuilder.ApplyConfiguration(new CategoryMapping());
        modelBuilder.ApplyConfiguration(new GroupMapping());
        modelBuilder.ApplyConfiguration(new TransactionMapping());
        modelBuilder.ApplyConfiguration(new UserGroupMapping());
        base.OnModelCreating(modelBuilder);
    }
}
