using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PrimaryContact { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PostalCode { get; set; }

        public int Phone1 { get; set; }

        public int Phone2 { get; set; }

        public string Note { get; set; }

        public decimal BillingRate { get; set; }

    }
}