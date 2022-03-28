using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;

namespace ExpenseTracker.Application.Persistence;

public class AccountRepository : Repository<Account>, IRepository<Account>
{
    public AccountRepository(ExpenseTrackerContext context) : base(context)
    {
    }
}
