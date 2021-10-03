using Rs.Nets.Std.Clients.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rs.Nets.Blazor.Clients.Models
{
    public class Address : IAddress
    {
        public Guid AddressId { get; set; } = Guid.NewGuid();

        [Required]
        public string AddressLine1 { get ; set ; }
        public string AddressLine2 { get ; set ; }
        public string AddressLine3 { get ; set ; }

        [Required]
        public string Suburb { get ; set ; }

        [Required]
        public string State { get ; set ; }

        [Required]
        public int PostCode { get ; set ; }
    }
}
