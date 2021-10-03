using System;
using System.Collections.Generic;
using System.Text;

namespace Rs.Nets.Std.Clients.Domain
{
    public interface IClient
    {
        Guid ClientId { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }
        IAddress Address { get; set; }

    }
}
