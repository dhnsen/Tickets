using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public interface TicketType
    {
        TicketCategory Category { get; set; }
    }
}
