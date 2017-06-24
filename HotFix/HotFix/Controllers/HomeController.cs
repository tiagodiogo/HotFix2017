using HotFix.Models;
using HotFix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome";
            ViewBag.User = null;
            return View();
        }



        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (UserService.GetInstance().LoginUser(model))
                return View();
            return View();
        }

    }
}