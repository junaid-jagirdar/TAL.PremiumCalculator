using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAL.PremiumCalculatorEngine;
using TAL.UI.Models;

namespace TAL.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPremiuimCalculatorEngine _premiumCalculator;

        public HomeController(IPremiuimCalculatorEngine premiumCalculator)
        {
           this. _premiumCalculator = premiumCalculator;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
          public ActionResult CalaculatePremium(CustomerModel customer)
        {
           var premiuim= _premiumCalculator.CalculateCustomerPremium(new Customer() { Name = customer.Name, DateOfBirth = customer.DateOfBirth, Gender = (PremiumCalculatorEngine.Gender)customer.gender });

            return Json(premiuim,JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "TAL Digital Premium Calculator engine.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Juned";

            return View();
        }
    }
}