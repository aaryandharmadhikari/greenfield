using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using OrderProcessing;
using Catalogue;
namespace EcommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Customer customer1= new Customer();
               customer1.FirstName = "Harry";
               customer1.LastName = "Potter";
               customer1.Email = "Puttar@gmail.com";
               customer1.Contact = "987654321";
               customer1.Id = 12;

            Customer customer2 = new Customer();
            customer2.FirstName = "Rudra";
            customer2.LastName = "Ghadge";
            customer2.Email = "Ghadge@gmail.com";
            customer2.Contact = "123456789";
            customer2.Id = 19;
            ICustomerService customerService= new Customerservice();
              customerService.Insert(customer1);
               customerService.Insert(customer2);
            Console.WriteLine("\n CUSTOMER ");
            List<Customer>allCustomers= customerService.GetAll();
            foreach(Customer customer in allCustomers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Contact);

            }
            //Console.ReadLine();


            Order order1 = new Order();
            order1.OrderId = 36;
            order1.Status = "Rejected";
            order1.Amount = "21000";
            DateTime today = DateTime.Today;
            order1.currentdate= today.ToShortDateString();


            Order order2 = new Order();
            order2.OrderId = 63;
            order2.Status = "Accepted";
            order2.Amount = "31000";
            DateTime today1 = DateTime.Today;
            order2.currentdate = today1.ToShortDateString();

            IOrderService orderService = new OrderServices();
            orderService.Insert(order1);
            orderService.Insert(order2);


            Console.WriteLine("ORDER");
            List<Order> allorders = orderService.GetAll();
            foreach (Order order in allorders)
            {
                Console.WriteLine(order.OrderId);
                Console.WriteLine(order.Amount);
                Console.WriteLine(order.Status);
                Console.WriteLine(order.currentdate);

            }
            //Console.ReadLine();

            Product product1 = new Product();
            product1.ProductID = 33;
            product1.Title = "RiceBran Oil";
            product1.Description = "Very Good";
            product1.Unitprice = 166;
            product1.Quantity = 34;
            product1.ImageURL = "RiceBranOil@yahoo.com";


            Product product2 = new Product();
            product2.ProductID = 39;
            product2.Title ="Ghee";
            product2.Description = "Excellent";
            product2.Unitprice =390;
            product2.Quantity = 23;
            product2.ImageURL = "Ghee@yahoo.com";

            IProductService productService = new ProductService();
            productService.Insert(product1);
            productService.Insert(product2);

            List<Product> allProducts = productService.GetAll();
            Console.WriteLine("PRODUCT");
            foreach (Product product in allProducts)
            {
                Console.WriteLine(product.ProductID);
                Console.WriteLine(product.Title);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Quantity);
                Console.WriteLine(product.Unitprice);
                Console.WriteLine(product.ImageURL);

            }
            Console.ReadLine();
        }
    }
}
