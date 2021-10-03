using Rs.Nets.Std.Clients.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rs.Nets.Blazor.Clients.Models
{
    public class Client : IClient
    {
        public Client()
        {
            Address = new Address();
        }
        public Guid ClientId { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Description ="First Name")]
        public string FirstName { get ; set ; }
        public string MiddleName { get ; set ; }

        [Required]
        [Display(Description = "Last Name")]
        public string LastName { get ; set ; }

        [Required]
        [Display(Description = "contact number")]
        public string PhoneNumber { get ; set ; }

        [Required]
        [Display(Description = "Email Address")]
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        public string EmailAddress { get ; set ; }
        public IAddress Address { get ; set ; }
    }
}
