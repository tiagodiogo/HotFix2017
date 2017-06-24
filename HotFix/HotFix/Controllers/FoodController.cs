﻿using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotFix.Services;

namespace HotFix.Controllers
{
    public class FoodController : Controller
    {
        
        public ActionResult Index()
        {
            var model = FoodService.GetInstance().GetRest();
            return View(model);
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult AddFood(FoodViewModel model)
        {
            var user = UserService.GetInstance().GetUser();
            model.CreatedAt = DateTime.Now;
            model.CreatedBy = user;

            FoodService.GetInstance().CreateRest(model);

            return RedirectToAction("Index");
        }
    }
}