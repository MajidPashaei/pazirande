using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Context;
using DataLayer.Entities.Portal;
using ViewModelLayer.Portal;
using faraboom.Models;
using Extensions;

namespace Namespace
{
    public class AccountController : Controller
    {
        public static string msg;
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
        public AccountController(HampadcoContext _db, IWebHostEnvironment env)
        {
            db = _db;
            _env = env;
        }
        public IActionResult Account()
        {
            var quser = db.Tbl_PazirandeUsers.Where(a => a.User_Name == User.Identity.GetId()).ToList();
            ViewBag.All = quser;
            
            return View();
        }
        public IActionResult NewAccount()
        { 
            return View();
        }
        public IActionResult SearchToEdit()
        {
          return View();
        }
        public IActionResult Irani_hogogi()
        {
          return View();
        }
        public IActionResult Irani_hagigi()
        {
          return View();
        }
        public IActionResult Khareji_hogogi()
        {
          return View();
        }
        public IActionResult Khareji_hagigi()
        {
          return View();
        }

        // ///////////////////////////////////////////////////////
        public async Task<IActionResult> SetUser(Vm_PazirandeUser vpu)
        {
            if ( db.Tbl_PazirandeUsers.Any( a => a.National_Code == vpu.National_Code ) )
            {
                ViewBag.msg = $" این کاربر با کد ملی { vpu.National_Code } قبلا ثبت شده است . ";
            }
            else
            {
                try
                {
                    Tbl_PazirandeUser tpu = new Tbl_PazirandeUser();

                    tpu.User_Name = User.Identity.GetId() ;
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
                    if (vpu.birthday != null)
                    {
                        tpu.BirthDay = vpu.birthday.ToGeorgianDateTime() ;
                    }
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
                    }else{
                       tpu.Establishing_Date =DateTime.Now; 
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
                    }else{
                      tpu.Passport_Validity =DateTime.Now; 
                    }
                    tpu.Nationality = vpu.Nationality ;
                    tpu.Set_Date = DateTime.Now;
                    tpu.Status = "0" ;

                    db.Tbl_PazirandeUsers.Add(tpu);
                    db.SaveChanges();
                    
                    ViewBag.msg = $" کاربر با کد ملی  { vpu.National_Code }  ثبت شد . ";
                }
                catch (System.Exception ex)
                {
                    ViewBag.msg = " خطا در ثبت . " ;
                    ViewBag.msg = ex ;
                }
            }

            return View();
        }
        
        public IActionResult SearchToUpload()
        {
          return View();
        }
        public IActionResult GoToUpload(Vm_PazirandeUser vpu)
        {
            var quser =db.Tbl_PazirandeUsers.SingleOrDefault( a => a.National_Code == vpu.National_Code );
            
            if( quser != null)
            {
                ViewBag.info = db.Tbl_PazirandeUsers.Where( a => a.National_Code == vpu.National_Code ).ToList();
            }
            else
            {
                ViewBag.msg = $" کاربر با کد ملی  { vpu.National_Code }  یافت نشد . ";
            }

            return View();
        }
        public async Task<IActionResult> UploadImg(Vm_PazirandeUser vpu)
        {
            var tpu = db.Tbl_PazirandeUsers.Where( a => a.National_Code == vpu.National_Code ).SingleOrDefault();

            try
            {

                if (vpu.NationalCard_Image1 != null)
                {
                    string FileExtension1 = Path.GetExtension(vpu.NationalCard_Image1.FileName);
                    string NewFileName1 = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                    var path1 = $"{_env.WebRootPath}\\fileupload\\{NewFileName1}";
                    using (var stream = new FileStream(path1, FileMode.Create))
                    {
                        await vpu.NationalCard_Image1.CopyToAsync(stream);
                    }
                    tpu.nationalcard_image1 = NewFileName1;
                }

                if (vpu.NationalCard_Image2 != null)
                {
                    string FileExtension2 = Path.GetExtension(vpu.NationalCard_Image2.FileName);
                    string NewFileName2 = String.Concat(Guid.NewGuid().ToString(), FileExtension2);
                    var path2 = $"{_env.WebRootPath}\\fileupload\\{NewFileName2}";
                    using (var stream = new FileStream(path2, FileMode.Create))
                    {
                        await vpu.NationalCard_Image2.CopyToAsync(stream);
                    }
                    tpu.nationalcard_image2 = NewFileName2;
                }

                if (vpu.Certificate_Image != null)
                {
                    string FileExtension3 = Path.GetExtension(vpu.Certificate_Image.FileName);
                    string NewFileName3 = String.Concat(Guid.NewGuid().ToString(), FileExtension3);
                    var path3 = $"{_env.WebRootPath}\\fileupload\\{NewFileName3}";
                    using (var stream = new FileStream(path3, FileMode.Create))
                    {
                        await vpu.Certificate_Image.CopyToAsync(stream);
                    }
                    tpu.certificate_image = NewFileName3;
                }

                if (vpu.Newspaper_Image != null)
                {
                    string FileExtension4 = Path.GetExtension(vpu.Newspaper_Image.FileName);
                    string NewFileName4 = String.Concat(Guid.NewGuid().ToString(), FileExtension4);
                    var path4 = $"{_env.WebRootPath}\\fileupload\\{NewFileName4}";
                    using (var stream = new FileStream(path4, FileMode.Create))
                    {
                        await vpu.Newspaper_Image.CopyToAsync(stream);
                    }
                    tpu.newspaper_image = NewFileName4;
                }

                if (vpu.Statute_Image != null)
                {
                    string FileExtension5 = Path.GetExtension(vpu.Statute_Image.FileName);
                    string NewFileName5 = String.Concat(Guid.NewGuid().ToString(), FileExtension5);
                    var path5 = $"{_env.WebRootPath}\\fileupload\\{NewFileName5}";
                    using (var stream = new FileStream(path5, FileMode.Create))
                    {
                        await vpu.Statute_Image.CopyToAsync(stream);
                    }
                    tpu.statute_image = NewFileName5;
                }

                if (vpu.Establishment_Image != null)
                {
                    string FileExtension6 = Path.GetExtension(vpu.Establishment_Image.FileName);
                    string NewFileName6 = String.Concat(Guid.NewGuid().ToString(), FileExtension6);
                    var path6 = $"{_env.WebRootPath}\\fileupload\\{NewFileName6}";
                    using (var stream = new FileStream(path6, FileMode.Create))
                    {
                        await vpu.Establishment_Image.CopyToAsync(stream);
                    }
                    tpu.establishment_image = NewFileName6;
                }

                if (vpu.Passport_Image != null)
                {
                    string FileExtension7 = Path.GetExtension(vpu.Passport_Image.FileName);
                    string NewFileName7 = String.Concat(Guid.NewGuid().ToString(), FileExtension7);
                    var path7 = $"{_env.WebRootPath}\\fileupload\\{NewFileName7}";
                    using (var stream = new FileStream(path7, FileMode.Create))
                    {
                        await vpu.Passport_Image.CopyToAsync(stream);
                    }
                    tpu.passport_image = NewFileName7;
                }

                if (vpu.ArrangementCard_Image != null)
                {
                    string FileExtension8 = Path.GetExtension(vpu.ArrangementCard_Image.FileName);
                    string NewFileName8 = String.Concat(Guid.NewGuid().ToString(), FileExtension8);
                    var path8 = $"{_env.WebRootPath}\\fileupload\\{NewFileName8}";
                    using (var stream = new FileStream(path8, FileMode.Create))
                    {
                        await vpu.ArrangementCard_Image.CopyToAsync(stream);
                    }
                    tpu.arrangementcard_image = NewFileName8;
                }

                if (vpu.WorkPermit_Image != null)
                {
                    string FileExtension9 = Path.GetExtension(vpu.WorkPermit_Image.FileName);
                    string NewFileName9 = String.Concat(Guid.NewGuid().ToString(), FileExtension9);
                    var path9 = $"{_env.WebRootPath}\\fileupload\\{NewFileName9}";
                    using (var stream = new FileStream(path9, FileMode.Create))
                    {
                        await vpu.WorkPermit_Image.CopyToAsync(stream);
                    }
                    tpu.workpermit_image = NewFileName9;
                }
                 ///
                if (vpu.Esteshhad_Image != null)
                {
                    string FileExtension10 = Path.GetExtension(vpu.Esteshhad_Image.FileName);
                    string NewFileName10 = String.Concat(Guid.NewGuid().ToString(), FileExtension10);
                    var path10 = $"{_env.WebRootPath}\\fileupload\\{NewFileName10}";
                    using (var stream = new FileStream(path10, FileMode.Create))
                    {
                        await vpu.Esteshhad_Image.CopyToAsync(stream);
                    }
                    tpu.Document_Esteshhad = NewFileName10;
                
                }
                ///
                 if (vpu.Garadad_Image != null)
                {
                    string FileExtension11 = Path.GetExtension(vpu.Garadad_Image.FileName);
                    string NewFileName11 = String.Concat(Guid.NewGuid().ToString(), FileExtension11);
                    var path11 = $"{_env.WebRootPath}\\fileupload\\{NewFileName11}";
                    using (var stream = new FileStream(path11, FileMode.Create))
                    {
                        await vpu.Garadad_Image.CopyToAsync(stream);
                    }
                    tpu.Document_Garadad = NewFileName11;
                
                }

                ///
         
                 if (vpu.Masdig_Image != null)
                {
                    string FileExtension12 = Path.GetExtension(vpu.Masdig_Image.FileName);
                    string NewFileName12 = String.Concat(Guid.NewGuid().ToString(), FileExtension12);
                    var path12 = $"{_env.WebRootPath}\\fileupload\\{NewFileName12}";
                    using (var stream = new FileStream(path12, FileMode.Create))
                    {
                        await vpu.Masdig_Image.CopyToAsync(stream);
                    }
                    tpu.Document_Masdig = NewFileName12;
                
                }

                ///
                  if (vpu.Soratjalase_Image != null)
                {
                    string FileExtension13= Path.GetExtension(vpu.Soratjalase_Image.FileName);
                    string NewFileName13 = String.Concat(Guid.NewGuid().ToString(), FileExtension13);
                    var path13 = $"{_env.WebRootPath}\\fileupload\\{NewFileName13}";
                    using (var stream = new FileStream(path13, FileMode.Create))
                    {
                        await vpu.Soratjalase_Image.CopyToAsync(stream);
                    }
                    tpu.Document_Soratjalase = NewFileName13;

                }
                db.Tbl_PazirandeUsers.Update(tpu);
                db.SaveChanges();
                ViewBag.msg = $"مدارک کاربر با کد ملی  { vpu.National_Code }  ثبت شد . ";
            }
            catch (System.Exception ex)
            {
                ViewBag.msg = " خطا در ثبت . ";
                ViewBag.msg = ex;
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditUser( int id )
        {
            var quser = db.Tbl_PazirandeUsers.SingleOrDefault( a => a.Id == id );
            

            Vm_PazirandeUser vp = new Vm_PazirandeUser();

            vp.Id = quser.Id ;
            vp.Name_fa = quser.Name_fa ;
            vp.Name_en = quser.Name_en ;
            vp.Family_fa = quser.Family_fa ;
            vp.Family_en = quser.Family_en ;
            vp.FatherName_fa = quser.FatherName_fa ;
            vp.FatherName_en = quser.FatherName_en ;
            vp.Gender = quser.Gender ;
            vp.National_Code = quser.National_Code ;
            vp.Certificate_Code = quser.Certificate_Code ;
            vp.Certificate_Serial = quser.Certificate_Serial ;
            vp.Certificate_NumSerial = quser.Certificate_NumSerial ;
            vp.Certificate_Letters  = quser.Certificate_Letters  ;
            vp.Education = quser.Education ;
            vp.Address = quser.Address ;
            vp.Birth_Place = quser.Birth_Place ;
            vp.Email = quser.Email ;
            vp.birthday = quser.BirthDay.ToPersianDateString() ;
            vp.Mobile = quser.Mobile ;
            vp.Phone = quser.Phone ;
            vp.Phone_Code = quser.Phone_Code ;
            vp.State = quser.State ;
            vp.City = quser.City ;
            vp.Post = quser.Post ;
            vp.Company_Id = quser.Company_Id ;
            if ( quser.Customer_Type == "حقوقی" )
            {
                vp.establishing_date = quser.Establishing_Date.ToPersianDateString() ;
            }
            vp.CompanyName_fa = quser.CompanyName_fa ;
            vp.CompanyName_en = quser.CompanyName_en ;
            vp.Brand_Name = quser.Brand_Name ;
            vp.Company_Registration = quser.Company_Registration ;
            vp.Economic_Code = quser.Economic_Code ;
            vp.Comprehensive_Code = quser.Comprehensive_Code ;
            vp.Passport_Code = quser.Passport_Code ;
            if ( quser.Customer_National == "غیر ایرانی" )
            {
                vp.passport_validity = quser.Passport_Validity.ToPersianDateString() ;
            }
            vp.Nationality = quser.Nationality ;
            ViewBag.user = db.Tbl_PazirandeUsers.Where( a => a.Id == id ).ToList();

            return View(vp);
        }
        [HttpPost]
        public IActionResult EditUser( Vm_PazirandeUser vpu )
        {
            var quser = db.Tbl_PazirandeUsers.SingleOrDefault( a => a.Id == vpu.Id );

            try
            {
                quser.Name_fa = vpu.Name_fa ;
                quser.Name_en = vpu.Name_en ;
                quser.Family_fa = vpu.Family_fa ;
                quser.Family_en = vpu.Family_en ;
                quser.FatherName_fa = vpu.FatherName_fa ;
                quser.FatherName_en = vpu.FatherName_en ;
                quser.Gender = vpu.Gender ;
                quser.National_Code = vpu.National_Code ;
                quser.Certificate_Code = vpu.Certificate_Code ;
                quser.Certificate_Serial = vpu.Certificate_Serial ;
                quser.Certificate_NumSerial = vpu.Certificate_NumSerial ;
                quser.Certificate_Letters  = vpu.Certificate_Letters  ;
                quser.Education = vpu.Education ;
                quser.Address = vpu.Address ;
                quser.Birth_Place = vpu.Birth_Place ;
                quser.Email = vpu.Email ;
                if ( vpu.BirthDay != null )
                {
                    quser.BirthDay = vpu.birthday.ToGeorgianDateTime() ;
                }
                quser.Mobile = vpu.Mobile ;
                quser.Phone = vpu.Phone ;
                quser.Phone_Code = vpu.Phone_Code ;
                quser.State = vpu.State ;
                quser.City = vpu.City ;
                quser.Post = vpu.Post ;
                quser.Company_Id = vpu.Company_Id ;
                if ( quser.Customer_Type == "حقوقی" )
                {
                    quser.Establishing_Date = vpu.establishing_date.ToGeorgianDateTime() ;
                }
                quser.CompanyName_fa = vpu.CompanyName_fa ;
                quser.CompanyName_en = vpu.CompanyName_en ;
                quser.Brand_Name = vpu.Brand_Name ;
                quser.Company_Registration = vpu.Company_Registration ;
                quser.Economic_Code = vpu.Economic_Code ;
                quser.Comprehensive_Code = vpu.Comprehensive_Code ;
                quser.Passport_Code = vpu.Passport_Code ;
                if ( quser.Customer_National == "غیر ایرانی" )
                {
                    quser.Passport_Validity = vpu.passport_validity.ToGeorgianDateTime() ;
                }
                quser.Nationality = quser.Nationality ;

                db.Tbl_PazirandeUsers.Update(quser);
                db.SaveChanges();
                
                ViewBag.ok = " ویرایش با موفقیت انجام شد . "  ;
            }
            catch (System.Exception ex)
            {
                ViewBag.ex = ex ;
                ViewBag.er = " خطا در ویرایش . " ;
            }

            return View(vpu);
        }
    }
}