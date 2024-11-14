using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingPortal.Models;
namespace BankingPortal.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Id = 11, Name = "Avdhoot", Email = "avadhut@123" });
            list.Add(new Customer { Id = 12, Name = "Niranjan", Email = "niranjan@123" });
            list.Add(new Customer { Id = 13, Name = "Swapnil", Email = "swapnil@123" });
            //ViewData["list"] = list;


            return View(list);
        }
       /* public ActionResult Details(int id) 
        {
        }*/

    }
}
