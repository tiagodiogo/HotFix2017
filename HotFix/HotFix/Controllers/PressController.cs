﻿using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class PressController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.User = Session["user"];
//            if (ViewBag.User == null)
//              filterContext.Result = new RedirectResult("/Home");
            base.OnActionExecuting(filterContext);
        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddArticle(ArticleModel model)
        {
            return View();
        }
    }
}