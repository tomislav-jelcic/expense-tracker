using ExpenseTracker.Domain;

namespace ExpenseTracker.Application.Dtos.Money;

public class MoneyRequestDto
{
    public decimal Amount { get; set; }
    public Currency Currency { get; set; }
}
