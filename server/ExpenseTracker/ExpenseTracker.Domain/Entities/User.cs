namespace ExpenseTracker.Domain.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string LoginId { get; set; } = default!;
        public ICollection<UserGroup>? Groups { get; private set; } = default!;
        public ICollection<Account>? Accounts { get; private set; } = default!;

        private User() { }
        public User(string firstName, string lastName, string loginId)
        {
            FirstName = firstName;
            LastName = lastName;
            LoginId = loginId;
        }
    }
}