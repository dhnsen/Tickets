using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagement.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Mailing Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Primary phone")]
        public int Phone { get; set; }

        
        [Display(Name = "Additional phone")]
        public int SecondaryPhone { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Hourly Billing rate")]
        public decimal HourlyBillingRate { get; set; } 


    }
}
