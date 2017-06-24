using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class HousingController : Controller
    {
        // GET: Housing
        public ActionResult Index()
        {
            return View();
        }
    }
}