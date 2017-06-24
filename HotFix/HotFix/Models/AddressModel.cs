using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class AddressModel
    {
        public string Street { get; set; }
        //public string County { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}