using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Entities.Portal
{
    public class Tbl_PazirandeUser
    {
        [Key]
        public int Id { get; set; }
         public string Document_Garadad { get; set; }

        public string Document_Esteshhad { get; set; }

        public string Document_Soratjalase { get; set; }

        public string Document_Masdig { get; set; }
        public string User_Name { get; set; }
        public string Customer_Number { get; set; }
        public string Customer_Group { get; set; }
        public string Customer_Type { get; set; }
        public string Customer_National { get; set; }
        public string Name_fa { get; set; }
        public string Name_en { get; set; }
        public string Family_fa { get; set; }
        public string Family_en { get; set; }
        public string FatherName_fa { get; set; }
        public string FatherName_en { get; set; }
        public string Gender { get; set; }
        public string National_Code { get; set; }
        public string Certificate_Code { get; set; }
        public string Certificate_Serial { get; set; } //---- سریال شناسنامه
        public string Certificate_NumSerial { get; set; }  //---- بخش عددی سریال شناسنامه
        public string Certificate_Letters { get; set; } //---- بخش حروف سریال شناسنامه
        public string Education { get; set; }
        public string Address { get; set; }
        public string Birth_Place { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay{ get; set; }
        // public string birthday{ get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Phone_Code { get; set; } //--------  کد تلفن شهر
        public string State { get; set; }
        public string City { get; set; }
        public string Post { get; set; } //-----------    کد پستی
        public string Company_Id { get; set; }  //--------   شناسه ملی شرکت
        public DateTime Establishing_Date { get; set; }  //------  تاریخ تاسیس
        // public string establishing_date { get; set; }  //--------   تاریخ تاسیس
        public string CompanyName_fa { get; set; }
        public string CompanyName_en { get; set; }
        public string Brand_Name { get; set; }  //------------  نام تجاری
        public string Company_Registration { get; set; }  //--------   شماره ثبت شرکت
        public string Economic_Code { get; set; }  //-------------  کد اقتصادی 
        public string Comprehensive_Code { get; set; }   //---------   کد فراگیر اتباع خارجی
        public string Passport_Code { get; set; }
        public DateTime Passport_Validity { get; set; }  //----------  تاریخ اعتبار گذرنامه 
        // public string passport_validity { get; set; }   //----------  تاریخ اعتبار گذرنامه 
        public string Nationality { get; set; }

        // public IFormFile NationalCard_Image1 { get; set; }  //---------  تصویر کارت ملی (رو)
        public string nationalcard_image1 { get; set; }    //---------  تصویر کارت ملی (رو)
        // public IFormFile NationalCard_Image2 { get; set; }   //---------  تصویر کارت ملی (پشت)
        public string nationalcard_image2 { get; set; }  //---------  تصویر کارت ملی (پشست)
        // public IFormFile Certificate_Image { get; set; }  //--------   تصویر شناسنامه
        public string certificate_image { get; set; }  //--------   تصویر شناسنامه

        // public IFormFile Newspaper_Image { get; set; } //---------------- تصویر آخرین روزنامه رسمی
        public string newspaper_image { get; set; } //---------------- تصویر آخرین روزنامه رسمی
        // public IFormFile Statute_Image { get; set; }  //------- تصویر صفحات اساسنامه
        public string statute_image { get; set; }  //------- تصویر صفحات اساسنامه
        // public IFormFile Establishment_Image { get; set; }  //----------- تصویر آگهی تاسیس
        public string establishment_image { get; set; }  //----------- تصویر آگهی تاسیس

        // public IFormFile Passport_Image { get; set; }  //----- تصویر گذرنامه
        public string passport_image { get; set; }  //----- تصویر گذرنامه
        // public IFormFile ArrangementCard_Image { get; set; }  //------- تصویر کارت آمایش
        public string arrangementcard_image { get; set; }  //------- تصویر کارت آمایش
        // public IFormFile WorkPermit_Image { get; set; }  //---------- تصویر مجوز کار
        public string workpermit_image { get; set; }  //---------- تصویر مجوز کار

        public DateTime Set_Date{ get; set; }
        public string setdate{ get; set; }
        public string Status { get; set; }
    }
}