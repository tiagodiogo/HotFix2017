using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotFix.Controllers
{
    public class FoodController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddFood(FoodModel model)
        {
            return View();
        }
    }
}