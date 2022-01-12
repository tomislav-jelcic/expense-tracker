namespace ExpenseTracker.Domain.Entities;

/// <summary>
/// Defines a category under which an expense is tracked
/// </summary>
public class Category : IEntity
{
    public int Id { get; }
    public string Name { get; }
    public ICollection<Transaction> Transactions { get; } = default!;
    public Category(string name)
    {
        Name = name;
    }
}
