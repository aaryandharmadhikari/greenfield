using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalogue;
namespace EcommerceWebsite.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IProductService productservice = new ProductService();
            List<Product> products =productservice.GetAll();
            return View(products);
            
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete() 
        
        {
            return View();
        }

    }
}