using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hampadco.Models;
using DataLayer.Entities;
using ViewModelLayer.Portal;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Kavenegar;
using System.IO;
using BotDetect.Web;

namespace hampadco.Controllers
{
    public class loginController : Controller
    {
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
        static string msg ;
        public loginController(HampadcoContext _db, IWebHostEnvironment env) 
        {
            _env = env;
            db = _db;

        }
        public IActionResult Login()
        {
            return View();
        }
        //img captch
        public FileStreamResult GetCaptchaImage()
        {
            int width = 100;
            int height = 50;
            var captchaCode = Models.Captcha.GenerateCaptchaCode();
            var result = Models.Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            string b = HttpContext.Session.GetString("CaptchaCode");
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }
        
        public IActionResult Check(Vm_User u)
        {
            if (Models.Captcha.ValidateCaptchaCode(u.Captcha, HttpContext))
            {
            var quser = db.Tbl_Users.SingleOrDefault( a => a.UserName == u.UserName && a.Password == u.Password );
            if (quser != null)
            {
                if ( quser.Role == "مدیریت" )
                {
                    var claims = new List<Claim>()
                    {
                        new Claim (ClaimTypes.NameIdentifier, quser.UserName.ToString()),
                        new Claim (ClaimTypes.Name, quser.UserName)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties 
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("UserName", quser.UserName);
                    HttpContext.Session.SetString ("Role", quser.Role);

                    return RedirectToAction( "index" , "home" , new { area = "Admin" } );
                }
                else
                {
                    var claims = new List<Claim>()
                    {
                        new Claim (ClaimTypes.NameIdentifier, quser.UserName.ToString()),
                        new Claim (ClaimTypes.Name, quser.UserName)
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties 
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);

                    HttpContext.Session.SetString ("UserName", quser.UserName);
                    HttpContext.Session.SetString ("Role", quser.Role);

                    return RedirectToAction("index","home");
                    
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult ForgetPassword()
        {
            if ( msg != null)
            {
                ViewBag.er = " نام کاربری یا کدملی اشتباه است . ";
                msg = null;
            }

            return View();
        }
        public IActionResult CheekPassword(Vm_User vu)
        {
            if ( msg != null)
            {
                ViewBag.er = " کد بازیابی وارد شده اشتباه است . ";
                msg = null;
            }

            var quser = db.Tbl_Users.SingleOrDefault( a => a.NationalCode == vu.NationalCode && a.UserName == vu.UserName);

            if (quser != null)
            {
                HttpContext.Session.SetString ("NationalCode", quser.NationalCode);

                Random rand = new Random();
                string RandNum = rand.Next(100000, 999999).ToString();

                quser.RCode = RandNum ;
                db.Tbl_Users.Update(quser);
                db.SaveChanges();
                try
                {
                    var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                    api.VerifyLookup(quser.Phone, RandNum, "nikatakjob");
                    
                }
                catch (System.Exception ex)
                {
                    ViewBag.ex=ex;
                }

                return View();
            }
            else
            {
                msg = "Er" ;
                return RedirectToAction( "ForgetPassword");
            }

        }
        public IActionResult CheekRCode(Vm_User vu)
        {
            var quser = db.Tbl_Users.SingleOrDefault( a => a.NationalCode == HttpContext.Session.GetString("NationalCode") && a.RCode == vu.RCode);
            
            if ( quser != null )
            {
                return View();
            }
            else
            {
                msg = "Er" ;   
                return RedirectToAction("CheekPassword");
            }

        }
        public IActionResult SetPass(Vm_User vu)
        {
            var quser = db.Tbl_Users.SingleOrDefault( a => a.NationalCode == HttpContext.Session.GetString("NationalCode"));
            if ( quser != null )
            {
                quser.Password = vu.Password;
                db.Tbl_Users.Update(quser);
                db.SaveChanges();

                ViewBag.Ok = " تغییر رمزعبور با موفقیت انجام شد . " ;
            }
            else
            {
                ViewBag.Er = " خطا در تغییر رمزعبور . " ;
            }

            HttpContext.Session.Remove("NationalCode");

            return View();
        }

        public IActionResult Exit()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        

    }
}


