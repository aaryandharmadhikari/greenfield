using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokolib;
namespace MembershipTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthService  svv = new AuthService();
            svv.Seeding();
            string email;
            Console.WriteLine("\n Please enter email address");
             email= Console.ReadLine();
            string password;
            Console.WriteLine("\n Please enter password");
             password= Console.ReadLine();
            
             bool flag=svv.Login(email, password);
            if(flag==true)
            {
                Console.WriteLine( "LOGIN SUCCESSFUL");
            }
            else
            {
                Console.WriteLine("LOGIN UNSUCCESSFUL");
            }
            Console.ReadLine();
        }
    }
}
