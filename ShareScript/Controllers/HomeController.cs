using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShareScript.Models;
using ShareScript.TagHelpers;

namespace ShareScript.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<CalendarEvent> events = new List<CalendarEvent>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime currentTime = DateTime.Today;
            ViewBag.Month = currentTime.Month;
            ViewBag.Year = currentTime.Year;
            events.Add(new CalendarEvent("Test Event",currentTime,"info"));
            ViewBag.CalendarEvents = events;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Inbox()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
