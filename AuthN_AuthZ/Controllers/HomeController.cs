using AuthN_AuthZ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthN_AuthZ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Task()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            ViewBag.usr = "User";
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