using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Pokolib;
using Services;
namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> allProducts = svc.GetAll();
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.Title+ " " + product.Unitprice);
            }
            Console.ReadLine();
        }

    }
}
