using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.EntityMappings;

public class UserGroupMapping : IEntityTypeConfiguration<UserGroup>
{
    public void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        builder.ToTable("user_groups");

        builder.HasOne(x => x.Group)
        .WithMany(x => x.GroupUsers)
        .HasForeignKey(x => x.GroupId);

        builder.HasOne(x => x.User)
        .WithMany(x => x.Groups)
        .HasForeignKey(x => x.UserId);

        builder.HasKey(x => new {
            x.GroupId,
            x.UserId
        });
    }
}
