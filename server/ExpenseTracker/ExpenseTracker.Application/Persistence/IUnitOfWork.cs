namespace ExpenseTracker.Application.Persistence;

public interface IUnitOfWork
{
    public IAccountRepository Accounts { get; }
    public ICategoryRepository Categories { get; }
    public IGroupRepository Groups { get; }
    public ITransactionRepository Transactions { get; }
    public IUserRepository Users { get; }

    /// <summary>
    /// Saves changes to the database
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public Task<int> SaveChangesAsync(CancellationToken ct = default!);
}
