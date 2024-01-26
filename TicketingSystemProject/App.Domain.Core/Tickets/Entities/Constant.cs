namespace App.Domain.Core.Tickets.Entities;

public class Constant
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public List<TicketHistory>? TicketsByStatus { get; set; }
    public List<Ticket>? TicketsByCategory { get; set; }
    public List<Ticket>? TicketsByPriority { get; set; }

}
