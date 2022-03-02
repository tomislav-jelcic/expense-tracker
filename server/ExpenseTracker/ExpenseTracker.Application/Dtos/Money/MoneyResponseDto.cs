using ExpenseTracker.Domain;

namespace ExpenseTracker.Application.Dtos.Money;

public class MoneyResponseDto
{
    public decimal Amount { get; set; }
    public Currency Currency { get; set; } = default!;
}
