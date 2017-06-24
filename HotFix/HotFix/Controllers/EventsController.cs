using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotFix.Models;
using HotFix.Services;

namespace HotFix.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index()
        {
            var events = EventsService.GetInstance().GetEvents();
            return View(events);
        }

        public ActionResult Details(int id)
        {
            var model = EventsService.GetInstance().GetEvent(id);
            if (model == null)
                return RedirectToAction("Index");
            return View("Details", model);
        }

        public ActionResult Create() 
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult AddEvent(EventViewModel model)
        {
            var user = UserService.GetInstance().GetUser();
            model.CreatedBy = user;
            model.CreatedAt = DateTime.Now;
            model.Time = DateTime.Now;

            EventsService.GetInstance().CreateEvent(model);

            return RedirectToAction("Index");
        }
    }
}