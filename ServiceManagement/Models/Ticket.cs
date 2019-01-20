using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiceManagement.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public ApplicationUser CreatedBy { get; set; }

        public ApplicationUser AssignedAgent { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public bool IsCompleted { get; set; }
    }
}