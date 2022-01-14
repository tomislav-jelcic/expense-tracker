using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Persistence;

public interface ITransactionRepository : IRepository<Transaction>
{
}
