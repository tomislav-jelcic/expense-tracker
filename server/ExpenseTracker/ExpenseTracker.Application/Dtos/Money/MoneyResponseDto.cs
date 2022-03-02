namespace ExpenseTracker.Application.Dtos.Money;

public class MoneyResponseDto
{
    public decimal Amount { get; set; }
    public string Currency { get; set; } = default!;
}
