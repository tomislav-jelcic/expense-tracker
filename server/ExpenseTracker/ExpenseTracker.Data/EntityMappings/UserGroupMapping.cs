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
        .WithMany(x => x.GroupUsers);

        builder.HasOne(x => x.User)
        .WithMany(x => x.Groups);

        builder.HasKey(x => new
        {
            x.GroupId,
            x.UserId
        });
    }
}
