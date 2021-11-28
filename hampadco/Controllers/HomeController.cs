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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ViewModelLayer.Portal;
using DataLayer.Entities.Portal;
using faraboom.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

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
