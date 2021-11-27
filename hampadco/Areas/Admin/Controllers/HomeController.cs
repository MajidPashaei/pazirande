using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Entities.Portal;
using Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;
using faraboom.Models;


namespace Namespace
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        public static string msg;

        public static string ms;

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
        public IActionResult Disapproval(int id)
        {
            ViewBag.Id=id;
            return View();
        }
        public IActionResult ShowDisapproval()
        {
            var R = db.Tbl_Pazirandes.Where(a => a.Status == "2").ToList();
            ViewBag.R = R;
            return View();
        }
        public IActionResult AllPaZirandeh()
        {
            var R = db.Tbl_Pazirandes.ToList();
            ViewBag.R = R;
            return View();
        }
        public IActionResult Confirmed()
        {
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "1").ToList();
            ViewBag.R = T;
            return View();
        }
        // عدم تایید شده ها
        public IActionResult AddDisapproval(Vm_Pazirande v)
        {
            var A = db .Tbl_Pazirandes.Where(a => a.Id == v.Id).SingleOrDefault();
            A.Description = v.Description;
            A.Status = "2";
            db.Tbl_Pazirandes.Update (A);
            db.SaveChanges();
            return View("index");
        }
        //تایید شده ها
        public IActionResult AddConfirmed(int id)
        {
            var q = db.Tbl_Pazirandes.Where(a => a.Id == id).SingleOrDefault();
            q.Status = "1";
            db.Tbl_Pazirandes.Update (q);
            db.SaveChanges();
            ms = "پذیرنده مورد نظر تایید شد";
            return RedirectToAction("index", "home", new { Areas = "Admin" });
        }
        ///ثبت شده های جدید
        public IActionResult NewRegistered()
        {
            ViewBag.All = db.Tbl_Pazirandes.ToList();
            return View();
        }
        ///نمایش کلی و جزئیات ثبت شده های جدید
        public IActionResult DetailsRegistered(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;
            return View();
        }
        public IActionResult AddUser(Vm_User user)
        {
            if (db.Tbl_Users.Any(a => a.NationalCode == user.NationalCode))
            {
                ViewBag.Msg = "کاربر با کد ملی وارد شده موجود میباشد";
                return View();
            }

            if (db.Tbl_Users.Any(a => a.Code == user.Code))
            {
                ViewBag.Msg = "کاربر با کد نمایندگی وارد شده موجود میباشد";
                return View();
            }

            if (db.Tbl_Users.Any(a => a.UserName == user.UserName))
            {
                ViewBag.Msg = "کاربر با نام کاربری  وارد شده موجود میباشد";
                return View();
            }
            Tbl_User users =
                new Tbl_User()
                {
                    Name = user.Name,
                    Family = user.Family,
                    Phone = user.Phone,
                    NationalCode = user.NationalCode,
                    Code = user.Code,
                    Role = user.Role,
                    Status = true,
                    UserName = user.UserName,
                    Password = user.Password
                };
            db.Tbl_Users.Add (users);
            db.SaveChanges();
            ViewBag.Msg = "کاربر با کد ملی وارد شده با موفقیت ثبت شد";
            return View();
        }
        public IActionResult AllUser()
        {
            ViewBag.All = db.Tbl_Users.ToList();
            return View();
        }
        public IActionResult Accounts()
        {
            ViewBag.All = db.Tbl_PazirandeUsers.ToList();
            return View();
        }

        public IActionResult UserOff(int id)
        {
            var s = db.Tbl_Users.Where(a => a.Id == id).SingleOrDefault();
            s.Status = false;
            db.Tbl_Users.Update (s);
            db.SaveChanges();
            return RedirectToAction("AllUser");
        }
        public IActionResult UserOn(int id)
        {
            var s = db.Tbl_Users.Where(a => a.Id == id).SingleOrDefault();
            s.Status = true;
            db.Tbl_Users.Update (s);
            db.SaveChanges();
            return RedirectToAction("AllUser");
        }
        public IActionResult EditUser()
        {
            return View();
        }
        public IActionResult GoToEdit(Vm_User user)
        {
            var s =
                db.Tbl_Users.Where(a => a.Code == user.Code).SingleOrDefault();
            if (s != null)
            {
                Vm_User vm_User = new Vm_User();
                vm_User.Id = s.Id;
                vm_User.Name = s.Name;
                vm_User.Family = s.Family;
                vm_User.Phone = s.Phone;
                vm_User.NationalCode = s.NationalCode;
                vm_User.Code = s.Code;
                vm_User.Role = s.Role;
                vm_User.UserName = s.UserName;
                vm_User.Password = s.Password;
                return View(vm_User);
            }
            else
            {
                ViewBag.msg = "کاربر با مشخصات وارد شده یافت نشد";
                return View();
            }
        }

        public IActionResult EditUsers(Vm_User b)
        {
            if (db.Tbl_Users.Any(a => a.Code == b.Code))
            {
                ViewBag.Msg = "کاربر با کد نمایندگی وارد شده موجود میباشد";
                return View();
            }
            var user = db.Tbl_Users.Where(a => a.Id == b.Id).SingleOrDefault();
            user.Name = b.Name;
            user.Family = b.Family;
            user.Phone = b.Phone;
            user.NationalCode = b.NationalCode;
            user.Code = b.Code;
            user.Role = b.Role;
            user.Status = true;
            user.UserName = b.UserName;
            user.Password = b.Password;
            db.Tbl_Users.Update (user);
            db.SaveChanges();
            ViewBag.Msg = "کاربر با کد ملی وارد شده با موفقیت ویرایش شد";
            return View();
        }
        
        public IActionResult EditAccount()
        {

            return View();
        }
        public IActionResult GoToEditAccount(Vm_PazirandeUser l)
        {
            var c=db.Tbl_PazirandeUsers.Where(a=>a.National_Code==l.National_Code).SingleOrDefault();
            if (c != null)
            {
                
           
            if (c.Customer_Type=="حقیقی" && c.Customer_National=="ایرانی")
            {
                return RedirectToAction("EditIraniHagigi", new{Id=c.National_Code});
            }
            if (c.Customer_Type=="حقوقی" && c.Customer_National=="ایرانی")
            {
                return RedirectToAction("EditIraniHogogi", new{Id=c.National_Code});
            }
            if (c.Customer_Type=="حقیقی" && c.Customer_National=="غیر ایرانی")
            {
                return RedirectToAction("EditAtbaHagigi", new{Id=c.National_Code});
            }
            if (c.Customer_Type=="حقوقی" && c.Customer_National=="غیر ایرانی")
            {
                return RedirectToAction("EditAtbaHogogi", new{Id=c.National_Code});
            } 

            }
            return View();
        }
        public IActionResult EditIraniHogogi(string Id)
        {
            var c=db.Tbl_PazirandeUsers.Where(a=>a.National_Code==Id).SingleOrDefault();
            Vm_PazirandeUser f=new Vm_PazirandeUser();
            f.CompanyName_fa=c.CompanyName_fa;
            f.CompanyName_en=c.CompanyName_en;
            f.Brand_Name=c.Brand_Name;
            f.establishing_date=c.Establishing_Date.ToPersianDateString();
            f.Company_Id=c.Company_Id;
            f.Economic_Code=c.Economic_Code;
            f.Phone=c.Phone;
            f.Post=c.Post;
            f.Name_fa=c.Name_fa;
            f.Family_fa=c.Family_fa;
            f.FatherName_fa=c.FatherName_fa;
            f.Certificate_Code=c.Certificate_Code;
            f.National_Code=c.National_Code;
            f.birthday=c.BirthDay.ToPersianDateString();
            f.Gender=c.Gender;
            f.Phone_Code=c.Phone_Code;
            f.Mobile=c.Mobile;
            f.State=c.State;
            f.City=c.City;
            f.Name_en=c.Name_en;
            f.Family_en=c.Family_en;
            f.FatherName_en=c.FatherName_en;
            f.Company_Registration=c.Company_Registration;
            
            return View(f);
        }

        public IActionResult EditIraniHagigi(string Id)
        {
            var c=db.Tbl_PazirandeUsers.Where(a=>a.National_Code==Id).SingleOrDefault();

            Vm_PazirandeUser f=new Vm_PazirandeUser();
            f.Id=c.Id;
            f.Customer_Type=c.Customer_Type;
            f.Customer_National=c.Customer_National;
            f.Name_fa=c.Name_fa;
            f.Family_fa=c.Family_fa;
            f.FatherName_fa=c.FatherName_fa;
            f.Certificate_Code=c.Certificate_Code;
            f.Certificate_NumSerial=c.Certificate_NumSerial;
            f.Certificate_Letters=c.Certificate_Letters;
            f.Certificate_Serial=c.Certificate_Serial;
            f.National_Code=c.National_Code;
            f.Education=c.Education;
            f.Birth_Place=c.Birth_Place;
            f.birthday=c.BirthDay.ToPersianDateString();
            f.Gender=c.Gender;
            f.Phone_Code=c.Phone_Code;
            f.Phone=c.Phone;
            f.Mobile=c.Mobile;
            f.Email=c.Email;
            f.State=c.State;
            f.City=c.City;
            f.Post=c.Post;
            f.Address=c.Address;
            f.Name_en=c.Name_en;
            f.Family_en=c.Family_en;
            f.FatherName_en=c.Family_en;

            return View(f);
        }
        public IActionResult UpdateAccount(Vm_PazirandeUser vpu)
        {
            var tpu=db.Tbl_PazirandeUsers.Where(a=>a.Id==vpu.Id).SingleOrDefault();
                    tpu.Customer_Number = vpu.Customer_Number ;
                    tpu.Customer_Group = vpu.Customer_Group ;
                    tpu.Customer_Type = vpu.Customer_Type;
                    tpu.Customer_National = vpu.Customer_National;
                    tpu.Name_fa = vpu.Name_fa ;
                    tpu.Name_en = vpu.Name_en ;
                    tpu.Family_fa = vpu.Family_fa ;
                    tpu.Family_en = vpu.Family_en ;
                    tpu.FatherName_fa = vpu.FatherName_fa ;
                    tpu.FatherName_en = vpu.FatherName_en ;
                    tpu.Gender = vpu.Gender ;
                    tpu.National_Code = vpu.National_Code ;
                    tpu.Certificate_Code = vpu.Certificate_Code ;
                    tpu.Certificate_Serial = vpu.Certificate_Serial ;
                    tpu.Certificate_NumSerial = vpu.Certificate_NumSerial ;
                    tpu.Certificate_Letters = vpu.Certificate_Letters ;
                    tpu.Education = vpu.Education ;
                    tpu.Address = vpu.Address ;
                    tpu.Birth_Place = vpu.Birth_Place ;
                    tpu.Email = vpu.Email ;
                    tpu.BirthDay = vpu.birthday.ToGeorgianDateTime() ;
                    tpu.Mobile = vpu.Mobile ;
                    tpu.Phone = vpu.Phone ;
                    tpu.Phone_Code = vpu.Phone_Code ;
                    tpu.State = vpu.State ;
                    tpu.City = vpu.City ;
                    tpu.Post = vpu.Post ;
                    tpu.Company_Id = vpu.Company_Id ;
                    if (vpu.establishing_date != null)
                    {
                        tpu.Establishing_Date = vpu.establishing_date.ToGeorgianDateTime() ;
                    }
                    tpu.CompanyName_fa = vpu.CompanyName_fa ;
                    tpu.CompanyName_en = vpu.CompanyName_en ;
                    tpu.Brand_Name = vpu.Brand_Name ;
                    tpu.Company_Registration = vpu.Company_Registration ;
                    tpu.Economic_Code = vpu.Economic_Code ;
                    tpu.Comprehensive_Code = vpu.Comprehensive_Code ;
                    tpu.Passport_Code = vpu.Passport_Code ;
                    if (vpu.passport_validity != null)
                    {
                        tpu.Passport_Validity = vpu.passport_validity.ToGeorgianDateTime() ;
                    }
                    tpu.Nationality = vpu.Nationality ;
                    db.Tbl_PazirandeUsers.Update(tpu);
                    db.SaveChanges();
                    
                    ViewBag.msg = $" کاربر با کد ملی  { vpu.National_Code }  آپدیت شد . ";
                    
            return View();
        }
        
        
        
        
    }
}
