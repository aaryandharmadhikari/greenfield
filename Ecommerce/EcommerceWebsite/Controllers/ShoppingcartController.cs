using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWebsite.Controllers
{
    public class ShoppingcartController : Controller
    {
        // GET: Shoppingcart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Addtocart()
        {
            return View(); 
        }

        public ActionResult Removefromcart() 
        {
            return View();
        }


        

    }
}