using System;

namespace ServiceManagement.Models
{
    public class Work
    {
        public int Id { get; set; }

        public ApplicationUser Agent { get; set; }

        public Ticket Ticket { get; set; }
        
        // note: use http://bootstrapformhelpers.com/timepicker/ on view
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Note { get; set; }

        public bool IsInvoiced { get; set; }
    }
}