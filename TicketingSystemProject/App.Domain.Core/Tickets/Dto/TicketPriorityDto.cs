namespace App.Domain.Core.Tickets.Dto;

public class TicketPriorityDto
{
    public int Id { get; set; }
    public int AttibuteId { get; set; }
    public string Title { get; set; }
    public List<TicketDto>? TicketsByPriority { get; set; }
}
