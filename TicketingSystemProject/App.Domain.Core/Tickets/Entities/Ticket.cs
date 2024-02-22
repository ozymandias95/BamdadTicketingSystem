using App.Domain.Core.Users.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Tickets.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public DateTime SubmitAt { get; set; }
    public int UserId { get; set; }
    public AppUser SubmitBy { get; set; }
    public int CategoyId { get; set; }
    public virtual AttributeDetail Category { get; set; }
    public int PriorityId { get; set; }
    public virtual AttributeDetail Priority { get; set; }
    public List<TicketHistory>? TicketHistories { get; set; }
}