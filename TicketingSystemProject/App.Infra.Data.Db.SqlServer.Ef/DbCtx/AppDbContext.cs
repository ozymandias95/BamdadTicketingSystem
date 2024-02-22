using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Xml;
namespace App.Infra.Data.Db.SqlServer.Ef.DbCtx;

public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<AppUser> Users { get; set; }
    //public DbSet<Role> Roles { get; set; }
    public DbSet<TicketAttribute> TicketAttributes { get; set; }
    public DbSet<AttributeDetail> AttributeDetail { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketHistory> ticketHistories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        modelBuilder.Entity<AppUser>()
            .Property<int>("IdentityUserId"); // Shadow property for IdentityUser foreign key

        modelBuilder.Entity<AppUser>()
            .HasOne(typeof(ApplicationUser)) // Define the type indirectly
            .WithMany()
            .HasForeignKey("IdentityUserId");

        //modelBuilder.Entity<IdentityUserRole<int>>()
        //.HasIndex(ur => ur.UserId)
        //.IsUnique();

        modelBuilder.Entity<ApplicationRole>().HasData(
            new ApplicationRole() {Id = 1,Name = "Support",NameFa = "پشتیبان" },
            new ApplicationRole() { Id = 2, Name = "Customer", NameFa = "مشتری" },
            new ApplicationRole() { Id = 3, Name = "Admin", NameFa = "مدیر" });
    }

    //var assembly = typeof(PtoductCategoryMapping).Assembly;
    //modelBuilder.ApplyConfigurationsFromAssembly(assembly);


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}


public class ApplicationRole : IdentityRole<int>
{
    public string NameFa { get; set; }
}

public class ApplicationUser : IdentityUser<int>
{ }