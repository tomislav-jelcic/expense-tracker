using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;

namespace ExpenseTracker.Application.Persistence;

public class UserRepository : Repository<User>, IRepository<User>
{
    public UserRepository(ExpenseTrackerContext context) : base(context)
    {
    }
}
