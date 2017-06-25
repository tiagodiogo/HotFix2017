using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace HotFix.Models
{
    public abstract class UserModel
    {

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public enum Roles { USER, COMPANY, MUNICIPAL};

        public Roles Role;

        public AddressModel Address { get; set; }

        public DateTime BirthDate { get; set; }

        public string ProfilePicture { get; set; }

        public UserModel()
        {
            ProfilePicture = "/assets/img/profile-icon.png";
        }

    }
}