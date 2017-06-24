using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Models
{
    public class AdminModel : UserModel
    {
        public override bool IsBackEndUser()
        {
            return true;
        }
    }
}