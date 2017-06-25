using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class HousingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public string Image { get; set; }
        public AddressModel Address { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class HousingViewModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }

        //for address information
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}