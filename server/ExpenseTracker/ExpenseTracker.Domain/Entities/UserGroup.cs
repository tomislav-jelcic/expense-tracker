namespace ExpenseTracker.Domain.Entities
{
    public class UserGroup
    {
        public int GroupId { get; }
        public string UserId { get; } = default!;
        public User User { get; } = default!;
        public Group Group { get; } = default!;

        public UserGroup(int groupId, string userId)
        {
            GroupId = groupId;
            UserId = userId;
        }
    }
}