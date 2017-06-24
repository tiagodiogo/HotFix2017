using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class WorkModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string JobDescription { get; set; }
        public string Picture { get; set; }
        public AddressModel Address { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class WorkViewModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string JobDescription { get; set; }
        public string Picture { get; set; }
    }


}