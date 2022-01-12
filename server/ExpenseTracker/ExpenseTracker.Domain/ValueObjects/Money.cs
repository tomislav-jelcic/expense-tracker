namespace ExpenseTracker.Domain.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; } = default!;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Currency.ToString().ToUpper();
            yield return Math.Round(Amount, 2);
        }
    }
}