using HotFix.Webservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotFix.Webservices
{
    public class AuthController : ApiController
    {

        public HttpResponseMessage Login(LoginModel model)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
