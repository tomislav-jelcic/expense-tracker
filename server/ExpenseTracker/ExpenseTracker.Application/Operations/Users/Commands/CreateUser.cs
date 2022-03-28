using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.User;

namespace ExpenseTracker.Application.Operations.Users.Commands;

public record CreateUser(string LoginId, string FirstName, string LastName) : ICommand<UserResponseDto>;
