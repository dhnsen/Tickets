using ServiceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceManagement.ViewModels
{
    public class TicketFormViewModel
    {
        
        public string Summary { get; set; }

        
        public string Description { get; set; }

        public int Customer { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}