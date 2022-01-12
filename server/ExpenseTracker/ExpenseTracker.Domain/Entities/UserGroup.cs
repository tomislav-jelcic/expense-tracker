namespace ExpenseTracker.Domain.Entities;

public class UserGroup
{
    public int GroupId { get; }
    public int UserId { get; } = default!;
    public User User { get; } = default!;
    public Group Group { get; } = default!;

    public UserGroup(int groupId, int userId)
    {
        GroupId = groupId;
        UserId = userId;
    }
}
