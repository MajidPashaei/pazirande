using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;
using Microsoft.AspNetCore.Authorization;

namespace Namespace
{
    [Area("Admin")]
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
        public IActionResult NewUser()
        {
          return View();
        }
        public IActionResult AddUser(Vm_User user)
        {

            if (db.Tbl_Users.Any(a=>a.NationalCode==user.NationalCode))
            {
               ViewBag.Msg="کاربر با کد ملی وارد شده موجود میباشد"; 
               return View();
            }

            if (db.Tbl_Users.Any(a=>a.Code==user.Code))
            {
               ViewBag.Msg="کاربر با کد نمایندگی وارد شده موجود میباشد"; 
               return View();
            }

            if (db.Tbl_Users.Any(a=>a.UserName==user.UserName))
            {
               ViewBag.Msg="کاربر با نام کاربری  وارد شده موجود میباشد"; 
               return View();
            }
            Tbl_User users=new Tbl_User()
            {
                Name=user.Name,
                Family=user.Family,
                Phone=user.Phone,
                NationalCode=user.NationalCode,
                Code=user.Code,
                Role=user.Role,
                Status=true,
                UserName =user.UserName,
                Password =user.Password,
            };
            db.Tbl_Users.Add(users);
            db.SaveChanges();
            ViewBag.Msg="کاربر با کد ملی وارد شده با موفقیت ثبت شد"; 
            return View();
        }
        public IActionResult AllUser()
        {
            ViewBag.All=db.Tbl_Users.ToList();
            return View();
        }
        public IActionResult Accounts()
        {
            ViewBag.All=db.Tbl_PazirandeUsers.ToList();
            return View();
        }
        public IActionResult UserOff(int id)
        {
            var s=db.Tbl_Users.Where(a=>a.Id==id).SingleOrDefault();
            s.Status=false;
            db.Tbl_Users.Update(s);
            db.SaveChanges();
          return RedirectToAction("AllUser");
        }
        public IActionResult UserOn(int id)
        {
            var s=db.Tbl_Users.Where(a=>a.Id==id).SingleOrDefault();
            s.Status=true;
            db.Tbl_Users.Update(s);
            db.SaveChanges();
          return RedirectToAction("AllUser");
        }
        public IActionResult EditUser()
        {
          return View();
        }
        public IActionResult GoToEdit(Vm_User user)
        {
            var s=db.Tbl_Users.Where(a=>a.Code==user.Code).SingleOrDefault();
            if (s != null)
            {
                Vm_User vm_User=new Vm_User();
                vm_User.Id=s.Id;
                vm_User.Name=s.Name;
                vm_User.Family=s.Family;
                vm_User.Phone=s.Phone;
                vm_User.NationalCode=s.NationalCode;
                vm_User.Code=s.Code;
                vm_User.Role=s.Role;
                vm_User.UserName=s.UserName;
                vm_User.Password=s.Password;
                return View(vm_User);
            }
            else
            {
                ViewBag.msg="کاربر با مشخصات وارد شده یافت نشد";
                return View();
            }
         
        }
        public IActionResult EditUsers(Vm_User b)
        {

            if (db.Tbl_Users.Any(a=>a.Code==b.Code))
            {
               ViewBag.Msg="کاربر با کد نمایندگی وارد شده موجود میباشد"; 
               return View();
            }
            var user=db.Tbl_Users.Where(a=>a.Id==b.Id).SingleOrDefault();
            user.Name=b.Name;
            user.Family=b.Family;
            user.Phone=b.Phone;
            user.NationalCode=b.NationalCode;
            user.Code=b.Code;
            user.Role=b.Role;
            user.Status=true;
            user.UserName =b.UserName;
            user.Password =b.Password;
            db.Tbl_Users.Update(user);
            db.SaveChanges();
            ViewBag.Msg="کاربر با کد ملی وارد شده با موفقیت ویرایش شد"; 
            return View();
        }
    }
}