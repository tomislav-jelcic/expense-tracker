namespace ExpenseTracker.Application.Dtos.User;
public class UserResponseDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string LoginId { get; set; } = default!;
}
