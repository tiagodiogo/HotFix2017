using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class RefugeeModel : UserModel
    {
        public RefugeeModel()
        {
            Role = Roles.USER;
        }
    }
}