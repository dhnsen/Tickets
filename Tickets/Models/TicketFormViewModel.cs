using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class TicketFormViewModel
    {

        [Required]
        [StringLength(255)]
        [DisplayName("Summary of the issue")]
        public string Summary { get; set; }

        [Required]
        [DisplayName("Issue Type")]
        public IEnumerable<TicketType> TicketTypes { get; set; }
    }
}