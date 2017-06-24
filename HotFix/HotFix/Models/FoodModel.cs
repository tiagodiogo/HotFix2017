using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class FoodModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public AddressModel Address { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class FoodViewModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }

        //for address information
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}