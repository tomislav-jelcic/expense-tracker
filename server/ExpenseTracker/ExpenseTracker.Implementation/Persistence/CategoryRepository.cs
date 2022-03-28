using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;

namespace ExpenseTracker.Application.Persistence;

public class CategoryRepository : Repository<Category>, IRepository<Category>
{
    public CategoryRepository(ExpenseTrackerContext context) : base(context)
    {
    }
}
