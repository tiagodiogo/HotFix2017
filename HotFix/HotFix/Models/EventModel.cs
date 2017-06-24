using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public AddressModel Address { get; set; }
        public DateTime Time { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class EventViewModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // for the address model
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public DateTime Time { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}