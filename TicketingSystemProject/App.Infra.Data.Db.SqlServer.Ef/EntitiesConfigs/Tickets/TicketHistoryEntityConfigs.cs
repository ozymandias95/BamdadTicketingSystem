using App.Domain.Core.Tickets.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Tickets;

public class TicketHistoryEntityConfigs : IEntityTypeConfiguration<TicketHistory>
{
    public void Configure(EntityTypeBuilder<TicketHistory> builder)
    {
        builder.ToTable("TicketHistories");
        builder.HasKey(t => t.Id);
        builder.Property(t=>t.TicketId).IsRequired();  
        builder.Property(t => t.ModifiedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
        //builder.HasOne(t => t.ModifiedBy).WithMany(m=>m.TicketHistories).HasForeignKey(t=>t.UserId);
        builder.HasOne(t => t.Ticket).WithMany(t=>t.TicketHistories).HasForeignKey(t=>t.TicketId);
        builder.HasOne(t => t.Status).WithMany(s => s.TicketsByStatus).HasForeignKey(t => t.StatusId);

    }
}
