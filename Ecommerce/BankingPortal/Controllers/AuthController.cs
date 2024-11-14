using BankingPortal.Models;
using BankingPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Repositories;
namespace BankingPortal.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        //POST Auth
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            IAuthServices auth=new AuthService();
            AuthService.SeedingCred();
            if(auth.Login(email,password))
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int Id,string fname,string lname,string email,string contact ,string location,string password)
        {
            User u = new User { ID = Id, FirstName = fname, LastName = lname, Email = email, contact = contact, Location = location };
            AuthService auth =new AuthService();
            //AuthService.SeedingUser();
           // if(auth.Register())*/
            if(auth.Register(u,password))
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return View();
            }
            
        }




      
        public ActionResult ResetPassword()
        {
            return View();
        }





        [HttpPost]
        public ActionResult ResetPassword(string username,string OldPassword, string NewPassword)
        {
            IAuthServices auth=new AuthService();
            AuthService.SeedingCred();
            //IDataRepository<Credentials> cred = new JsonDataRepository<Credentials>();
           if(auth.ResetPassword(username, OldPassword, NewPassword))
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return View();
            }
           
      
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}