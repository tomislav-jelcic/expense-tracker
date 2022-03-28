namespace ExpenseTracker.Application.Persistence;

public interface IUnitOfWork
{
    public IAccountRepository Accounts { get; }
    public CategoryRepository Categories { get; }
    public GroupRepository Groups { get; }
    public TransactionRepository Transactions { get; }
    public UserRepository Users { get; }

    /// <summary>
    /// Saves changes to the database
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public Task<int> SaveChangesAsync();
}
