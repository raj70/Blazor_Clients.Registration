using System;
using System.Collections.Generic;
using System.Text;

namespace Rs.Nets.Std.Clients.Domain
{
    public interface IAddress
    {
        Guid AddressId { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string Suburb { get; set; }
        string State { get; set; }
        int PostCode { get; set; }
    }
}
