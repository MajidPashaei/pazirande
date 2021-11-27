using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities.Portal;
using Extensions;
using faraboom.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;

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

        public IActionResult All()
        {
            var qp = db.Tbl_Pazirandes.Where(a => a.UserName == User.Identity.GetId()).ToList();
            ViewBag.all = qp;
            return View();
        }

        public IActionResult Wait()
        {
            return View();
        }

        public IActionResult No()
        {
            return View();
        }

        public IActionResult Ok()
        {
            return View();
        }

        public IActionResult Edit()
        {
          return View();
        }

        public IActionResult createnwe(Vm_PazirandeUser vpu)
        {
            var quser = db.Tbl_PazirandeUsers.SingleOrDefault(b => b.National_Code == vpu.National_Code);
            if (quser != null)
            {
              ViewBag.User =db.Tbl_PazirandeUsers.Where(b => b.National_Code == vpu.National_Code).ToList();
            }
            else
            {
              ViewBag.msg = $" کاربر با کد ملی  {vpu.National_Code}  یافت نشد . ";
            }

            return View();
        }

        public IActionResult Set_Pazirande(Vm_Pazirande vp)
        {
            var quser = db.Tbl_PazirandeUsers.SingleOrDefault(a => a.National_Code == vp.Code_Meli);
            try
            {
                Tbl_Pazirande tp = new Tbl_Pazirande()
                {
                    UserName = User.Identity.GetId(),
                    Type_Moshtari = quser.Customer_Type ,
                    Code_Meli = quser.National_Code ,
                    Shenase_Meli = quser.Company_Id ,
                    Shomare_Shenasname = quser.Certificate_Code ,
                    Name = quser.Name_fa ,
                    Family = quser.Family_fa ,
                    Tarikh_Tavalod = quser.BirthDay ,
                    Name_Pedar = quser.FatherName_fa ,
                    Jensiat = quser.Gender ,
                    Mobile = quser.Mobile ,
                    Address = quser.Address ,
                    Name_EN = quser.Name_en ,
                    Family_EN = quser.Family_en ,
                    Pedar_EN = quser.FatherName_en ,
                    Name_Sherkat = quser.CompanyName_fa ,
                    Tarikh_Tasis_sherkat = quser.Establishing_Date ,
                    Name_EN_Sherkat = quser.CompanyName_en ,
                    Code_Egtesadi = quser.Economic_Code ,
                    Name_Tejari = quser.Brand_Name ,
                    Shomare_Sabt = quser.Company_Registration ,
                    Pazirande_Atba = vp.Pazirande_Atba ,
                    Code_Faragir = quser.Comprehensive_Code ,
                    Code_Gozarname = quser.Passport_Code ,
                    Tarikh_Etbar = quser.Passport_Validity ,
                    Melyat = quser.Nationality ,
                    Code_Posti = quser.Post ,
                    TelePhone = quser.Phone ,
                    Shenase_Onvan_Nemayandegi = vp.Shenase_Onvan_Nemayandegi ,
                    Shenase_Bazaryab_Nemayandegi = vp.Shenase_Bazaryab_Nemayandegi ,
                    Shenase_Porojeh = vp.Shenase_Porojeh ,
                    Shenase_Switch = vp.Shenase_Switch ,
                    Shenase_Type_Dargah = "POS" ,
                    Shenase_Type_Dastgah = "POS" ,
                    Shenase_Model_Dastgah = "G2" ,
                    Shenase_Bank = vp.Shenase_Bank ,
                    Code_Shobe = vp.Code_Shobe ,
                    Shomare_Hesab = vp.Shomare_Hesab ,
                    Shomare_Sheba = vp.Shomare_Sheba ,
                    Code_Shaparaki_shahr = vp.Code_Shaparaki_shahr ,
                    Mantage_Shahri = vp.Mantage_Shahri ,
                    Fax = vp.Fax ,
                    Code_Takmily_Senf = vp.Code_Takmily_Senf ,
                    Onvan_Mahal_Kasb = vp.Onvan_Mahal_Kasb ,
                    Onvan_Latin_Kasb = vp.Onvan_Latin_Kasb ,
                    Shenase_Malekyat = vp.Shenase_Malekyat ,
                    Address_Shaparaki = vp.Address_Shaparaki ,
                    Address_Latin = vp.Address_Latin ,
                    Shenase_Mahal_kasb = vp.Shenase_Mahal_kasb ,
                    Shomare_Javaz_kasb = vp.Shomare_Javaz_kasb ,
                    Marja_Saderkonande_Mojavez = vp.Marja_Saderkonande_Mojavez ,
                    Tarikh_Sodor_Javaz = vp.Tarikh_Sodor_Javaz.ToGeorgianDateTime() ,
                    Tarikh_Payan_Etebar = vp.Tarikh_Payan_Etebar.ToGeorgianDateTime() ,
                    Shomare_Garardad_Ejare = vp.Shomare_Garardad_Ejare ,
                    Tarikh_Etmam_Ejare = vp.Tarikh_Etmam_Ejare.ToGeorgianDateTime() ,
                    Code_Rahgiri = vp.Code_Rahgiri ,
                    Type_Garardad_Hesab = vp.Type_Garardad_Hesab ,
                    Shenase_Type_Vagozari = vp.Shenase_Type_Vagozari ,
                    Type_Vadieh = vp.Type_Vadieh ,
                    Shomare_Sanad = vp.Shomare_Sanad ,
                    Mablag_Frosh = vp.Mablag_Frosh ,
                    Moaref = vp.Moaref ,

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
                db.Tbl_Pazirandes.Add(tp);
                db.SaveChanges();
                ViewBag.msg = "ثبت با موفقیت انجام شد . ";
            }
            catch (System.Exception ex)
            {
                ViewBag.ex = ex;
                ViewBag.msg = " خطا در ثبت . ";
            }

            return View();
        }
    }
}
