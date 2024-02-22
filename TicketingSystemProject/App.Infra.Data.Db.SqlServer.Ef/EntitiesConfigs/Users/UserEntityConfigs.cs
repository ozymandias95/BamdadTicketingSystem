using App.Domain.Core.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Users;

public class UserEntityConfigs : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("AppUser");
        builder.HasKey(x => x.Id);
        builder.Property(a => a.IsActive).HasColumnType("Bit").HasDefaultValue(1);
       // builder.Property(u => u.RoleId).IsRequired();
        //builder.Property(u => u.BirthDate).HasColumnType("datetime");
      //  builder.HasOne(u=>u.Role).WithMany(r=>r.Users).HasForeignKey(u=>u.RoleId);
    }
}
