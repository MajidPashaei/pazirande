using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using faraboom.Models;
using ViewModelLayer.Services;

namespace hampadco.Controllers
{
    [Authorize]
    public class GabzinoController : Controller
    {
        public static string msg;
        public readonly HampadcoContext db;
        public readonly IWebHostEnvironment _env;
 

        public GabzinoController(HampadcoContext _db, IWebHostEnvironment env)
        {
            db = _db;
            _env = env;
        }


        //   استعلام قبض برق
        public IActionResult ShowElectricity(Vm_Gabz bill)
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/ElectricityBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
" +
                "\n" +
                @"	""Identity"":{
" +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
" +
                "\n" +
                @"	},
" +
                "\n" +
                @"	""Parameters"":{
" +
                "\n" +
                @"		""ElectricityBillID"":""String content"",
" +
                "\n" +
                @"		""TraceNumber"":" +
                    "\"" +
                    bill.parameter +
                    "\"" +
                    "" +
                    "\n" +
                @"	}
" +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            // var barg =JsonConvert.DeserializeObject<RootElectricityBillInquiry>(response.Content);
            //     var bb =JsonConvert.DeserializeObject<RootExtraInfo>(barg.);
            return View();
        }

        public IActionResult ElectricityBillInquiry()
        {
            return View();
        }

        // دیسریالایز برق
       

////////





        public IActionResult Verification()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/GasBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
" +
                "\n" +
                @"	""Identity"":{
" +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
" +
                "\n" +
                @"	},
" +
                "\n" +
                @"	""Parameters"":{
" +
                "\n" +
                @"		""GasBillID"":""String content"",
" +
                "\n" +
                @"		""ParticipateCode"":""String content"",
" +
                "\n" +
                @"		""TraceNumber"":""String content""
" +
                "\n" +
                @"	}
" +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض گاز
        public IActionResult GasBillInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/GasBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
" +
                "\n" +
                @"	""Identity"":{
" +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
" +
                "\n" +
                @"	},
" +
                "\n" +
                @"	""Parameters"":{
" +
                "\n" +
                @"		""GasBillID"":""String content"",
" +
                "\n" +
                @"		""ParticipateCode"":""String content"",
" +
                "\n" +
                @"		""TraceNumber"":""String content""
" +
                "\n" +
                @"	}
" +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض آب
        public IActionResult ShowWater(Vm_Gabz bill)
        {
            try
            {
                var client =
                    new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/WaterBillInquiry");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                var body =
                    @"{
             " +
                    "\n" +
                    @"	""Identity"":{
             " +
                    "\n" +
                    @"		""Token"":""44AF74823FE94813B0278F514452CB32""
             " +
                    "\n" +
                    @"	},
             " +
                    "\n" +
                    @"	""Parameters"":{
             " +
                    "\n" +
                    @"		""TraceNumber"":""String content"",
             " +
                    "\n" +
                    @"		""WaterBillID"":" +
                    "\"" +
                    bill.parameter +
                    "\"" +
                    "" +
                    "\n" +
                    @"	}
             " +
                    "\n" +
                    @"}";
                request
                    .AddParameter("application/json",
                    body,
                    ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                // var s =JsonConvert.DeserializeObject<RootWaterBillInquiry>(response.Content);
                // var ei =JsonConvert.DeserializeObject<RootExtraInfo>(s.Parameters.ExtraInfo);
            }
            catch (System.Exception ex)
            {
                ViewBag.ex = ex;
                ViewBag.Msg = "خطا در برقراری ارتباط";
            }

            return View();
        }

        public IActionResult WaterBillInquiry()
        {
            return View();
        }

        
        // استعلام قبض همراه اول برای مشترکین دائمی
        public IActionResult MCIMobileBillInquiry()
        {
            return View();
        }

        public IActionResult ShowMCIMobileBillInquiry()
        {
            try
            {
                var client =
                    new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/MCIMobileBillInquiry");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                var body =
                    @"{
                " +
                    "\n" +
                    @"	""Identity"":{
                " +
                    "\n" +
                    @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                " +
                    "\n" +
                    @"	},
                " +
                    "\n" +
                    @"	""Parameters"":{
                " +
                    "\n" +
                    @"		""MobileNumber"":""String content"",
                " +
                    "\n" +
                    @"		""TraceNumber"":""String content""
                " +
                    "\n" +
                    @"	}
                " +
                    "\n" +
                    @"}";
                request
                    .AddParameter("application/json",
                    body,
                    ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (System.Exception ex)
            {
                // TODO
            }

            return View();
        }

        // استعلام قبض تلفن ثابت
        public IActionResult FixedLineBillInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/FixedLineBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                        " +
                "\n" +
                @"	""Identity"":{
                        " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                        " +
                "\n" +
                @"	},
                        " +
                "\n" +
                @"	""Parameters"":{
                        " +
                "\n" +
                @"		""FixedLineNumber"":""String content"",
                        " +
                "\n" +
                @"		""TraceNumber"":""String content""
                        " +
                "\n" +
                @"	}
                        " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام جرایم رانندگی
        public IActionResult TrafficFinesInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/TrafficFinesInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                   " +
                "\n" +
                @"	""Identity"":{
                   " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                   " +
                "\n" +
                @"	},
                   " +
                "\n" +
                @"	""Parameters"":{
                   " +
                "\n" +
                @"		""BarCode"":""String content"",
                   " +
                "\n" +
                @"		""TraceNumber"":""String content""
                   " +
                "\n" +
                @"	}
                    " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض رایتل برای مشترکین دائمی
        public IActionResult RightelMobileBillInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/RightelMobileBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                     " +
                "\n" +
                @"	""Identity"":{
                     " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                     " +
                "\n" +
                @"	},
                     " +
                "\n" +
                @"	""Parameters"":{
                     " +
                "\n" +
                @"		""MobileNumber"":""String content"",
                     " +
                "\n" +
                @"		""TraceNumber"":""String content""
                     " +
                "\n" +
                @"	}
                     " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض ایرانسل برای مشترکین دائمی
        public IActionResult MtnMobileBillInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/MtnMobileBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                       " +
                "\n" +
                @"	""Identity"":{
                       " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                       " +
                "\n" +
                @"	},
                       " +
                "\n" +
                @"	""Parameters"":{
                       " +
                "\n" +
                @"		""MobileNumber"":""String content"",
                       " +
                "\n" +
                @"		""TraceNumber"":""String content""
                       " +
                "\n" +
                @"	}
                       " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض تلفن ثابت به همراه جزئیات
        public IActionResult FixedLineExtendedBillInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/FixedLineExtendedBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                       " +
                "\n" +
                @"	""Identity"":{
                       " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                       " +
                "\n" +
                @"	},
                       " +
                "\n" +
                @"	""Parameters"":{
                       " +
                "\n" +
                @"		""Cycle"":""String content"",
                       " +
                "\n" +
                @"		""FixedLineNumber"":""String content"",
                       " +
                "\n" +
                @"		""TraceNumber"":""String content""
                       " +
                "\n" +
                @"	}
                       " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام پرداخت قبض
        public IActionResult BillPaymentInquiry()
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/BillPaymentInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
             " +
                "\n" +
                @"	""Identity"":{
             " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
             " +
                "\n" +
                @"	},  
             " +
                "\n" +
                @"	""Parameters"":{
             " +
                "\n" +
                @"		""BillID"":""String content"",
             " +
                "\n" +
                @"		""GatewayName"":""String content"",
             " +
                "\n" +
                @"		""PaymentID"":""String content"",
             " +
                "\n" +
                @"		""TraceNumber"":""String content""
             " +
                "\n" +
                @"	}
             " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }

        // استعلام قبض موبایل تلکیش
        public IActionResult TeleKishMobileBillInquiry(string token3)
        {
            var client =
                new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/TeleKishMobileBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var body =
                @"{
                  " +
                "\n" +
                @"	""Identity"":{
                  " +
                "\n" +
                @"		""Token"":""44AF74823FE94813B0278F514452CB32""
                  " +
                "\n" +
                @"	},
                  " +
                "\n" +
                @"	""Parameters"":{
                  " +
                "\n" +
                @"		""MobileNumber"":""String content"",
                  " +
                "\n" +
                @"		""TraceNumber"":""String content""
                  " +
                "\n" +
                @"	}
                  " +
                "\n" +
                @"}";
            request
                .AddParameter("application/json",
                body,
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return View();
        }
    }
}