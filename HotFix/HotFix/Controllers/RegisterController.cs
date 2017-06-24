using HotFix.Models;
using HotFix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public HttpResponseMessage Register(RegistrationModel model)
        {
            UserService.GetInstance().AddNewUser(model);
            return new HttpResponseMessage(statusCode: System.Net.HttpStatusCode.OK);
        }
    }
}