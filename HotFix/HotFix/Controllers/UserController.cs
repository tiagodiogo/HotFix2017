using HotFix.Models;
using HotFix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class UserController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.User = Session["user"];
            if (ViewBag.User == null)
                filterContext.Result = new RedirectResult("/Home");
            base.OnActionExecuting(filterContext);
        }

        public ActionResult Index()
        {
            return View(UserService.GetInstance().GetUser());
        }

        public ActionResult UpdateInfo(UserModel model)
        {
            return View();
        }
    }
}