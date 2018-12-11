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
        public ApplicationUser Requestor { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Summary of the issue")]
        public string Summary { get; set; }

        public ApplicationUser AssignedUser { get; set; }

        public TicketType TicketType { get; set; }

    }
}