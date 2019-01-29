using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiceManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PrimaryContact { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string PostalCode { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        [Required]
        public string Email { get; set; }

        public string Note { get; set; }

        [Required]
        public decimal BillingRate { get; set; }

    }
}