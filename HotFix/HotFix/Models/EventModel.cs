using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class EventModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public AddressModel Address { get; set; }
        public DateTime Time { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}