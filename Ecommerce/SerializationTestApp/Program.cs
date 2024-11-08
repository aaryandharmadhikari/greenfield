using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Pokolib;
namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> allProducts = svc.GetAll();
            foreach(Product product in allProducts)
            {

            }
        }

    }
}
