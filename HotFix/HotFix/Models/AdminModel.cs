using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace HotFix.Models
{
    public class AdminModel : UserModel
    {
        public AdminModel(Roles role)
        {
            Role = role;
        }
    }
}