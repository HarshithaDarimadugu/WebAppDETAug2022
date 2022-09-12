using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filters;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Helo(string name, string Loc, string contact)
        {
            ViewBag.Username = name;
            ViewBag.Location = Loc;
            ViewBag.Contact = contact;
            return View();
        }
        [MyLog]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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