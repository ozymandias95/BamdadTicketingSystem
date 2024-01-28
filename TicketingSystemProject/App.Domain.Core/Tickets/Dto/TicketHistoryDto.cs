using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;

namespace App.Domain.Core.Tickets.Dto
{
    public class TicketHistoryDto
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int UserId { get; set; }
        public string ModifiedBy { get; set; }
        public int StatusId { get; set; }
        public string StatusTitle { get; set; }
    }
}