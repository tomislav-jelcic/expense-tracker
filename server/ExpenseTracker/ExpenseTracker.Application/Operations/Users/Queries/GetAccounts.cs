using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Account;

namespace ExpenseTracker.Application.Operations.Users.Queries;
public record GetAccounts(int OwnerId) : IQuery<IReadOnlyCollection<AccountResponseDto>>;
