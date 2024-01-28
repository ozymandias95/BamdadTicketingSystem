using App.Domain.Core.Tickets.Dto;
using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Users.Dto
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int RoleId { get; set; }
        public string Role { get; set; }
        public virtual List<TicketDto>? Tickets { get; set; }
        public virtual List<TicketHistoryDto>? TicketHistories { get; set; }
    }
}
