using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Persistence.EntityMappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.Property(x => x.FirstName)
        .HasColumnName("first_name");

        builder.Property(x => x.LastName)
        .HasColumnName("last_name");

        builder.Property(x => x.LoginId)
        .HasColumnName("login_id");
    }
}
