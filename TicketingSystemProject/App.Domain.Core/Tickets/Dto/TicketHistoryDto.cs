namespace App.Domain.Core.Tickets.Dto;

public class TicketHistoryDto
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public string ModifiedAt { get; set; }
    public int UserId { get; set; }
    public string ModifiedBy { get; set; }
    public int StatusId { get; set; }
    public string StatusTitle { get; set; }
    public string Message { get; set; }
}