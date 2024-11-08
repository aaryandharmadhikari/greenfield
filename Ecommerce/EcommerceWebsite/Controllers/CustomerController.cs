using EcommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWebsite.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerIndex()
        {
           List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id = 21, FirstName = "Ganesh", LastName = "Gaitonde", Contact = "912345789", Email = "gg@gmail.com" });
            customer.Add(new Customer { Id = 22, FirstName = "acdgh", LastName = "nkoiyt", Contact = "9755321", Email = "hh@gmail.com" });
            customer.Add(new Customer { Id = 223, FirstName = "nhgfdsa", LastName = "gfdsaghklk", Contact = "987654321", Email = "aa@gmail.com" });

            return View(customer);
        }
    }
}