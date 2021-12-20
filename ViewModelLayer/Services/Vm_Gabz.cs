using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModelLayer.Services
{
    public class Vm_Gabz
    {
        public string BillId { get; set; }
        public string PayId { get; set; }
        public string parameter { get; set; }
    }
}