using App.Domain.Core.Tickets.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Tickets;

public class ConstantEntityConfigs : IEntityTypeConfiguration<Constant>
{
    public void Configure(EntityTypeBuilder<Constant> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(c=>c.Title).HasMaxLength(50);

    }
} 