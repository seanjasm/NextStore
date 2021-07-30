using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NextStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NextStore.Controllers
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
            ViewData["Envname"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            ViewData["Hostname"] = Environment.MachineName;
            return View();
        }

        public IActionResult HostInfo()
        {
            // platform agnostic call
            //ViewData["Hostname"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
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
