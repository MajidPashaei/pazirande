using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Entities.Portal;
using Extensions;
using Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;
using faraboom.Models;
using ClosedXML.Excel;
using System.IO;

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
         //فراموشی رمز
        [HttpGet]
        public IActionResult Forgotpassword()
        { 
        
            return View();
        }
        [HttpPost]
        public IActionResult Forgotpassword (Vm_User pass)
        {
            var user = db.Tbl_Users.Where(a => a.UserName == User.Identity.GetId()).SingleOrDefault();
            if (user.Password != pass.Code)
            {
                ViewBag.massage = "رمز عبور قبلی نادرست است .";
            }
            else if (pass.Password != pass.RCode)
            {
                ViewBag.massage = "رمز های ورودی جدید مطابقت ندارند .";
            }
            else
            {
                user.Password = pass.Password;
                db.Tbl_Users.Update(user);
                db.SaveChanges();
                
                ViewBag.massage1 = " رمزعبور با موفقیت تغییر یافت .";
            }

            return View();
        }

        public IActionResult Disapproval(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult ViewDetailsRad(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;
            
            var A = db.Tbl_Pazirandes.SingleOrDefault(a => a.Id == id);
            ViewBag.Tarikh_Tavalod = A.Tarikh_Tavalod.ToPersianDateString() ;
            if ( A.Tarikh_Tasis_sherkat != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Tasis_sherkat = A.Tarikh_Tasis_sherkat.ToPersianDateString() ;
            }
            if ( A.Tarikh_Payan_Etebar != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Payan_Etebar = A.Tarikh_Payan_Etebar.ToPersianDateString() ;
            }
            if ( A.Tarikh_Sodor_Javaz != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Sodor_Javaz = A.Tarikh_Sodor_Javaz.ToPersianDateString() ;
            }
            if ( A.Tarikh_Etmam_Ejare != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Etmam_Ejare = A.Tarikh_Etmam_Ejare.ToPersianDateString() ;
            }

            return View();
        }

        public IActionResult ViewDetails(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;
            
            var A = db.Tbl_Pazirandes.SingleOrDefault(a => a.Id == id);
            ViewBag.Tarikh_Tavalod = A.Tarikh_Tavalod.ToPersianDateString() ;
            if ( A.Tarikh_Tasis_sherkat != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Tasis_sherkat = A.Tarikh_Tasis_sherkat.ToPersianDateString() ;
            }
            if ( A.Tarikh_Payan_Etebar != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Payan_Etebar = A.Tarikh_Payan_Etebar.ToPersianDateString() ;
            }
            if ( A.Tarikh_Sodor_Javaz != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Sodor_Javaz = A.Tarikh_Sodor_Javaz.ToPersianDateString() ;
            }
            if ( A.Tarikh_Etmam_Ejare != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Etmam_Ejare = A.Tarikh_Etmam_Ejare.ToPersianDateString() ;
            }

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
            ViewBag.T = T;
            
            return View();
        }

        // عدم تایید شده ها
        public IActionResult AddDisapproval(Vm_Pazirande v)
        {
            var A =
                db.Tbl_Pazirandes.Where(a => a.Id == v.Id).SingleOrDefault();
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
            ms = "ترمینال مورد نظر تایید شد";
            return RedirectToAction("index", "home", new { Areas = "Admin" });
        }

        ///ثبت شده های جدید
        public IActionResult NewRegistered()
        {
            ViewBag.All = db.Tbl_Pazirandes.Where(a=>a.Status=="0").ToList();
            return View();
        }

        ///نمایش کلی و جزئیات ثبت شده های جدید
        public IActionResult DetailsRegistered(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;
            
            var A = db.Tbl_Pazirandes.SingleOrDefault(a => a.Id == id);
            ViewBag.Tarikh_Tavalod = A.Tarikh_Tavalod.ToPersianDateString() ;
            if ( A.Tarikh_Tasis_sherkat != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Tasis_sherkat = A.Tarikh_Tasis_sherkat.ToPersianDateString() ;
            }
            if ( A.Tarikh_Payan_Etebar != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Payan_Etebar = A.Tarikh_Payan_Etebar.ToPersianDateString() ;
            }
            if ( A.Tarikh_Sodor_Javaz != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Sodor_Javaz = A.Tarikh_Sodor_Javaz.ToPersianDateString() ;
            }
            if ( A.Tarikh_Etmam_Ejare != Convert.ToDateTime("0001-01-01 00:00:00.0000000") )
            {
                ViewBag.Tarikh_Etmam_Ejare = A.Tarikh_Etmam_Ejare.ToPersianDateString() ;
            }
            return View();
        }
        [HttpGet]
        public IActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewUser(Vm_User user)
        {
            if (db.Tbl_Users.Any(a => a.NationalCode == user.NationalCode))
            {
                ViewBag.Msg = "پذیرنده با کد ملی وارد شده موجود میباشد";
                return View();
            }

            else if (db.Tbl_Users.Any(a => a.Code == user.Code))
            {
                ViewBag.Msg = "پذیرنده با کد نمایندگی وارد شده موجود میباشد";
                return View();
            }

            else if (db.Tbl_Users.Any(a => a.UserName == user.UserName))
            {
                ViewBag.Msg = "پذیرنده با نام کاربری  وارد شده موجود میباشد";
                return View();
            }

            else if (db.Tbl_Users.Any(a => a.Phone == user.Phone))
            {
                ViewBag.Msg = "پذیرنده با نام کاربری  وارد شده موجود میباشد";
                return View();
            }
            else
            {
                Tbl_User users = new Tbl_User()
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
                db.Tbl_Users.Add(users);
                db.SaveChanges();

                ViewBag.ok = "پذیرنده با کد ملی وارد شده با موفقیت ثبت شد";
            }
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
                ViewBag.msg = "پذیرنده با مشخصات وارد شده یافت نشد";
                return View();
            }
        }

        public IActionResult EditUsers(Vm_User b)
        {
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
            ViewBag.Msg = "پذیرنده با کد ملی وارد شده با موفقیت ویرایش شد";
            return View();
        }

        public IActionResult EditAccount()
        {
            return View();
        }

        public IActionResult GoToEditAccount(string l)
        {
            var c =
                db
                    .Tbl_PazirandeUsers
                    .Where(a => a.National_Code == l)
                    .SingleOrDefault();
            if (c != null)
            {
                if (
                    c.Customer_Type == "حقیقی" &&
                    c.Customer_National == "ایرانی"
                )
                {
                    return RedirectToAction("EditIraniHagigi",
                    new { Id = c.National_Code });
                }
                if (
                    c.Customer_Type == "حقوقی" &&
                    c.Customer_National == "ایرانی"
                )
                {
                    return RedirectToAction("EditIraniHogogi",
                    new { Id = c.National_Code });
                }
                if (
                    c.Customer_Type == "حقیقی" &&
                    c.Customer_National == "غیر ایرانی"
                )
                {
                    return RedirectToAction("EditAtbaHagigi",
                    new { Id = c.National_Code });
                }
                if (
                    c.Customer_Type == "حقوقی" &&
                    c.Customer_National == "غیر ایرانی"
                )
                {
                    return RedirectToAction("EditAtbaHogogi",
                    new { Id = c.National_Code });
                }
            }
            return View();
        }

        public IActionResult EditIraniHogogi(string Id)
        {
            var c =
                db
                    .Tbl_PazirandeUsers
                    .Where(a => a.National_Code == Id)
                    .SingleOrDefault();
            Vm_PazirandeUser f = new Vm_PazirandeUser();
            f.CompanyName_fa = c.CompanyName_fa;
            f.CompanyName_en = c.CompanyName_en;
            f.Brand_Name = c.Brand_Name;
            f.establishing_date = c.Establishing_Date.ToPersianDateString();
            f.Company_Id = c.Company_Id;
            f.Economic_Code = c.Economic_Code;
            f.Phone = c.Phone;
            f.Post = c.Post;
            f.Name_fa = c.Name_fa;
            f.Family_fa = c.Family_fa;
            f.FatherName_fa = c.FatherName_fa;
            f.Certificate_Code = c.Certificate_Code;
            f.National_Code = c.National_Code;
            f.birthday = c.BirthDay.ToPersianDateString();
            f.Gender = c.Gender;
            f.Phone_Code = c.Phone_Code;
            f.Mobile = c.Mobile;
            f.State = c.State;
            f.City = c.City;
            f.Name_en = c.Name_en;
            f.Family_en = c.Family_en;
            f.FatherName_en = c.FatherName_en;
            f.Company_Registration = c.Company_Registration;

            return View(f);
        }

        public IActionResult EditIraniHagigi(string Id)
        {
            var c =
                db
                    .Tbl_PazirandeUsers
                    .Where(a => a.National_Code == Id)
                    .SingleOrDefault();

            Vm_PazirandeUser f = new Vm_PazirandeUser();
            f.Id = c.Id;
            f.Customer_Type = c.Customer_Type;
            f.Customer_National = c.Customer_National;
            f.Name_fa = c.Name_fa;
            f.Family_fa = c.Family_fa;
            f.FatherName_fa = c.FatherName_fa;
            f.Certificate_Code = c.Certificate_Code;
            f.Certificate_NumSerial = c.Certificate_NumSerial;
            f.Certificate_Letters = c.Certificate_Letters;
            f.Certificate_Serial = c.Certificate_Serial;
            f.National_Code = c.National_Code;
            f.Education = c.Education;
            f.Birth_Place = c.Birth_Place;
            f.birthday = c.BirthDay.ToPersianDateString();
            f.Gender = c.Gender;
            f.Phone_Code = c.Phone_Code;
            f.Phone = c.Phone;
            f.Mobile = c.Mobile;
            f.Email = c.Email;
            f.State = c.State;
            f.City = c.City;
            f.Post = c.Post;
            f.Address = c.Address;
            f.Name_en = c.Name_en;
            f.Family_en = c.Family_en;
            f.FatherName_en = c.Family_en;

            return View(f);
        }

        public IActionResult UpdateAccount(Vm_PazirandeUser vpu)
        {
            var tpu =
                db
                    .Tbl_PazirandeUsers
                    .Where(a => a.Id == vpu.Id)
                    .SingleOrDefault();
            tpu.Customer_Number = vpu.Customer_Number;
            tpu.Customer_Group = vpu.Customer_Group;
            tpu.Customer_Type = vpu.Customer_Type;
            tpu.Customer_National = vpu.Customer_National;
            tpu.Name_fa = vpu.Name_fa;
            tpu.Name_en = vpu.Name_en;
            tpu.Family_fa = vpu.Family_fa;
            tpu.Family_en = vpu.Family_en;
            tpu.FatherName_fa = vpu.FatherName_fa;
            tpu.FatherName_en = vpu.FatherName_en;
            tpu.Gender = vpu.Gender;
            tpu.National_Code = vpu.National_Code;
            tpu.Certificate_Code = vpu.Certificate_Code;
            tpu.Certificate_Serial = vpu.Certificate_Serial;
            tpu.Certificate_NumSerial = vpu.Certificate_NumSerial;
            tpu.Certificate_Letters = vpu.Certificate_Letters;
            tpu.Education = vpu.Education;
            tpu.Address = vpu.Address;
            tpu.Birth_Place = vpu.Birth_Place;
            tpu.Email = vpu.Email;
            tpu.BirthDay = vpu.birthday.ToGeorgianDateTime();
            tpu.Mobile = vpu.Mobile;
            tpu.Phone = vpu.Phone;
            tpu.Phone_Code = vpu.Phone_Code;
            tpu.State = vpu.State;
            tpu.City = vpu.City;
            tpu.Post = vpu.Post;
            tpu.Company_Id = vpu.Company_Id;
            if (vpu.establishing_date != null)
            {
                tpu.Establishing_Date =
                    vpu.establishing_date.ToGeorgianDateTime();
            }
            tpu.CompanyName_fa = vpu.CompanyName_fa;
            tpu.CompanyName_en = vpu.CompanyName_en;
            tpu.Brand_Name = vpu.Brand_Name;
            tpu.Company_Registration = vpu.Company_Registration;
            tpu.Economic_Code = vpu.Economic_Code;
            tpu.Comprehensive_Code = vpu.Comprehensive_Code;
            tpu.Passport_Code = vpu.Passport_Code;
            if (vpu.passport_validity != null)
            {
                tpu.Passport_Validity =
                    vpu.passport_validity.ToGeorgianDateTime();
            }
            tpu.Nationality = vpu.Nationality;
            db.Tbl_PazirandeUsers.Update (tpu);
            db.SaveChanges();

            ViewBag.msg = $" پذیرنده با کد ملی  {vpu.National_Code}  آپدیت شد . ";

            return View();
        }

        public IActionResult Excel()
        {
            using (var workbook = new XLWorkbook())
            {
                // ستون ها
                var worksheet = workbook.Worksheets.Add("pepe");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "NameCreateUser";
                worksheet.Cell(currentRow, 3).Value = "Status";
                worksheet.Cell(currentRow, 5).Value = "Description";
                worksheet.Cell(currentRow, 6).Value = "UserName";
                worksheet.Cell(currentRow, 7).Value = "Type_Moshtari";
                worksheet.Cell(currentRow, 8).Value = "Code_Meli";
                worksheet.Cell(currentRow, 9).Value = "Shenase_Meli";
                worksheet.Cell(currentRow, 10).Value = "Shomare_Shenasname";
                worksheet.Cell(currentRow, 11).Value = "Name ";
                worksheet.Cell(currentRow, 12).Value = "Family";
                worksheet.Cell(currentRow, 13).Value = "Tarikh_Tavalod";
                worksheet.Cell(currentRow, 14).Value = "Name_Pedar";
                worksheet.Cell(currentRow, 15).Value = "Jensiat";
                worksheet.Cell(currentRow, 16).Value = "Mobile";
                worksheet.Cell(currentRow, 17).Value = "Address";
                worksheet.Cell(currentRow, 18).Value = "Name_EN";
                worksheet.Cell(currentRow, 19).Value = "Family_EN";
                worksheet.Cell(currentRow, 20).Value = "Pedar_EN";
                worksheet.Cell(currentRow, 21).Value = "Name_Sherkat";
                worksheet.Cell(currentRow, 22).Value = "Tarikh_Tasis_sherkat";
                worksheet.Cell(currentRow, 23).Value = "Name_EN_Sherkat";
                worksheet.Cell(currentRow, 24).Value = "Code_Egtesadi";
                worksheet.Cell(currentRow, 25).Value = " Shomare_Sabt";
                worksheet.Cell(currentRow, 26).Value = " Pazirande_Atba";
                worksheet.Cell(currentRow, 27).Value = " Code_Faragir";
                worksheet.Cell(currentRow, 28).Value = " Code_Gozarname";
                worksheet.Cell(currentRow, 29).Value = " Tarikh_Etbar";
                worksheet.Cell(currentRow, 30).Value = "Melyat";
                worksheet.Cell(currentRow, 31).Value = " Shenase_Onvan_Nemayandegi";
                worksheet.Cell(currentRow, 32).Value = " Shenase_Bazaryab_Nemayandegi";
                worksheet.Cell(currentRow, 33).Value = " Shenase_Porojeh";
                worksheet.Cell(currentRow, 34).Value = "Shenase_Switch";
                worksheet.Cell(currentRow, 35).Value = "Shenase_Type_Dargah ";
                worksheet.Cell(currentRow, 36).Value = "Shenase_Type_Dastgah ";
                worksheet.Cell(currentRow, 37).Value = "Shenase_Model_Dastgah ";
                worksheet.Cell(currentRow, 38).Value = " Shenase_Bank";
                worksheet.Cell(currentRow, 39).Value = " Code_Shobe";
                worksheet.Cell(currentRow, 40).Value = "Shomare_Hesab ";
                worksheet.Cell(currentRow, 41).Value = "Shomare_Sheba ";
                worksheet.Cell(currentRow, 42).Value = " Code_Shaparaki_shahr";
                worksheet.Cell(currentRow, 43).Value = " Mantage_Shahri";
                worksheet.Cell(currentRow, 44).Value = " Code_Posti";
                worksheet.Cell(currentRow, 45).Value = " TelePhone";
                worksheet.Cell(currentRow, 46).Value = "Fax ";
                worksheet.Cell(currentRow, 47).Value = " Code_Takmily_Senf";
                worksheet.Cell(currentRow, 48).Value = "Onvan_Mahal_Kasb ";
                worksheet.Cell(currentRow, 49).Value = "Onvan_Latin_Kasb ";
                worksheet.Cell(currentRow, 50).Value = "Shenase_Malekyat";
                worksheet.Cell(currentRow, 51).Value = "Address_Shaparaki ";
                worksheet.Cell(currentRow, 52).Value = " Address_Latin";
                worksheet.Cell(currentRow, 53).Value = "Shenase_Mahal_kasb ";
                worksheet.Cell(currentRow, 54).Value = " Shomare_Javaz_kasb";
                worksheet.Cell(currentRow, 55).Value = "Marja_Saderkonande_Mojavez ";
                worksheet.Cell(currentRow, 56).Value = " Tarikh_Sodor_Javaz";
                worksheet.Cell(currentRow, 57).Value = "Tarikh_Payan_Etebar ";
                worksheet.Cell(currentRow, 58).Value = "Shomare_Garardad_Ejare ";
                worksheet.Cell(currentRow, 59).Value = "Tarikh_Etmam_Ejare ";
                worksheet.Cell(currentRow, 60).Value = "Code_Rahgiri ";
                worksheet.Cell(currentRow, 61).Value = "Type_Garardad_Hesab ";
                worksheet.Cell(currentRow, 62).Value = " Shenase_Type_Vagozari";
                worksheet.Cell(currentRow, 63).Value = "Type_Vadieh ";
                worksheet.Cell(currentRow, 64).Value = " Shomare_Sanad";
                worksheet.Cell(currentRow, 65).Value = " Mablag_Frosh";
                worksheet.Cell(currentRow, 66).Value = " Moaref";
                worksheet.Cell(currentRow, 67).Value = " Phone_Moaref";
                worksheet.Cell(currentRow, 68).Value = " Tedad_Agsat";
                worksheet.Cell(currentRow, 69).Value = " Mablag_Agsat";
                worksheet.Cell(currentRow, 70).Value = "Mobail_Motasel ";
                worksheet.Cell(currentRow, 71).Value = "Mobaile_Fani_Pos";
                worksheet.Cell(currentRow, 72).Value = " Telephone_Fani_Pos";
                worksheet.Cell(currentRow, 73).Value = " Shomare_Pazirande";
                worksheet.Cell(currentRow, 74).Value = " Shomare_Terminal";
                worksheet.Cell(currentRow, 75).Value = "Serial_Dastgah ";
                worksheet.Cell(currentRow, 76).Value = "Tarikh_Nasb ";
                worksheet.Cell(currentRow, 77).Value = " Shomare_Marja";
                worksheet.Cell(currentRow, 78).Value = "Tarikh_Tarif_Switch ";
                worksheet.Cell(currentRow, 79).Value = "Tarikh_Tarif_Shaparak ";
                worksheet.Cell(currentRow, 80).Value = " Nemad_Elektroniki";
                worksheet.Cell(currentRow, 81).Value = "Tarikh_Etmam_Etebar ";
                worksheet.Cell(currentRow, 82).Value = "Tarikh_Sodor_Nemad ";
                worksheet.Cell(currentRow, 83).Value = "Type_Nemad ";
                worksheet.Cell(currentRow, 84).Value = "Server_Frosh ";
                worksheet.Cell(currentRow, 85).Value = "IPGAccessPort ";
                worksheet.Cell(currentRow, 86).Value = "IPGCallBackAddress ";
                worksheet.Cell(currentRow, 87).Value = " Address_Post_Sherkat";
                worksheet.Cell(currentRow, 88).Value = " Mahsolat_Frosh";
                worksheet.Cell(currentRow, 89).Value = "Address_Post ";
                worksheet.Cell(currentRow, 90).Value = "Family_Masol_Fani";
                worksheet.Cell(currentRow, 91).Value = "Mobail_Masol_Fani";
                worksheet.Cell(currentRow, 92).Value = "Name_Fani_Masol_Fani ";
                worksheet.Cell(currentRow, 93).Value = " Code_Meli_Masol_Fani";
                worksheet.Cell(currentRow, 94).Value = " Address_Site";
                worksheet.Cell(currentRow, 95).Value = "Emkan_Lagv ";
                worksheet.Cell(currentRow, 96).Value = " Zamine_Faliat";
                ///

                var users=db.Tbl_Pazirandes.Where(a=>a.StatusExcel=="0").ToList();
                // تفکیک جدول و پرکردن اطلاعات
                foreach (var user in users)
                {
                    //    اعضای ردیف
                currentRow++;
                worksheet.Cell(currentRow, 1).Value =user.Id;
                worksheet.Cell(currentRow, 2).Value = user.NameCreateUser;
                worksheet.Cell(currentRow, 3).Value =user.Status;
                worksheet.Cell(currentRow,5).Value = user.Description;
                worksheet.Cell(currentRow, 6).Value =user.UserName;
                worksheet.Cell(currentRow, 7).Value =user.Type_Moshtari;
                worksheet.Cell(currentRow, 8).Value =user.Code_Meli;
                worksheet.Cell(currentRow, 9).Value =user.Shenase_Meli;
                worksheet.Cell(currentRow, 10).Value =user.Shomare_Shenasname;
                worksheet.Cell(currentRow, 11).Value =user.Name ;
                worksheet.Cell(currentRow, 12).Value =user.Family;
                worksheet.Cell(currentRow, 13).Value =user.Tarikh_Tavalod;
                worksheet.Cell(currentRow, 14).Value =user.Name_Pedar;
                worksheet.Cell(currentRow, 15).Value =user.Jensiat;
                worksheet.Cell(currentRow, 16).Value =user.Mobile;
                worksheet.Cell(currentRow, 17).Value =user.Address;
                worksheet.Cell(currentRow, 18).Value =user.Name_EN;
                worksheet.Cell(currentRow, 19).Value =user.Family_EN;
                worksheet.Cell(currentRow, 20).Value =user.Pedar_EN;
                worksheet.Cell(currentRow, 21).Value =user.Name_Sherkat;
                worksheet.Cell(currentRow, 22).Value =user.Tarikh_Tasis_sherkat;
                worksheet.Cell(currentRow, 23).Value =user.Name_EN_Sherkat;
                worksheet.Cell(currentRow, 24).Value =user.Code_Egtesadi;
                worksheet.Cell(currentRow, 25).Value =user. Shomare_Sabt;
                worksheet.Cell(currentRow, 26).Value =user. Pazirande_Atba;
                worksheet.Cell(currentRow, 27).Value =user. Code_Faragir;
                worksheet.Cell(currentRow, 28).Value =user. Code_Gozarname;
                worksheet.Cell(currentRow, 29).Value =user. Tarikh_Etbar;
                worksheet.Cell(currentRow, 30).Value =user.Melyat;
                worksheet.Cell(currentRow, 31).Value =user. Shenase_Onvan_Nemayandegi;
                worksheet.Cell(currentRow, 32).Value =user. Shenase_Bazaryab_Nemayandegi;
                worksheet.Cell(currentRow, 33).Value =user. Shenase_Porojeh;
                worksheet.Cell(currentRow, 34).Value =user.Shenase_Switch;
                worksheet.Cell(currentRow, 35).Value =user.Shenase_Type_Dargah ;
                worksheet.Cell(currentRow, 36).Value =user.Shenase_Type_Dastgah ;
                worksheet.Cell(currentRow, 37).Value =user.Shenase_Model_Dastgah ;
                worksheet.Cell(currentRow, 38).Value =user. Shenase_Bank;
                worksheet.Cell(currentRow, 39).Value =user. Code_Shobe;
                worksheet.Cell(currentRow, 40).Value =user.Shomare_Hesab;
                worksheet.Cell(currentRow, 41).Value =user.Shomare_Sheba ;
                worksheet.Cell(currentRow, 42).Value =user. Code_Shaparaki_shahr;
                worksheet.Cell(currentRow, 43).Value =user. Mantage_Shahri;
                worksheet.Cell(currentRow, 44).Value =user. Code_Posti;
                worksheet.Cell(currentRow, 45).Value =user. TelePhone;
                worksheet.Cell(currentRow, 46).Value =user.Fax;
                worksheet.Cell(currentRow, 47).Value =user. Code_Takmily_Senf;
                worksheet.Cell(currentRow, 48).Value =user.Onvan_Mahal_Kasb;
                worksheet.Cell(currentRow, 49).Value =user.Onvan_Latin_Kasb;
                worksheet.Cell(currentRow, 50).Value =user.Shenase_Malekyat;
                worksheet.Cell(currentRow, 51).Value =user.Address_Shaparaki ;
                worksheet.Cell(currentRow, 52).Value =user. Address_Latin;
                worksheet.Cell(currentRow, 53).Value =user.Shenase_Mahal_kasb ;
                worksheet.Cell(currentRow, 54).Value =user. Shomare_Javaz_kasb;
                worksheet.Cell(currentRow, 55).Value =user.Marja_Saderkonande_Mojavez;
                worksheet.Cell(currentRow, 56).Value =user. Tarikh_Sodor_Javaz;
                worksheet.Cell(currentRow, 57).Value =user.Tarikh_Payan_Etebar;
                worksheet.Cell(currentRow, 58).Value =user.Shomare_Garardad_Ejare;
                worksheet.Cell(currentRow, 59).Value =user.Tarikh_Etmam_Ejare;
                worksheet.Cell(currentRow, 60).Value =user.Code_Rahgiri;
                worksheet.Cell(currentRow, 61).Value =user.Type_Garardad_Hesab;
                worksheet.Cell(currentRow, 62).Value =user. Shenase_Type_Vagozari;
                worksheet.Cell(currentRow, 63).Value =user.Type_Vadieh;
                worksheet.Cell(currentRow, 64).Value =user. Shomare_Sanad;
                worksheet.Cell(currentRow, 65).Value =user. Mablag_Frosh;
                worksheet.Cell(currentRow, 66).Value =user. Moaref;
                worksheet.Cell(currentRow, 67).Value =user. Phone_Moaref;
                worksheet.Cell(currentRow, 68).Value =user. Tedad_Agsat;
                worksheet.Cell(currentRow, 69).Value =user. Mablag_Agsat;
                worksheet.Cell(currentRow, 70).Value =user.Mobail_Motasel ;
                worksheet.Cell(currentRow, 71).Value =user.Mobaile_Fani_Pos;
                worksheet.Cell(currentRow, 72).Value =user. Telephone_Fani_Pos;
                worksheet.Cell(currentRow, 73).Value =user. Shomare_Pazirande;
                worksheet.Cell(currentRow, 74).Value =user. Shomare_Terminal;
                worksheet.Cell(currentRow, 75).Value =user.Serial_Dastgah ;
                worksheet.Cell(currentRow, 76).Value =user.Tarikh_Nasb ;
                worksheet.Cell(currentRow, 77).Value =user. Shomare_Marja;
                worksheet.Cell(currentRow, 78).Value =user.Tarikh_Tarif_Switch ;
                worksheet.Cell(currentRow, 79).Value =user.Tarikh_Tarif_Shaparak ;
                worksheet.Cell(currentRow, 80).Value =user. Nemad_Elektroniki;
                worksheet.Cell(currentRow, 81).Value =user.Tarikh_Etmam_Etebar ;
                worksheet.Cell(currentRow, 82).Value =user.Tarikh_Sodor_Nemad ;
                worksheet.Cell(currentRow, 83).Value =user.Type_Nemad ;
                worksheet.Cell(currentRow, 84).Value =user.Server_Frosh ;
                worksheet.Cell(currentRow, 85).Value =user.IPGAccessPort ;
                worksheet.Cell(currentRow, 86).Value =user.IPGCallBackAddress ;
                worksheet.Cell(currentRow, 87).Value =user. Address_Post_Sherkat;
                worksheet.Cell(currentRow, 88).Value =user. Mahsolat_Frosh;
                worksheet.Cell(currentRow, 89).Value =user.Address_Post ;
                worksheet.Cell(currentRow, 90).Value =user.Family_Masol_Fani;
                worksheet.Cell(currentRow, 91).Value =user.Mobail_Masol_Fani;
                worksheet.Cell(currentRow, 92).Value =user.Name_Fani_Masol_Fani ;
                worksheet.Cell(currentRow, 93).Value =user. Code_Meli_Masol_Fani;
                worksheet.Cell(currentRow, 94).Value =user. Address_Site;
                worksheet.Cell(currentRow, 95).Value =user.Emkan_Lagv ;
                worksheet.Cell(currentRow, 96).Value =user. Zamine_Faliat;
                user.StatusExcel="1";
                db.Tbl_Pazirandes.Update(user);
                db.SaveChanges();
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(
                        content,
                        // نام اکسل
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "price.xlsx");

                }
            }
        }

    }
}
