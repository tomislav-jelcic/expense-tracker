using ExpenseTracker.Domain.ValueObjects;

namespace ExpenseTracker.Domain.Entities;

/// <summary>
/// Defines an user money account
/// </summary>
public class Account : IEntity
{
    public int Id { get; }
    public int OwnerId { get; }
    public User Owner { get; } = default!;
    public string Name { get; } = default!;
    public AccountType Type { get; } = default!;
    public Money Balance { get; } = default!;
    private readonly List<Transaction> _originatingTransactions = default!;
    private readonly List<Transaction> _destinationTransactions = default!;
    public IReadOnlyCollection<Transaction> OriginatingTransactions => _originatingTransactions.AsReadOnly();
    public IReadOnlyCollection<Transaction> DestinationTransactions => _destinationTransactions.AsReadOnly();

    private Account()
    {
    }

    public Account(User owner, string name, AccountType type, Money startingBalance)
    {
        Owner = owner;
        Name = name;
        Type = type;
        Balance = startingBalance;
    }
}
