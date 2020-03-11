using Microsoft.AspNetCore.Mvc;
using Packer.Models;
using System.Collections.Generic;

namespace Packer.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/lists")]
        public ActionResult Index()
        {
            List<Tracker> allTrackers = Tracker.GetAll();
            return View(allTrackers);
        }

        [HttpGet("/lists/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/lists")]
        public ActionResult Create(string tripType, string gear, string destination, string directions)
        {
            Tracker myTracker = new Tracker(tripType, gear, destination, directions);
            return RedirectToAction("Index");
        }

        [HttpPost("/lists/delete")]
        public ActionResult DeleteAll()
        {
            Tracker.ClearAll();
            return View();
        }

        [HttpGet("/lists/{id}")]
        public ActionResult Show(int id)
        {
            Tracker foundTracker = Tracker.Find(id);
            return View(foundTracker);
        }
    }
}