using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.User;

public record CreateUser(string LoginId, string FirstName, string LastName) : ICommand<UserResponseDto>;
