using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string email { get; set; }

        public decimal HourlyBillingRate { get; set; } 


    }
}
