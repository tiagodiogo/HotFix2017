using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class HousingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddHousing(HousingModel model) {
            return View();

        }
    }
}