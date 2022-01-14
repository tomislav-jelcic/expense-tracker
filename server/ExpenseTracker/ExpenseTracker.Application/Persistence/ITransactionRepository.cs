using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Definitions.Persistence;

public interface ITransactionRepository : IRepository<Transaction>
{
}
