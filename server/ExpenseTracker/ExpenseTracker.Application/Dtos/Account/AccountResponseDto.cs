using ExpenseTracker.Application.Dtos.Money;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Dtos.Account;
public class AccountResponseDto
{
    public int Id { get; set; }
    public string OwnerId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AccountType Type { get; set; } = default!;
    public MoneyResponseDto Balance { get; set; } = default!;
}
