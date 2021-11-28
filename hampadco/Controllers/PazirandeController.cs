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
=======
using System.Globalization;
>>>>>>> b48f9839fce176aaa213a6554d61bb251478391a

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

        public IActionResult Edit(int nc)
        {
            var quser = db.Tbl_Pazirandes.SingleOrDefault(a => a.Id == nc);
            Vm_Pazirande vp =
                new Vm_Pazirande()
                {
                    Type_Moshtari = quser.Type_Moshtari,
                    Code_Meli = quser.Code_Meli,
                    Shenase_Meli = quser.Shenase_Meli,
                    Shomare_Shenasname = quser.Shomare_Shenasname,
                    Name = quser.Name,
                    Family = quser.Family,
                    tarikh_tavalod = quser.Tarikh_Tavalod.ToPersianDateString(),
                    Name_Pedar = quser.Name_Pedar,
                    Jensiat = quser.Jensiat,
                    Mobile = quser.Mobile,
                    Address = quser.Address,
                    Name_EN = quser.Name_EN,
                    Family_EN = quser.Family_EN,
                    Pedar_EN = quser.Pedar_EN,
                    Name_Sherkat = quser.Name_Sherkat,
                    tarikh_tasis_sherkat =
                        quser.Tarikh_Tasis_sherkat.ToPersianDateString(),
                    Name_EN_Sherkat = quser.Name_EN_Sherkat,
                    Code_Egtesadi = quser.Code_Egtesadi,
                    Name_Tejari = quser.Name_Tejari,
                    Shomare_Sabt = quser.Shomare_Sabt,
                    Pazirande_Atba = quser.Pazirande_Atba,
                    Code_Faragir = quser.Code_Faragir,
                    Code_Gozarname = quser.Code_Gozarname,
                    Melyat = quser.Melyat,
                    Code_Posti = quser.Code_Posti,
                    TelePhone = quser.TelePhone,
                    tarikh_etbar = quser.Tarikh_Etbar.ToPersianDateString(),
                    Shenase_Onvan_Nemayandegi = quser.Shenase_Onvan_Nemayandegi,
                    Shenase_Bazaryab_Nemayandegi =
                        quser.Shenase_Bazaryab_Nemayandegi,
                    Shenase_Porojeh = quser.Shenase_Porojeh,
                    Shenase_Switch = quser.Shenase_Switch,
                    Shenase_Type_Dargah = quser.Shenase_Type_Dargah,
                    Shenase_Type_Dastgah = quser.Shenase_Type_Dargah,
                    Shenase_Model_Dastgah = quser.Shenase_Model_Dastgah,
                    Shenase_Bank = quser.Shenase_Bank,
                    Code_Shobe = quser.Code_Shobe,
                    Shomare_Hesab = quser.Shomare_Hesab,
                    Shomare_Sheba = quser.Shomare_Sheba,
                    Code_Shaparaki_shahr = quser.Code_Shaparaki_shahr,
                    Mantage_Shahri = quser.Mantage_Shahri,
                    Fax = quser.Fax,
                    Code_Takmily_Senf = quser.Code_Takmily_Senf,
                    Onvan_Mahal_Kasb = quser.Onvan_Mahal_Kasb,
                    Onvan_Latin_Kasb = quser.Onvan_Latin_Kasb,
                    Shenase_Malekyat = quser.Shenase_Malekyat,
                    Address_Shaparaki = quser.Address_Shaparaki,
                    Address_Latin = quser.Address_Latin,
                    Shenase_Mahal_kasb = quser.Shenase_Mahal_kasb,
                    Shomare_Javaz_kasb = quser.Shomare_Javaz_kasb,
                    Marja_Saderkonande_Mojavez =
                        quser.Marja_Saderkonande_Mojavez,
                    Tarikh_Sodor_Javaz =
                        quser.Tarikh_Sodor_Javaz.ToPersianDateString(),
                    Tarikh_Payan_Etebar =
                        quser.Tarikh_Payan_Etebar.ToPersianDateString(),
                    Shomare_Garardad_Ejare = quser.Shomare_Garardad_Ejare,
                    Tarikh_Etmam_Ejare =
                        quser.Tarikh_Etmam_Ejare.ToPersianDateString(),
                    Code_Rahgiri = quser.Code_Rahgiri,
                    Type_Garardad_Hesab = quser.Type_Garardad_Hesab,
                    Shenase_Type_Vagozari = quser.Shenase_Type_Vagozari,
                    Type_Vadieh = quser.Type_Vadieh,
                    Shomare_Sanad = quser.Shomare_Sanad,
                    Mablag_Frosh = quser.Mablag_Frosh,
                    Moaref = quser.Moaref
                };

            return View(vp);
        }

        public IActionResult Set_Edit(Vm_Pazirande vp)
        {
            var quser =
                db
                    .Tbl_Pazirandes
                    .SingleOrDefault(a => a.Code_Meli == vp.Code_Meli);
            if (quser != null)
            {
                    quser.Type_Moshtari = vp.Type_Moshtari;
                    quser.Code_Meli = vp.Code_Meli;
                    quser.Shenase_Meli = vp.Shenase_Meli;
                    quser.Shomare_Shenasname = vp.Shomare_Shenasname;
                    quser.Name = vp.Name;
                    quser.Family = vp.Family;
<<<<<<< HEAD
                    if (vp.tarikh_tavalod != null)
                    {
                        quser.Tarikh_Tavalod = vp.tarikh_tavalod.ToGeorgianDateTime();
                    }
=======
                    quser.Tarikh_Tavalod =
                        vp.tarikh_tavalod.ToGeorgianDateTime();
>>>>>>> 2004aa085f5ef91c897d10410507eaa515041f49
                    quser.Name_Pedar = vp.Name_Pedar;
                    quser.Jensiat = vp.Jensiat;
                    quser.Mobile = vp.Mobile;
                    quser.Address = vp.Address;
                    quser.Name_EN = vp.Name_EN;
                    quser.Family_EN = vp.Family_EN;
                    quser.Pedar_EN = vp.Pedar_EN;
                    quser.Name_Sherkat = vp.Name_Sherkat;
<<<<<<< HEAD
                    if (vp.tarikh_tasis_sherkat != null)
                    {
                        quser.Tarikh_Tasis_sherkat = vp.tarikh_tasis_sherkat.ToGeorgianDateTime();
                    }
=======
                    quser.Tarikh_Tasis_sherkat =
                        vp.tarikh_tasis_sherkat.ToGeorgianDateTime();
>>>>>>> 2004aa085f5ef91c897d10410507eaa515041f49
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
                    if (vp.tarikh_etbar != null)
                    {
                        quser.Tarikh_Etbar = vp.tarikh_etbar.ToGeorgianDateTime();
                    }
                    quser.Shenase_Onvan_Nemayandegi = vp.Shenase_Onvan_Nemayandegi;
                    quser.Shenase_Bazaryab_Nemayandegi = vp.Shenase_Bazaryab_Nemayandegi;
=======
                    quser.Tarikh_Etbar = vp.tarikh_etbar.ToGeorgianDateTime();
                    quser.Shenase_Onvan_Nemayandegi =
                        vp.Shenase_Onvan_Nemayandegi;
                    quser.Shenase_Bazaryab_Nemayandegi =
                        vp.Shenase_Bazaryab_Nemayandegi;
>>>>>>> 2004aa085f5ef91c897d10410507eaa515041f49
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
=======
                    quser.Marja_Saderkonande_Mojavez =
                        vp.Marja_Saderkonande_Mojavez;
                    quser.Tarikh_Sodor_Javaz =
                        vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime();
                    quser.Tarikh_Payan_Etebar =
                        vp.Tarikh_Payan_Etebar.ToGeorgianDateTime();
                    quser.Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare;
                    quser.Tarikh_Etmam_Ejare =
                        vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime();
>>>>>>> 2004aa085f5ef91c897d10410507eaa515041f49
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
                db.Tbl_Pazirandes.Add(tp);
=======
            var quser =
                db
                    .Tbl_PazirandeUsers
                    .SingleOrDefault(a => a.National_Code == vp.Code_Meli);
            try
            {
                Tbl_Pazirande tp =
                    new Tbl_Pazirande()
                    {
                        UserName = User.Identity.GetId(),
                        Type_Moshtari = quser.Customer_Type,
                        Code_Meli = quser.National_Code,
                        Shenase_Meli = quser.Company_Id,
                        Shomare_Shenasname = quser.Certificate_Code,
                        Name = quser.Name_fa,
                        Family = quser.Family_fa,
                        Tarikh_Tavalod = quser.BirthDay,
                        Name_Pedar = quser.FatherName_fa,
                        Jensiat = quser.Gender,
                        Mobile = quser.Mobile,
                        Address = quser.Address,
                        Name_EN = quser.Name_en,
                        Family_EN = quser.Family_en,
                        Pedar_EN = quser.FatherName_en,
                        Name_Sherkat = quser.CompanyName_fa,
                        Tarikh_Tasis_sherkat = quser.Establishing_Date,
                        Name_EN_Sherkat = quser.CompanyName_en,
                        Code_Egtesadi = quser.Economic_Code,
                        Name_Tejari = quser.Brand_Name,
                        Shomare_Sabt = quser.Company_Registration,
                        Pazirande_Atba = vp.Pazirande_Atba,
                        Code_Faragir = quser.Comprehensive_Code,
                        Code_Gozarname = quser.Passport_Code,
                        Tarikh_Etbar = quser.Passport_Validity,
                        Melyat = quser.Nationality,
                        Code_Posti = quser.Post,
                        TelePhone = quser.Phone,
                        Shenase_Onvan_Nemayandegi =
                            vp.Shenase_Onvan_Nemayandegi,
                        Shenase_Bazaryab_Nemayandegi =
                            vp.Shenase_Bazaryab_Nemayandegi,
                        Shenase_Porojeh = vp.Shenase_Porojeh,
                        Shenase_Switch = vp.Shenase_Switch,
                        Shenase_Type_Dargah = "POS",
                        Shenase_Type_Dastgah = "POS",
                        Shenase_Model_Dastgah = "G2",
                        Shenase_Bank = vp.Shenase_Bank,
                        Code_Shobe = vp.Code_Shobe,
                        Shomare_Hesab = vp.Shomare_Hesab,
                        Shomare_Sheba = vp.Shomare_Sheba,
                        Code_Shaparaki_shahr = vp.Code_Shaparaki_shahr,
                        Mantage_Shahri = vp.Mantage_Shahri,
                        Fax = vp.Fax,
                        Code_Takmily_Senf = vp.Code_Takmily_Senf,
                        Onvan_Mahal_Kasb = vp.Onvan_Mahal_Kasb,
                        Onvan_Latin_Kasb = vp.Onvan_Latin_Kasb,
                        Shenase_Malekyat = vp.Shenase_Malekyat,
                        Address_Shaparaki = vp.Address_Shaparaki,
                        Address_Latin = vp.Address_Latin,
                        Shenase_Mahal_kasb = vp.Shenase_Mahal_kasb,
                        Shomare_Javaz_kasb = vp.Shomare_Javaz_kasb,
                        Marja_Saderkonande_Mojavez =
                            vp.Marja_Saderkonande_Mojavez,
                        Tarikh_Sodor_Javaz =
                            vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime(),
                        Tarikh_Payan_Etebar =
                            vp.Tarikh_Payan_Etebar.ToGeorgianDateTime(),
                        Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare,
                        Tarikh_Etmam_Ejare =
                            vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime(),
                        Code_Rahgiri = vp.Code_Rahgiri,
                        Type_Garardad_Hesab = vp.Type_Garardad_Hesab,
                        Shenase_Type_Vagozari = vp.Shenase_Type_Vagozari,
                        Type_Vadieh = vp.Type_Vadieh,
                        Shomare_Sanad = vp.Shomare_Sanad,
                        Mablag_Frosh = vp.Mablag_Frosh,
                        Moaref = vp.Moaref

                        // Phone_Moaref = vp.Name_EN ,
                        // Tedad_Agsat = vp.Name_EN ,
                        // Mablag_Agsat = vp.Name_EN ,
                        // Mobail_Motasel = vp.Name_EN ,
                        // Name_Fani_Pos = vp.Name_EN ,
                        // Mobaile_Fani_Pos = vp.Name_EN ,
                        // Telephone_Fani_Pos = vp.Name_EN ,
                        // Shomare_Pazirande = vp.Name_EN ,
                        // Shomare_Terminal = vp.Name_EN ,
                        // Serial_Dastgah = vp.Name_EN ,
                        // -- Tarikh_Nasb = vp.Name_EN ,
                        // Shomare_Marja = vp.Name_EN ,
                        // -- Tarikh_Tarif_Switch = vp.Name_EN ,
                        // -- Tarikh_Tarif_Shaparak = vp.Name_EN ,
                        // Nemad_Elektroniki = vp.Name_EN ,
                        // -- Tarikh_Etmam_Etebar = vp.Name_EN ,
                        // -- Tarikh_Sodor_Nemad = vp.Name_EN ,
                        // Type_Nemad = vp.Name_EN ,
                        // Server_Frosh = vp.Name_EN ,
                        // IPGAccessPort = vp.Name_EN ,
                        // IPGCallBackAddress = vp.Name_EN ,
                        // Address_Post_Sherkat = vp.Name_EN ,
                        // Mahsolat_Frosh = vp.Name_EN ,
                        // Address_Post = vp.Name_EN ,
                        // Family_Masol_Fani = vp.Name_EN ,
                        // Mobail_Masol_Fani = vp.Name_EN ,
                        // Name_Fani_Masol_Fani = vp.Name_EN ,
                        // Code_Meli_Masol_Fani = vp.Name_EN ,
                        // Address_Site = vp.Name_EN ,
                        // Emkan_Lagv = vp.Name_EN ,
                        // Zamine_Faliat = vp.Name_EN ,
                    };
                db.Tbl_Pazirandes.Add (tp);
>>>>>>> 2004aa085f5ef91c897d10410507eaa515041f49
                db.SaveChanges();
                ViewBag.msg = "ثبت با موفقیت انجام شد . ";
            
            return View();
        }
    }
}
