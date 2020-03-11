using Microsoft.AspNetCore.Mvc;
using Packer.Models;
using System.Collections.Generic;

namespace Packer.Controllers
{
    public class ItemsController : Controllers
    {
        [HttpGet("/list")]
        public ActionResult Index()
        {
            List<Tracker> allTrackers = Tracker.GetAll();
            return View(allTrackers);
        }
    }
}