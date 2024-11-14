using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingPortal.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            string theMessage = "I am manager responsible for approval of account transaction";
            TempData["mymessage"] = theMessage;
            //return View();
            return RedirectToAction("ThankYou", "home");
        }

        public ActionResult Process()
        {
            string theMessage = TempData["mymessage"] as string;
            ViewData["processmessage"] = theMessage;
            return View();
        }

        public ActionResult Details()
        {
            string userEmail = this.HttpContext.Session["loggedinUser"] as string;
            ViewBag.UserEmail = userEmail;
            return View();
        }

        /*public ActionResult Approve()
        {
            return View();
        }*/
    }
}