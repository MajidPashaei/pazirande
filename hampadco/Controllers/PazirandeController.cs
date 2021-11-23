using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModelLayer.Portal;

namespace Namespace
{
    [Authorize]
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
          var user=db.Tbl_PazirandeUsers.Where(b =>b.National_Code==vpu.National_Code).ToList();
          ViewBag.User=user;
          return View();
        }
        public IActionResult Setpazirandex()
        {
          return View();
        }
        
    }
}