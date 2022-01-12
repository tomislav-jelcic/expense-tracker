using ExpenseTracker.Domain.ValueObjects;

namespace ExpenseTracker.Domain.Entities
{
    public class Transaction : IEntity
    {
        public int Id { get; }
        public Money Amount { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public DateTime Time { get; private set; }
        public int CategoryId { get; }
        public Category Category { get; private set; } = default!;
        public TransactionType TransactionType { get; private set; } = default!;
        public int OriginatingAccountId { get; }
        public Account OriginatingAccount { get; private set; } = default!;
        public int? DestinationAccountId { get; private set; }
        public Account? DestinationAccount { get; private set; }

        private Transaction()
        {
        }

        public static Transaction CreateExpenditure(Money amount, string description, Category category, Account originatingAccount, DateTime? transactionTime = null)
        {
            return new Transaction()
            {
                Amount = amount,
                Description = description,
                Category = category,
                TransactionType = TransactionType.Expenditure,
                OriginatingAccount = originatingAccount,
                Time = transactionTime ?? DateTime.UtcNow
            };
        }

        public static Transaction CreateIncome(Money amount, string description, Category category, Account destinationAccount, DateTime? transactionTime = null)
        {
            return new Transaction()
            {
                Amount = amount,
                Description = description,
                Category = category,
                TransactionType = TransactionType.Income,
                DestinationAccount = destinationAccount,
                Time = transactionTime ?? DateTime.UtcNow
            };
        }

        public static IList<Transaction> CreateTransfer(Money amount, string description, Category category, Account originatingAccount, Account destinationAccount, DateTime? transactionTime = null)
        {
            transactionTime = transactionTime ?? DateTime.UtcNow;
            var outgoingTransfer = CreateExpenditure(amount, description, category, originatingAccount, transactionTime);
            var incomingTransfer = CreateIncome(amount, description, category, destinationAccount, transactionTime);
            return new List<Transaction>(){
                outgoingTransfer,
                incomingTransfer
            };
        }
    }
}