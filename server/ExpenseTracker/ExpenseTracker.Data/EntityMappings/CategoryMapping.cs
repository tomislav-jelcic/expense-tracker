using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.EntityMappings;

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
        .IsRequired()
        .HasColumnName("name");

        builder.HasMany(x => x.Transactions)
        .WithOne(x => x.Category)
        .HasForeignKey(x => x.CategoryId)
        .HasConstraintName("category_transactions");
    }
}
