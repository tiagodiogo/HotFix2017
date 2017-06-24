using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public abstract class UserModel
    {

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string AddressModel { get; set; }

        public DateTime BirthDate { get; set; }


        public abstract bool IsBackEndUser();
    }
}