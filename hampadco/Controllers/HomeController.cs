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

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ViewModelLayer.Portal;
using DataLayer.Entities.Portal;



namespace hampadco.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

  
        public static string msg;
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
 

        public HomeController(HampadcoContext _db, IWebHostEnvironment env)
        {
            db = _db;
            _env = env;
        }

        public IActionResult Index()
        {
            var quser = db.Tbl_PazirandeUsers.Where(a => a.User_Name == User.Identity.GetId()) .Take(12);

            ViewBag.All = quser;

        //     //
        //    var karbar = db.Tbl_PazirandeUsers.Where(a => a.User_Name == User.Identity.GetId()).Count();
        //    ViewBag.L = karbar;


            //
            var N = db.Tbl_Pazirandes.Where(a => a.Status == "0" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.A = N;

            ///
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "1" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.B = T;

            ///
            ///
            var R = db.Tbl_Pazirandes.Where(a => a.Status == "2" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.C = R;

            ///
            var K = db.Tbl_Pazirandes.Where(a=>a.UserName==User.Identity.GetId()).Count();

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
            var N = db.Tbl_Pazirandes.Where(a => a.Status == "0" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.A = N;

            ///
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "1" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.B = T;

            ///
            ///
            var R = db.Tbl_Pazirandes.Where(a => a.Status == "2" && a.UserName==User.Identity.GetId()).Count();
            ViewBag.C = R;

            ///
            var K = db.Tbl_Pazirandes.Count( a => a.UserName==User.Identity.GetId());

            ViewBag.koli = K;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult support()
        {
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

        }
        public IActionResult Learn()
        {
            return View();
        }

        public IActionResult Exit()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }


    }
}
