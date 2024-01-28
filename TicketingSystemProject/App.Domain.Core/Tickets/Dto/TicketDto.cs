using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Dto;

public class TicketDto
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public DateTime SubmitAt { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public int CategoyId { get; set; }
    public string CategoryTitle { get; set; }
    public int PriorityId { get; set; }
    public string PriorityTitle { get; set; }
    public List<TicketHistoryDto> TicketHistories { get; set; }
}
