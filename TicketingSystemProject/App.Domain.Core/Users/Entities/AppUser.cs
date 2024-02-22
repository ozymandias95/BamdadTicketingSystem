using App.Domain.Core.Tickets.Entities;
namespace App.Domain.Core.Users.Entities;

public class AppUser 
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    public int IdentityUserId { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
    public virtual ICollection<TicketHistory>? TicketHistories { get; set; }
}