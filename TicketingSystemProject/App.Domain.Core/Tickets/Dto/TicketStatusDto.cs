namespace App.Domain.Core.Tickets.Dto;

public class TicketStatusDto
{
    public int Id { get; set; }
    public int AttibuteId { get; set; } 
    public string Title { get; set; }
    public List<TicketHistoryDto>? TicketHistoriesByStatus { get; set; }

}
