using System.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hampadco.Models;
using Microsoft.AspNetCore.Authorization;

namespace hampadco.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult pazirande()
        {
          return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult support()
        {
          return View();
        }
        public IActionResult Learn()
        {
            return View();
        }
        
        public IActionResult Exit()
        {
            return View();
        } 
    }
}
