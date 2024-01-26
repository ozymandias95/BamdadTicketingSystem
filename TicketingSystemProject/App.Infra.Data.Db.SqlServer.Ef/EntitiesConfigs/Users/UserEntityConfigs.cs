using App.Domain.Core.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Users;

public class UserEntityConfigs : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(x => x.Id);
        builder.Property(u => u.RoleId).IsRequired();
        builder.Property(u => u.BirthDate).HasColumnType("datetime");
        builder.HasOne(u=>u.Role).WithMany(r=>r.Users).HasForeignKey(u=>u.RoleId);
    }
}
