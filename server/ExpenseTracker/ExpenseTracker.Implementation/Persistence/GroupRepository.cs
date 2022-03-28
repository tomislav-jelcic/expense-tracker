using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;

namespace ExpenseTracker.Application.Persistence;

public class GroupRepository : Repository<Group>, IRepository<Group>
{
    public GroupRepository(ExpenseTrackerContext context) : base(context)
    {
    }
}
