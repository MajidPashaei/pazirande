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
<<<<<<< HEAD
  
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ViewModelLayer.Portal;
using DataLayer.Entities.Portal;
<<<<<<< HEAD
using faraboom.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
 
=======



>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e


namespace hampadco.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
<<<<<<< HEAD
  
        public static string msg;
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
 
     
=======
        public static string msg;
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e


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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult support()
        {
<<<<<<< HEAD
  
            
=======

>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
         ViewBag.All=db.Tbl_Supports.Where(a=>a.User==User.Identity.GetId()).ToList();
          return View();
        }
        public IActionResult SetSupport(VM_Support s)
        {
            var i=db.Tbl_Users.SingleOrDefault(a=>a.UserName==User.Identity.GetId());
            Tbl_Support f=new Tbl_Support();
            f.User=User.Identity.GetId();
            f.Title=s.Title;
            f.Description=s.Description;
            f.To=s.To;
            f.Phone=i.Phone;
            db.Tbl_Supports.Add(f);
            db.SaveChanges();
            ViewBag.msg="تیکت با موفقیت ثبت شد";
            return View();
        
<<<<<<< HEAD
 
=======
        }
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e

        public IActionResult Learn()
        {
            return View();
        }

        public IActionResult Exit()
        {
<<<<<<< HEAD
  
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
=======
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        } 
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e

    }
}
