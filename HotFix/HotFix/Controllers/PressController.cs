using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class PressController : Controller
    {
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