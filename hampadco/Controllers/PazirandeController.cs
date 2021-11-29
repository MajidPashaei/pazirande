using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities.Portal;
using Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;
<<<<<<< HEAD

using faraboom.Models;

using System.Globalization;

=======
using faraboom.Models;
using System.Globalization;
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e

namespace Namespace
{
    public class PazirandeController : Controller
    {
        public static string msg;

        public readonly HampadcoContext db;

        public readonly IWebHostEnvironment _env;

        public PazirandeController(HampadcoContext _db, IWebHostEnvironment env)
        {
            db = _db;
            _env = env;
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult ViewDetailsRad(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;

            return View();
        }

        public IActionResult ViewDetails(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;

            return View();
        }

        ///نمایش کلی و جزئیات ثبت شده های جدید
        public IActionResult DetailsRegistered(int id)
        {
            var s = db.Tbl_Pazirandes.Where(a => a.Id == id).ToList();
            ViewBag.Pazirande = s;
            return View();
        }

        public IActionResult All()
        {
            var qp =
                db
                    .Tbl_Pazirandes
                    .Where(a => a.UserName == User.Identity.GetId())
                    .ToList();
            ViewBag.all = qp;
            return View();
        }

        public IActionResult Wait()
        {
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "0").ToList();
            ViewBag.T = T;
            return View();
        }

        public IActionResult No()
        {
            var R = db.Tbl_Pazirandes.Where(a => a.Status == "2").ToList();
            ViewBag.R = R;
            return View();
        }

        public IActionResult Ok()
        {
            var T = db.Tbl_Pazirandes.Where(a => a.Status == "1").ToList();
            ViewBag.T = T;
            return View();
        }
        public IActionResult GoEdit()
        {
            return View();
        }
        

        public IActionResult Edit(Vm_Pazirande pazirande)
        {
            var quser = db.Tbl_Pazirandes.Where(a => a.Code_Meli == pazirande.Code_Meli).SingleOrDefault();
            Vm_Pazirande vp =new Vm_Pazirande();
                    vp.Type_Moshtari = quser.Type_Moshtari;
                    vp.Code_Meli = quser.Code_Meli;
                    vp.Shenase_Meli = quser.Shenase_Meli;
                    vp.Shomare_Shenasname = quser.Shomare_Shenasname;
                    vp.Name = quser.Name;
                    vp.Family = quser.Family;
                    vp.tarikh_tavalod = quser.Tarikh_Tavalod.ToPersianDateString();
                    vp.Name_Pedar = quser.Name_Pedar;
                    vp.Jensiat = quser.Jensiat;
                    vp.Mobile = quser.Mobile;
                    vp.Address = quser.Address;
                    vp.Name_EN = quser.Name_EN;
                    vp.Family_EN = quser.Family_EN;
                    vp.Pedar_EN = quser.Pedar_EN;
                    vp.Name_Sherkat = quser.Name_Sherkat;
                    vp.tarikh_tasis_sherkat =quser.Tarikh_Tasis_sherkat.ToPersianDateString();
                    vp.Name_EN_Sherkat = quser.Name_EN_Sherkat;
                    vp.Code_Egtesadi = quser.Code_Egtesadi;
                    vp.Name_Tejari = quser.Name_Tejari;
                    vp.Shomare_Sabt = quser.Shomare_Sabt;
                    vp.Pazirande_Atba = quser.Pazirande_Atba;
                    vp.Code_Faragir = quser.Code_Faragir;
                    vp.Code_Gozarname = quser.Code_Gozarname;
                    vp.Melyat = quser.Melyat;
                    vp.Code_Posti = quser.Code_Posti;
                    vp.TelePhone = quser.TelePhone;
                    vp.tarikh_etbar = quser.Tarikh_Etbar.ToPersianDateString();
                    vp.Shenase_Onvan_Nemayandegi = quser.Shenase_Onvan_Nemayandegi;
                    vp.Shenase_Bazaryab_Nemayandegi =quser.Shenase_Bazaryab_Nemayandegi;
                    vp.Shenase_Porojeh = quser.Shenase_Porojeh;
                    vp.Shenase_Switch = quser.Shenase_Switch;
                    vp.Shenase_Type_Dargah = quser.Shenase_Type_Dargah;
                    vp.Shenase_Type_Dastgah = quser.Shenase_Type_Dargah;
                    vp.Shenase_Model_Dastgah = quser.Shenase_Model_Dastgah;
                    vp.Shenase_Bank = quser.Shenase_Bank;
                    vp.Code_Shobe = quser.Code_Shobe;
                    vp.Shomare_Hesab = quser.Shomare_Hesab;
                    vp.Shomare_Sheba = quser.Shomare_Sheba;
                    vp.Code_Shaparaki_shahr = quser.Code_Shaparaki_shahr;
                    vp.Mantage_Shahri = quser.Mantage_Shahri;
                    vp.Fax = quser.Fax;
                    vp.Code_Takmily_Senf = quser.Code_Takmily_Senf;
                    vp.Onvan_Mahal_Kasb = quser.Onvan_Mahal_Kasb;
                    vp.Onvan_Latin_Kasb = quser.Onvan_Latin_Kasb;
                    vp.Shenase_Malekyat = quser.Shenase_Malekyat;
                    vp.Address_Shaparaki = quser.Address_Shaparaki;
                    vp.Address_Latin = quser.Address_Latin;
                    vp.Shenase_Mahal_kasb = quser.Shenase_Mahal_kasb;
                    vp.Shomare_Javaz_kasb = quser.Shomare_Javaz_kasb;
                    vp.Marja_Saderkonande_Mojavez =quser.Marja_Saderkonande_Mojavez;
                    vp.Tarikh_Sodor_Javaz =quser.Tarikh_Sodor_Javaz.ToPersianDateString();
                    vp.Tarikh_Payan_Etebar =quser.Tarikh_Payan_Etebar.ToPersianDateString();
                    vp.Shomare_Garardad_Ejare = quser.Shomare_Garardad_Ejare;
                    if (quser.Tarikh_Etmam_Ejare != null)
                    {
                        vp.Tarikh_Etmam_Ejare =quser.Tarikh_Etmam_Ejare.ToPersianDateString();
                    }
                    vp.Code_Rahgiri = quser.Code_Rahgiri;
                    vp.Type_Garardad_Hesab = quser.Type_Garardad_Hesab;
                    vp.Shenase_Type_Vagozari = quser.Shenase_Type_Vagozari;
                    vp.Type_Vadieh = quser.Type_Vadieh;
                    vp.Shomare_Sanad = quser.Shomare_Sanad;
                    vp.Mablag_Frosh = quser.Mablag_Frosh;
                    vp.Moaref = quser.Moaref;

            return View(vp);
        }

        public IActionResult Set_Edit(Vm_Pazirande vp)
        {
            var quser =db.Tbl_Pazirandes.SingleOrDefault(a => a.Code_Meli == vp.Code_Meli);
            if (quser != null)
            {
                    quser.Type_Moshtari = vp.Type_Moshtari;
                    quser.Code_Meli = vp.Code_Meli;
                    quser.Shenase_Meli = vp.Shenase_Meli;
                    quser.Shomare_Shenasname = vp.Shomare_Shenasname;
                    quser.Name = vp.Name;
                    quser.Family = vp.Family;
<<<<<<< HEAD

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    if (vp.tarikh_tavalod != null)
                    {
                        quser.Tarikh_Tavalod = vp.tarikh_tavalod.ToGeorgianDateTime();
                    }
<<<<<<< HEAD
                    quser.Tarikh_Tavalod =
                        vp.tarikh_tavalod.ToGeorgianDateTime();

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    quser.Name_Pedar = vp.Name_Pedar;
                    quser.Jensiat = vp.Jensiat;
                    quser.Mobile = vp.Mobile;
                    quser.Address = vp.Address;
                    quser.Name_EN = vp.Name_EN;
                    quser.Family_EN = vp.Family_EN;
                    quser.Pedar_EN = vp.Pedar_EN;
                    quser.Name_Sherkat = vp.Name_Sherkat;

                    if (vp.tarikh_tasis_sherkat != null)
                    {
                        quser.Tarikh_Tasis_sherkat = vp.tarikh_tasis_sherkat.ToGeorgianDateTime();
                    }

<<<<<<< HEAD
                    quser.Tarikh_Tasis_sherkat =
                        vp.tarikh_tasis_sherkat.ToGeorgianDateTime();

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    quser.Name_EN_Sherkat = vp.Name_EN_Sherkat;
                    quser.Code_Egtesadi = vp.Code_Egtesadi;
                    quser.Name_Tejari = vp.Name_Tejari;
                    quser.Shomare_Sabt = vp.Shomare_Sabt;
                    quser.Pazirande_Atba = vp.Pazirande_Atba;
                    quser.Code_Faragir = vp.Code_Faragir;
                    quser.Code_Gozarname = vp.Code_Gozarname;
                    quser.Melyat = vp.Melyat;
                    quser.Code_Posti = vp.Code_Posti;
                    quser.TelePhone = vp.TelePhone;
<<<<<<< HEAD

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    if (vp.tarikh_etbar != null)
                    {
                        quser.Tarikh_Etbar = vp.tarikh_etbar.ToGeorgianDateTime();
                    }
                    quser.Shenase_Onvan_Nemayandegi = vp.Shenase_Onvan_Nemayandegi;
                    quser.Shenase_Bazaryab_Nemayandegi = vp.Shenase_Bazaryab_Nemayandegi;
<<<<<<< HEAD

                    quser.Tarikh_Etbar = vp.tarikh_etbar.ToGeorgianDateTime();
                    quser.Shenase_Onvan_Nemayandegi =
                        vp.Shenase_Onvan_Nemayandegi;
                    quser.Shenase_Bazaryab_Nemayandegi =
                        vp.Shenase_Bazaryab_Nemayandegi;

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    quser.Shenase_Porojeh = vp.Shenase_Porojeh;
                    quser.Shenase_Switch = vp.Shenase_Switch;
                    quser.Shenase_Type_Dargah = vp.Shenase_Type_Dargah;
                    quser.Shenase_Type_Dastgah = vp.Shenase_Type_Dargah;
                    quser.Shenase_Model_Dastgah = vp.Shenase_Model_Dastgah;
                    quser.Shenase_Bank = vp.Shenase_Bank;
                    quser.Code_Shobe = vp.Code_Shobe;
                    quser.Shomare_Hesab = vp.Shomare_Hesab;
                    quser.Shomare_Sheba = vp.Shomare_Sheba;
                    quser.Code_Shaparaki_shahr = vp.Code_Shaparaki_shahr;
                    quser.Mantage_Shahri = vp.Mantage_Shahri;
                    quser.Fax = vp.Fax;
                    quser.Code_Takmily_Senf = vp.Code_Takmily_Senf;
                    quser.Onvan_Mahal_Kasb = vp.Onvan_Mahal_Kasb;
                    quser.Onvan_Latin_Kasb = vp.Onvan_Latin_Kasb;
                    quser.Shenase_Malekyat = vp.Shenase_Malekyat;
                    quser.Address_Shaparaki = vp.Address_Shaparaki;
                    quser.Address_Latin = vp.Address_Latin;
                    quser.Shenase_Mahal_kasb = vp.Shenase_Mahal_kasb;
                    quser.Shomare_Javaz_kasb = vp.Shomare_Javaz_kasb;
<<<<<<< HEAD

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    quser.Marja_Saderkonande_Mojavez = vp.Marja_Saderkonande_Mojavez;
                    if (vp.Tarikh_Sodor_Javaz != null)
                    {
                        quser.Tarikh_Sodor_Javaz = vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime();
                    }
                    if (vp.Tarikh_Payan_Etebar != null)
                    {
                        quser.Tarikh_Payan_Etebar = vp.Tarikh_Payan_Etebar.ToGeorgianDateTime();
                    }
                    quser.Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare;
                    if (vp.Tarikh_Etmam_Ejare != null)
                    {
                         quser.Tarikh_Etmam_Ejare = vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime();
                    }

<<<<<<< HEAD
                    quser.Marja_Saderkonande_Mojavez =
                        vp.Marja_Saderkonande_Mojavez;
                    quser.Tarikh_Sodor_Javaz =
                        vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime();
                    quser.Tarikh_Payan_Etebar =
                        vp.Tarikh_Payan_Etebar.ToGeorgianDateTime();
                    quser.Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare;
                    quser.Tarikh_Etmam_Ejare =
                        vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime();

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                    quser.Code_Rahgiri = vp.Code_Rahgiri;
                    quser.Type_Garardad_Hesab = vp.Type_Garardad_Hesab;
                    quser.Shenase_Type_Vagozari = vp.Shenase_Type_Vagozari;
                    quser.Type_Vadieh = vp.Type_Vadieh;
                    quser.Shomare_Sanad = vp.Shomare_Sanad;
                    quser.Mablag_Frosh = vp.Mablag_Frosh;
                    quser.Moaref = vp.Moaref;

                    db.Tbl_Pazirandes.Update (quser);
                    db.SaveChanges();

                    ViewBag.msg = " ثبت با موفقیت انجام شد . ";
                
            }
            else
            {
                ViewBag.msg = " خطا در ثبت .";
            }

            return View();
        }

        public IActionResult createnwe(Vm_PazirandeUser vpu)
        {
            var quser =
                db
                    .Tbl_PazirandeUsers
                    .SingleOrDefault(b => b.National_Code == vpu.National_Code);
            if (quser != null)
            {
                ViewBag.User =
                    db
                        .Tbl_PazirandeUsers
                        .Where(b => b.National_Code == vpu.National_Code)
                        .ToList();
            }
            else
            {
                ViewBag.msg =
                    $" کاربر با کد ملی  {vpu.National_Code}  یافت نشد . ";
            }

            return View();
        }

        public IActionResult Set_Pazirande(Vm_Pazirande vp)
        {
<<<<<<< HEAD

=======
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
            var quser = db.Tbl_PazirandeUsers.SingleOrDefault(a => a.National_Code == vp.Code_Meli);
                Tbl_Pazirande tp = new Tbl_Pazirande();
                    tp.UserName = User.Identity.GetId();
                    tp.Type_Moshtari = quser.Customer_Type ;
                    tp.Code_Meli = quser.National_Code ;
                    tp.Shenase_Meli = quser.Company_Id ;
                    tp.Shomare_Shenasname = quser.Certificate_Code ;
                    tp.Name = quser.Name_fa ;
                    tp.Family = quser.Family_fa ;
                    tp.Tarikh_Tavalod = quser.BirthDay ;
                    tp.Name_Pedar = quser.FatherName_fa ;
                    tp.Jensiat = quser.Gender ;
                    tp.Mobile = quser.Mobile ;
                    tp.Address = quser.Address ;
                    tp.Name_EN = quser.Name_en ;
                    tp.Family_EN = quser.Family_en ;
                    tp.Pedar_EN = quser.FatherName_en ;
                    tp.Name_Sherkat = quser.CompanyName_fa ;
                    tp.Tarikh_Tasis_sherkat = quser.Establishing_Date ;
                    tp.Name_EN_Sherkat = quser.CompanyName_en ;
                    tp.Code_Egtesadi = quser.Economic_Code ;
                    tp.Name_Tejari = quser.Brand_Name ;
                    tp.Shomare_Sabt = quser.Company_Registration ;
                    tp.Pazirande_Atba = vp.Pazirande_Atba ;
                    tp.Code_Faragir = quser.Comprehensive_Code ;
                    tp.Code_Gozarname = quser.Passport_Code ;
                    tp.Tarikh_Etbar = quser.Passport_Validity ;
                    tp.Melyat = quser.Nationality ;
                    tp.Code_Posti = quser.Post ;
                    tp.TelePhone = quser.Phone ;
                    tp.Shenase_Onvan_Nemayandegi = vp.Shenase_Onvan_Nemayandegi ;
                    tp.Shenase_Bazaryab_Nemayandegi = vp.Shenase_Bazaryab_Nemayandegi ;
                    tp.Shenase_Porojeh = vp.Shenase_Porojeh ;
                    tp.Shenase_Switch = vp.Shenase_Switch ;
                    tp.Shenase_Type_Dargah = "POS" ;
                    tp.Shenase_Type_Dastgah = "POS" ;
                    tp.Shenase_Model_Dastgah = "G2" ;
                    tp.Shenase_Bank = vp.Shenase_Bank ;
                    tp.Code_Shobe = vp.Code_Shobe ;
                    tp.Shomare_Hesab = vp.Shomare_Hesab ;
                    tp.Shomare_Sheba = vp.Shomare_Sheba ;
                    tp.Code_Shaparaki_shahr = vp.Code_Shaparaki_shahr ;
                    tp.Mantage_Shahri = vp.Mantage_Shahri ;
                    tp.Fax = vp.Fax ;
                    tp.Code_Takmily_Senf = vp.Code_Takmily_Senf ;
                    tp.Onvan_Mahal_Kasb = vp.Onvan_Mahal_Kasb ;
                    tp.Onvan_Latin_Kasb = vp.Onvan_Latin_Kasb ;
                    tp.Shenase_Malekyat = vp.Shenase_Malekyat ;
                    tp.Address_Shaparaki = vp.Address_Shaparaki ;
                    tp.Address_Latin = vp.Address_Latin ;
                    tp.Shenase_Mahal_kasb = vp.Shenase_Mahal_kasb ;
                    tp.Shomare_Javaz_kasb = vp.Shomare_Javaz_kasb ;
                    tp.Marja_Saderkonande_Mojavez = vp.Marja_Saderkonande_Mojavez ;
                    if (vp.Tarikh_Sodor_Javaz != null)
                    {
                        tp.Tarikh_Sodor_Javaz = vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime() ;
                    }
                    if (vp.Tarikh_Payan_Etebar != null)
                    {
                        tp.Tarikh_Payan_Etebar = vp.Tarikh_Payan_Etebar.ToGeorgianDateTime() ;
                    }
                    tp.Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare ;
                    if (vp.Tarikh_Etmam_Ejare != null)
                    {
                        tp.Tarikh_Etmam_Ejare = vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime() ;
                    }
                    tp.Code_Rahgiri = vp.Code_Rahgiri ;
                    tp.Type_Garardad_Hesab = vp.Type_Garardad_Hesab ;
                    tp.Shenase_Type_Vagozari = vp.Shenase_Type_Vagozari ;
                    tp.Type_Vadieh = vp.Type_Vadieh ;
                    tp.Shomare_Sanad = vp.Shomare_Sanad ;
                    tp.Mablag_Frosh = vp.Mablag_Frosh ;
                    tp.Moaref = vp.Moaref ;
<<<<<<< HEAD
                
                db.Tbl_Pazirandes.Add (tp);

                db.SaveChanges();
=======
                    tp.Status="0";
                db.Tbl_Pazirandes.Add(tp);                db.SaveChanges();
>>>>>>> 5a30f2e4957e08ebd1ecafd1a519d8e513925c8e
                ViewBag.msg = "ثبت با موفقیت انجام شد . ";
            
            return View();
        }
    }
}
