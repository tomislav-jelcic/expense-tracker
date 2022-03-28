using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;

namespace ExpenseTracker.Application.Persistence;

public class TransactionRepository : Repository<Transaction>, IRepository<Transaction>
{
    public TransactionRepository(ExpenseTrackerContext context) : base(context)
    {
    }
}
