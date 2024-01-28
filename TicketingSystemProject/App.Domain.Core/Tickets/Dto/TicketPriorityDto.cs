﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Dto
{
    public class TicketPriorityDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TicketDto>? TicketsByPriority { get; set; }
    }
}
