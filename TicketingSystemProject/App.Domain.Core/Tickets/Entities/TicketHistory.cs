using App.Domain.Core.Users.Entities;

namespace App.Domain.Core.Tickets.Entities;

public class TicketHistory
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int UserId { get; set; }
    public AppUser ModifiedBy { get; set; }
    public int StatusId { get; set; }
    public AttributeDetail Status {  get; set; }
    public string Message { get; set; }
}