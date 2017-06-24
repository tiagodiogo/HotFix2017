using HotFix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class WorkController : Controller
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
            var works = WorkService.GetInstance().GetWorks();
            return View(works);
        }

        public ActionResult Create()
        {
            return View();
        }
        
    }
}