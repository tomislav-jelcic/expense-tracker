using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Account;

namespace ExpenseTracker.Application.Operations.Users.Commands;
public record CreateAccount(int OwnerId, AccountRequestDto Payload) : ICommand<AccountResponseDto>;

