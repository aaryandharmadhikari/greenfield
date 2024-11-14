using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Models;
namespace BankingPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string name = "Aaryan Dharmadhikari";
            ViewBag.Name = name;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Contact cnt = new Contact
            {
                ContactNumber = "9876543",
                Email = "simplify@123",
                Website = "simplify@gmail.com"
            };
            ViewData["contact"] = cnt;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThankYou()
        {
            string theMessage = TempData["themessage"] as string;
            ViewData["processmessage"]=theMessage;
            return View();
        }
        
    }
}