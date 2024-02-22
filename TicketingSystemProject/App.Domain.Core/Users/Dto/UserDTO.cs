using App.Domain.Core.Tickets.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Users.Dto
{
    public class UserDTO
    {
        public int? Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [BindNever]
        public string FullName { get; set; }
        [BindNever]
        public bool IsActive { get; set; }
        public int IdentityUserId { get; set; }
        public virtual List<TicketDto>? Tickets { get; set; }
        public virtual List<TicketHistoryDto>? TicketHistories { get; set; }
    }
}
