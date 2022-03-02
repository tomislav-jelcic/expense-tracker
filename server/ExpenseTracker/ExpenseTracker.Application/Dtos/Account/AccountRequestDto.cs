using ExpenseTracker.Application.Dtos.Money;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Dtos.Account;
public class AccountRequestDto
{
    public string Name { get; set; } = default!;
    public AccountType Type { get; set; }
    public MoneyRequestDto Balance { get; set; } = default!;

}
