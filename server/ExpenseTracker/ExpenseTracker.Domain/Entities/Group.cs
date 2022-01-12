namespace ExpenseTracker.Domain.Entities;

/// <summary>
/// Defines a user group under which more users track their expenses
/// </summary>
public class Group : IEntity
{
    public int Id { get; }
    public string Name { get; }

    public ICollection<UserGroup>? GroupUsers { get; private set; }

    public Group(string name)
    {
        Name = name;
    }

    public void AddUserToGroup(int userId)
    {
        GroupUsers ??= new List<UserGroup>();
        var newMember = new UserGroup(Id, userId);
        GroupUsers.Add(newMember);
    }
}
