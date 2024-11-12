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
            /* AuthService  svv = new AuthService();
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
             Console.ReadLine();*/

            IAuthService authService = new AuthService();
            AuthService svc = (AuthService)authService;
            svc.SeedingCred();
            svc.SeedingUser();
            string password, email, firstname, lastname, oldPassword, newPassword;


            int choice;
            do
            {
            
                Console.WriteLine("1: LoGiN\n2:ReGiStRaTiOn\n3: FoRGeT PaSsWoRd\n4: ReSeT PaSsWoRd\n0: ExIt\n");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                      
                        Console.WriteLine("Please enter your Email :");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your Password :");
                        password = Console.ReadLine();

                        if (authService.Login(username, password))
                        {
                            Console.WriteLine("Logged in");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\n\t###############  Register User ##############\n\tPlease Enter your Details Below\n");
                        Console.WriteLine("Enter the User ID here :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the First Name here :");
                        firstname = Console.ReadLine();
                        Console.WriteLine("Enter the Last Name here :");
                        lastname = Console.ReadLine();
                        Console.WriteLine("Enter the Email ID here :");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter the Contact No. here :");
                        string contact = Console.ReadLine();
                        Console.WriteLine("Enter the Password here :");
                        password = Console.ReadLine();

                        authService.Register(new User { ID= id, FirstName = firstname, LastName = lastname, Email = email, contact = contact }, password);
                        Console.WriteLine("New User Created with username " + email);
                        svc.GetAllUsers();
                        break;
                    case 3:
                        Console.WriteLine("\n\n\t###############  Forget User Password ##############\n\tPlease Enter your Details Below\n\n");
                        Console.WriteLine("Enter your Email ID here : ");
                        email = Console.ReadLine();
                        Console.WriteLine("The password for Account with username" + email + " is :" + authService.ForgotPassword(email));
                        break;
                    case 4:
                        Console.WriteLine("\n\n\t###############  Reset User Password ##############\n\tPlease Enter your Details Below\n");
                        Console.WriteLine("Enter the Username/ Email : ");
                        email = Console.ReadLine();
                        Console.WriteLine("Please Enter Your Old Password first : ");
                        oldPassword = Console.ReadLine();
                        Credential userCred = svc.GetCredByEmail(email);
                        if (userCred.Password == oldPassword)
                        {
                            Console.WriteLine("Please Enter your new Password : ");
                            newPassword = Console.ReadLine();
                            authService.ResetPassword(email, newPassword);
                        }
                        else
                        {
                            Console.WriteLine("Oops! you entered wrong credentials");
                        }

                        break;

                }
            }
            while (choice != 0);

        }
    }
}
