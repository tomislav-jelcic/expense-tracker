using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.EntityMappings;

public class TransactionMapping : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("transactions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CategoryId)
        .HasColumnName("category_id")
        .IsRequired();

        builder.Property(x => x.Description)
        .HasColumnName("description");

        builder.Property(x => x.Time)
        .HasColumnName("transaction_time")
        .IsRequired();

        builder.Property(x => x.OriginatingAccountId)
        .HasColumnName("originatin_account_id");

        builder.Property(x => x.DestinationAccountId)
        .HasColumnName("destination_account_id");

        builder.Property(x => x.TransactionType)
        .HasColumnName("transaction_type")
                    .HasConversion(
                        x => (int)x,
                        x => (TransactionType)x);

        builder.OwnsOne(x => x.Amount)
        .Property(x => x.Currency).IsRequired()
        .HasColumnName("currency");

        builder.OwnsOne(x => x.Amount)
        .Property(x => x.Amount).IsRequired()
        .HasColumnName("amount");
    }
}
