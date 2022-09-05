using FirstMVCDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "This is my sample mvc application";

            List<string> colorlist = new List<string>()
            {
                "Red","Green","Blue","White","Black","Purple"
            };
            ViewData["message"] = "This is my first MVC page";
            ViewData["Experience"] = "I have 2 years of experience";
            ViewData["Year"] = 2022;

            ViewData["list"] = colorlist;

            ViewBag.ColorList = colorlist;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
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
