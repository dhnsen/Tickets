﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class IssueTicket : TicketType
    {
        public TicketCategory Category { get; set; }
    }
}