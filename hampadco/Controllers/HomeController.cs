using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using faraboom.Models;
using hampadco.Models;

namespace hampadco.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public readonly HampadcoContext db;

        public readonly IWebHostEnvironment _env;

        public HomeController(HampadcoContext _db, IWebHostEnvironment env)
        {
            db = _db;
            _env = env;
        }

        public IActionResult Index()
        {
            var quser =
                db
                    .Tbl_PazirandeUsers
                    .Where(a => a.User_Name == User.Identity.GetId())
                    .Take(12);

            ViewBag.All = quser;

        //     //
        //    var karbar = db.Tbl_PazirandeUsers.Where(a => a.User_Name == User.Identity.GetId()).Count();
        //    ViewBag.L = karbar;


            //
            var N = db.Tbl_Pazirandes.Where(a => a.Status == "0").Count();
            ViewBag.A = N;

            ///
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "1").Count();
            ViewBag.B = T;

            ///
            ///
            var R = db.Tbl_Pazirandes.Where(a => a.Status == "2").Count();
            ViewBag.C = R;

            ///
            var K = db.Tbl_Pazirandes.Count();

            ViewBag.koli = K;

            return View();
        }

        public IActionResult ViewDetails()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult ViewDetailsRad()
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
