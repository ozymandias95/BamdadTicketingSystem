using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace App.Infra.Data.Db.SqlServer.Ef.DbCtx;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Constant> Constants { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketHistory> ticketHistories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        //var assembly = typeof(PtoductCategoryMapping).Assembly;
        //modelBuilder.ApplyConfigurationsFromAssembly(assembly);

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}
