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
        public IActionResult getElectricity()
        {
            return View();
        }
        //   استعلام قبض برق
        public IActionResult ShowElectricity(Vm_Gabz bill)
        {
            var tok="44AF74823FE94813B0278F514452CB32";
            // var billId="1057030101320";
            // var tnumber="1057030101320";
            try
            {
                var client = new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/ElectricityBillInquiry");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var body = $"{{\r\n\n\t\"Identity\":{{\r\n\n\t\t\"Token\":\"{tok}\"\r\n\n\t}},\r\n\n\t\"Parameters\":{{\r\n\n\t\t\"ElectricityBillID\":\"{bill.parameter}\",\r\n\n\t\t\"TraceNumber\":\"{bill.parameter}\"\r\n\n\t}}\r\n\n}}";
                request.AddParameter("application/json", body,  ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var result= JsonConvert.DeserializeObject<RootElectricity>(response.Content);
                if (result.Status.Code=="G00000")
                
                {
                    ViewBag.result=result.Parameters;
                }
                else
                {
                    ViewBag.er="پارامتر های ورودی نادرست میباشد";
                }
            }
            catch (System.Exception)
            { ViewBag.er="پارامتر های ورودی نادرست میباشد";}
            
            
            return View();
        }
        // دیسریالایز برق
        public class ParametersElectricity
        {
            [JsonProperty("Address")]
            public string Address { get; set; }
    
            [JsonProperty("Amount")]
            public int Amount { get; set; }
    
            [JsonProperty("AverageConsumption")]
            public string AverageConsumption { get; set; }
    
            [JsonProperty("BillID")]
            public string BillID { get; set; }
    
            [JsonProperty("BillPdfUrl")]
            public object BillPdfUrl { get; set; }
    
            [JsonProperty("CurrentDate")]
            public string CurrentDate { get; set; }
    
            [JsonProperty("CustomerType")]
            public string CustomerType { get; set; }
    
            [JsonProperty("Cycle")]
            public string Cycle { get; set; }
    
            [JsonProperty("ExtraInfo")]
            public string ExtraInfo { get; set; }
    
            [JsonProperty("FullName")]
            public string FullName { get; set; }
    
            [JsonProperty("InsuranceAmount")]
            public string InsuranceAmount { get; set; }
    
            [JsonProperty("PaymentDate")]
            public string PaymentDate { get; set; }
    
            [JsonProperty("PaymentID")]
            public string PaymentID { get; set; }
    
            [JsonProperty("PaytollAmount")]
            public string PaytollAmount { get; set; }
    
            [JsonProperty("PowerPaytollAmount")]
            public string PowerPaytollAmount { get; set; }
    
            [JsonProperty("PreviousDate")]
            public string PreviousDate { get; set; }
    
            [JsonProperty("SaleYear")]
            public string SaleYear { get; set; }
    
            [JsonProperty("TariffType")]
            public string TariffType { get; set; }
    
            [JsonProperty("TaxAmount")]
            public string TaxAmount { get; set; }
    
            [JsonProperty("TotalDays")]
            public string TotalDays { get; set; }
        }
        public class StatusElectricity
        {
            [JsonProperty("Code")]
            public string Code { get; set; }
    
            [JsonProperty("Description")]
            public string Description { get; set; }
        }
        public class RootElectricity
        {
            [JsonProperty("Parameters")]
            public ParametersElectricity Parameters { get; set; }
    
            [JsonProperty("Status")]
            public StatusElectricity Status { get; set; }
        }
        ////////ExtraInfo deserlatayz
        public IActionResult GetGasBillInquiry()
        {
            return View();
        }
        public IActionResult ShowGasBillInquiry(Vm_Gabz bill)
        {
            var tok="44AF74823FE94813B0278F514452CB32";
            var billId="24605708036";
            var tnumber="24605708036";
            var eshterak="022024605730";
            try
            {
                var client = new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/GasBillInquiry");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var body = $"{{\r\n\n\t\"Identity\":{{\r\n\n\t\t\"Token\":\"{tok}\"\r\n\n\t}},\r\n\n\t\"Parameters\":{{\r\n\n\t\t\"GasBillID\":\"{billId}\",\r\n\n\t\t\"ParticipateCode\":\"{eshterak}\",\r\n\n\t\t\"TraceNumber\":\"{tnumber}\"\r\n\n\t}}\r\n\n}}";
                request.AddParameter("application/json", body,  ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var result= JsonConvert.DeserializeObject<RootGasBillInquiry>(response.Content);
                if (result.Status.Code=="G00000")
                {
                    ViewBag.result=result.Parameters;
                }
                else
                {
                    ViewBag.er="پارامتر های ورودی نادرست میباشد";
                }
            }
            catch (System.Exception)
            {
                ViewBag.er="پارامتر های ورودی نادرست میباشد";
            }
            return View();
        }
        // دیسریالایز قبض گاز
        public class ParametersGasBillInquiry
        {
            [JsonProperty("Abonman")]
            public string Abonman { get; set; }

            [JsonProperty("Address")]
            public string Address { get; set; }

            [JsonProperty("Amount")]
            public long Amount { get; set; }

            [JsonProperty("BillID")]
            public string BillID { get; set; }

            [JsonProperty("BillPdfUrl")]
            public string BillPdfUrl { get; set; }

            [JsonProperty("ConsumptionType")]
            public string ConsumptionType { get; set; }

            [JsonProperty("CurrentCounterDigit")]
            public string CurrentCounterDigit { get; set; }

            [JsonProperty("CurrentDate")]
            public string CurrentDate { get; set; }

            [JsonProperty("ExtraInfo")]
            public string ExtraInfo { get; set; }

            [JsonProperty("FullName")]
            public string FullName { get; set; }

            [JsonProperty("Insurance")]
            public string Insurance { get; set; }

            [JsonProperty("PaymentDate")]
            public string PaymentDate { get; set; }

            [JsonProperty("PaymentID")]
            public string PaymentID { get; set; }

            [JsonProperty("PreviousCounterDigit")]
            public string PreviousCounterDigit { get; set; }

            [JsonProperty("PreviousDate")]
            public string PreviousDate { get; set; }

            [JsonProperty("Tax")]
            public string Tax { get; set; }
        }

        public class StatusGasBillInquiry
        {
            [JsonProperty("Code")]
            public string Code { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }
        }

        public class RootGasBillInquiry
        {
            [JsonProperty("Parameters")]
            public ParametersGasBillInquiry Parameters { get; set; }

            [JsonProperty("Status")]
            public StatusGasBillInquiry Status { get; set; }
        }

    public IActionResult GetWaterBillInquiry()
    {
        return View();
    }
    
    public IActionResult ShowWaterBillInquiry(Vm_Gabz bill)
    {
        var tok="44AF74823FE94813B0278F514452CB32";
        var billId="1012150803111";
        var tnumber="1012150803111";
        try
        {
            var client = new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/WaterBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = $"{{\r\n\n\t\"Identity\":{{\r\n\n\t\t\"Token\":\"{tok}\"\r\n\n\t}},\r\n\n\t\"Parameters\":{{\r\n\n\t\t\"WaterBillID\":\"{billId}\",\r\n\n\t\t\"TraceNumber\":\"{tnumber}\"\r\n\n\t}}\r\n\n}}";
            request.AddParameter("application/json", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var result= JsonConvert.DeserializeObject<RootWaterBillInquiry>(response.Content);
            if (result.Status.Code=="G00000")
            {
                ViewBag.result=result.Parameters;
            }
            else
            {
                ViewBag.er="پارامتر های ورودی نادرست میباشد";
            }
        }
        catch (System.Exception)
        {
            ViewBag.er="پارامتر های ورودی نادرست میباشد";
        }
        return View();
    }
    

    //دیسریالایز آب
    public class ParametersWaterBillInquiry
    {
        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("BillID")]
        public string BillID { get; set; }

        [JsonProperty("BillPdfUrl")]
        public object BillPdfUrl { get; set; }

        [JsonProperty("CurrentDate")]
        public string CurrentDate { get; set; }

        [JsonProperty("ExtraInfo")]
        public string ExtraInfo { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("PaymentDate")]
        public object PaymentDate { get; set; }

        [JsonProperty("PaymentID")]
        public object PaymentID { get; set; }

        [JsonProperty("PreviousDate")]
        public string PreviousDate { get; set; }
    }

    public class StatusWaterBillInquiry
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class RootWaterBillInquiry
    {
        [JsonProperty("Parameters")]
        public ParametersWaterBillInquiry Parameters { get; set; }

        [JsonProperty("Status")]
        public StatusWaterBillInquiry Status { get; set; }
    }
     public IActionResult ShowMCIMobileBillInquiry(Vm_Gabz bill)
    {
        var tok="44AF74823FE94813B0278F514452CB32";
        var billId="09141888830";
        var tnumber="09141888830";
        try
        {
            var client = new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/MCIMobileBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = $"{{\r\n\n\t\"Identity\":{{\r\n\n\t\t\"Token\":\"{tok}\"\r\n\n\t}},\r\n\n\t\"Parameters\":{{\r\n\n\t\t\"MobileNumber\":\"{billId}\",\r\n\n\t\t\"TraceNumber\":\"{tnumber}\"\r\n\n\t}}\r\n\n}}";
            request.AddParameter("application/json", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var result= JsonConvert.DeserializeObject<RootMCIMobileBillInquiry>(response.Content);
            if (result.Status.Code=="G00000")
            {
                ViewBag.result=result.Parameters;
            }
            else
            {
                ViewBag.er="پارامتر های ورودی نادرست میباشد";
            }
        }
        catch (System.Exception)
        {
            ViewBag.er="پارامتر های ورودی نادرست میباشد";
        }
        return View();
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class FinalTermMCIMobileBillInquiry
    {
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("BillID")]
        public string BillID { get; set; }

        [JsonProperty("PaymentID")]
        public string PaymentID { get; set; }
    }

    public class MidTermMCIMobileBillInquiry
    {
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("BillID")]
        public string BillID { get; set; }

        [JsonProperty("PaymentID")]
        public string PaymentID { get; set; }
    }

    public class ParametersMCIMobileBillInquiry
    {
        [JsonProperty("FinalTerm")]
        public FinalTermMCIMobileBillInquiry FinalTerm { get; set; }

        [JsonProperty("MidTerm")]
        public MidTermMCIMobileBillInquiry MidTerm { get; set; }
    }

    public class StatusMCIMobileBillInquiry
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class RootMCIMobileBillInquiry
    {
        [JsonProperty("Parameters")]
        public ParametersMCIMobileBillInquiry Parameters { get; set; }

        [JsonProperty("Status")]
        public StatusMCIMobileBillInquiry Status { get; set; }
    }

    public IActionResult FixedLineBillInquiry()
    {
        var tok="44AF74823FE94813B0278F514452CB32";
        var billId="04435256830";
        var tnumber="04435256830";
        try
        {
            var client = new RestClient("https://core.inquiry.ayantech.ir/webservices/Core.svc/FixedLineBillInquiry");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = $"{{\r\n\n\t\"Identity\":{{\r\n\n\t\t\"Token\":\"{tok}\"\r\n\n\t}},\r\n\n\t\"Parameters\":{{\r\n\n\t\t\"FixedLineNumber\":\"{billId}\",\r\n\n\t\t\"TraceNumber\":\"{tnumber}\"\r\n\n\t}}\r\n\n}}";
            request.AddParameter("application/json", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var result= JsonConvert.DeserializeObject<RootFixedLineBillInquiry>(response.Content);
            if (result.Status.Code=="G00000")
            {
                ViewBag.result=result.Parameters;
            }
            else
            {
                ViewBag.er="پارامتر های ورودی نادرست میباشد";
            }
        }
        catch (System.Exception)
        {
            ViewBag.er="پارامتر های ورودی نادرست میباشد";
        }
        return View();
    }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class FinalTermFixedLineBillInquiry
    {
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("BillID")]
        public string BillID { get; set; }

        [JsonProperty("Cycle")]
        public object Cycle { get; set; }

        [JsonProperty("PaymentID")]
        public string PaymentID { get; set; }
    }

    public class MidTermFixedLineBillInquiry
    {
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("BillID")]
        public string BillID { get; set; }

        [JsonProperty("Cycle")]
        public object Cycle { get; set; }

        [JsonProperty("PaymentID")]
        public string PaymentID { get; set; }
    }

    public class ParametersFixedLineBillInquiry
    {
        [JsonProperty("FinalTerm")]
        public FinalTermFixedLineBillInquiry FinalTerm { get; set; }

        [JsonProperty("MidTerm")]
        public MidTermFixedLineBillInquiry MidTerm { get; set; }
    }

    public class StatusFixedLineBillInquiry
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class RootFixedLineBillInquiry
    {
        [JsonProperty("Parameters")]
        public ParametersFixedLineBillInquiry Parameters { get; set; }

        [JsonProperty("Status")]
        public StatusFixedLineBillInquiry Status { get; set; }
    }


    



    }
}