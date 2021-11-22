using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using faraboom.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hampadco.Models;
using DataLayer.Entities;
using ViewModelLayer.Portal;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace hampadco.Controllers
{
    public class loginController : Controller
    {
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
         public loginController(HampadcoContext _db, IWebHostEnvironment env) 
         {
            _env = env;
            db = _db;

         }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Check(Vm_User u)
        {
            var check=db.Tbl_Users.Where(a => a.UserName==u.UserName && a.Password==u.Password).SingleOrDefault();
            if (check != null)
            {
                    var claims = new List<Claim> () {
                    new Claim (ClaimTypes.NameIdentifier, check.UserName.ToString ()),
                    new Claim (ClaimTypes.Name, check.UserName)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };
                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("UserName", check.UserName);
                return RedirectToAction("index","home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult ForgetPassword()
        {
            return RedirectToAction("Login");
        }
        
    }
        }


