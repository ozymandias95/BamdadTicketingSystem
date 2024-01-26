using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using App.Domain.Core.Users.Entities;

namespace App.Domain.Core.Tickets.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public DateTime SubmitAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int CategoyId { get; set; }
    public virtual Constant Category { get; set; }
    public int PriorityId { get; set; }
    public virtual Constant Priority { get; set; }
    public List<TicketHistory> TicketHistories { get; set; }
}