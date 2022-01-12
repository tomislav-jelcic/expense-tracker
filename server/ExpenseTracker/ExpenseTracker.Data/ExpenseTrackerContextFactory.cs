using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExpenseTracker.Data;
public class ExpenseTrackerContextFactory : IDesignTimeDbContextFactory<ExpenseTrackerContext>
{
    public ExpenseTrackerContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ExpenseTrackerContext>();
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ExpenseTracker;User Id=postgres;Password=postgres;");

        return new ExpenseTrackerContext(optionsBuilder.Options);
    }
}
