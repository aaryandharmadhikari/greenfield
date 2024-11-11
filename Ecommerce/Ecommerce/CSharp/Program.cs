using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Taxation;
using Penalty;
using Delegation;


namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*MathEngine engine = new MathEngine();
            engine.Add(76, 89);
            engine.Add(76, 89, 87);

            MathEngine.ViewNames("Shahrukh", "Salman", "Amir", "Amitabh");
            MathEngine.ViewNames("Raj", "Uddhav", "Eknath");
            MathEngine.ViewNames("Nagarjun", "Allu");


              MathEngine.ShowDetails(65);
              MathEngine.ShowDetails("Aaryan Dharmadhikari");
              MathEngine.ShowDetails(72.9);
            Person person = new Person();
            MathEngine.ShowDetails(person);
            Complex complex = new Complex();//early binding
            Complex c1 = new Complex(19, 39); // early binding
            Complex c2 = new Complex(11, 10);

            Complex c3 = c1 + c2;  //
            Console.WriteLine(c3);  //ToString () method 
                                    //C3 type is complex
                                    //Complex class inherited
                                    // Parent of Complext is Object
                                    //Complex has implementation ToString
                                    //Object also has implementation of ToString

            Employee emp = new Employee { Id = 12, Name = "Raj", BasicSalary = 5000, DA = 500, HRA = 20000 };
            double packageEmp = emp.ComputePay();
            Console.WriteLine(packageEmp);

            emp = new Manager { Id = 13, Name = "Manish", BasicSalary = 5000, DA = 500, HRA = 20000, Incentive = 45000 };
            double packageMgr = emp.ComputePay();
            Console.WriteLine(packageMgr);*/
            /* Handler.PayIncomeTax();
             Handler.PayProfessionalTax();
             Handler.PayServiceTax();
             Handler.PayGST();*/

            /*Operation opn1 = new Operation(TaxHandler.PayIncomeTax);//register method with delegate instance
             Operation opn2 = new Operation(TaxHandler.PayServiceTax);
             Operation opn3 = new Operation(TaxHandler.PayProfessionalTax);
             Operation masterOperation = null;
             masterOperation += opn1;
             masterOperation += opn2;
             masterOperation += opn3;
             //opn1.Invoke(30);
             //opn2.Invoke(20);
             //opn3.Invoke(10);
             masterOperation.Invoke(56);
             masterOperation -= opn3;
             Console.WriteLine("After dechaining");
             masterOperation.Invoke(56);*/

            //object creation
                    Account acct = new Account(15000);
            //EVENT REGISTRATION
           // acct.underBalance+=PenaltyHandler.ServiceDisconnectionPenaltyCharges;
           // acct.underBalance += PenaltyHandler.NotificationPealtyCharges;
            //object invocation
           // acct.Withdraw(8000);

            //object creation
            acct.overBalance += TaxHandler.PayServiceTax;
            acct.overBalance += TaxHandler.PayProfessionalTax;
            acct.overBalance += TaxHandler.PayIncomeTax;

            acct.Deposit(200000);


            Console.ReadLine();
        }
    }
}
