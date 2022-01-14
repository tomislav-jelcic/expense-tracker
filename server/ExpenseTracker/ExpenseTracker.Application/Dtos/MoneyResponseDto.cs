namespace ExpenseTracker.Application.Dtos;

public class MoneyResponseDto
{
    public decimal Amount { get; set; }
    public string Currency { get; set; } = default!;
}
