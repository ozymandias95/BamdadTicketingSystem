using App.Domain.Core.Tickets.Entities;

namespace App.Domain.Core.Users.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; }
    public virtual List<Ticket>? Tickets { get; set; }
    public virtual List<TicketHistory>? TicketHistories { get; set; }

}