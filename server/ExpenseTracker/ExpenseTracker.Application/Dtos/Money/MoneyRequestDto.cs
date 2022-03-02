namespace ExpenseTracker.Application.Dtos.Money;

public class MoneyRequestDto
{
    public decimal Amount { get; set; }
    public string Currency { get; set; } = default!;
}
