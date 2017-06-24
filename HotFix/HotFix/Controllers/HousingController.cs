using HotFix.Models;
using HotFix.Services;
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
            var houses = HousingService.GetInstance().GetHouses();
            return View(houses);
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult AddHouse(HousingViewModel model)
        {
            var user = UserService.GetInstance().GetUser();
            model.CreatedAt = DateTime.Now;
            model.CreatedBy = user;

            HousingService.GetInstance().CreateHouse(model);

            return RedirectToAction("Index");
        }

        public ActionResult AddHousing(HousingModel model) {
            return View();

        }
    }
}