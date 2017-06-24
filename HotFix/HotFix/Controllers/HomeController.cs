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
    public class HomeController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.User = Session["user"];

            base.OnActionExecuting(filterContext);

        }

        public ActionResult Index()
        {
            ViewBag.Title = "Welcome";
            return View();
        }



        [HttpPost]
        public HttpResponseMessage Login(LoginModel model)
        {
            if (UserService.GetInstance().LoginUser(model))
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
            {
                Content = new StringContent("Invalid credentials")
            };
        }

    }
}