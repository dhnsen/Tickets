using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        [Required]
        public string RequestorId { get; internal set; }

        public ApplicationUser Customer { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(255)]
        public string Summary { get; set; }

        public ApplicationUser AssignedUser { get; set; }

        public string TicketType { get; set; }
        
    }
}