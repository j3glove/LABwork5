using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private static readonly AirplaneOwner[] date = new AirplaneOwner[10];

        private static int LastID = 0;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(date.Take(LastID).ToArray());
        }
        [HttpPost]
        public IActionResult AddAirplaneOwner([FromForm]AirplaneOwner model)
        {
            if (ModelState.IsValid)
            {
                date[LastID] = model;
                LastID += 1;
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult AddAirplaneOwner()
        {
            return View();
        }
        public IActionResult EditAirplaneOwner([FromRoute] int id)
        {
            return View(date[id]);
        }

        [HttpPost]
        public IActionResult EditAirplaneOwner([FromForm] AirplaneOwner model, [FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                date[id] = model;
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult GetAirplaneOwner([FromRoute] int id)
        {
            return View(date[id]);
        }
    }
}
