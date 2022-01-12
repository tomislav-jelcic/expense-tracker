using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.EntityMappings;
public class AccountMapping : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("accounts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
        .HasColumnName("name")
        .IsRequired();

        builder.Property(x => x.OwnerId)
        .HasColumnName("owner_id")
        .IsRequired();

        builder.Property(x => x.Type)
        .HasColumnName("type")
        .HasConversion(x => (int)x, y => (AccountType)y);

        builder.HasMany(x => x.DestinationTransactions)
        .WithOne(x => x.DestinationAccount!)
        .HasForeignKey(x => x.DestinationAccountId)
        .HasConstraintName("accounts_destination_transactions");

        builder.HasMany(x => x.OriginatingTransactions)
        .WithOne(x => x.OriginatingAccount)
        .HasForeignKey(x => x.OriginatingAccountId)
        .HasConstraintName("accounts_originating_transactions");

        builder.OwnsOne(x => x.Balance)
        .Property(x => x.Amount).IsRequired()
        .HasColumnName("amount");

        builder.OwnsOne(x => x.Balance)
        .Property(x => x.Currency).IsRequired()
        .HasColumnName("currency");

        builder.HasOne(x => x.Owner)
        .WithMany(x => x.Accounts)
        .HasForeignKey(x => x.OwnerId);
    }
}
