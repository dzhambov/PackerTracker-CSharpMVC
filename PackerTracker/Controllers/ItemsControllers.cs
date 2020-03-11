using Microsoft.AspNetCore.Mvc;
using Packer.Models;
using System.Collections.Generic;

namespace Packer.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/list")]
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
    }
}