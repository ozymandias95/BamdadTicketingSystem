using App.Domain.Core.Tickets.Dto;

namespace App.Domain.Core.Tickets.Entities;

public class TicketStatusDto
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public List<TicketHistoryDto>? TicketHistoriesByStatus { get; set; }

}
