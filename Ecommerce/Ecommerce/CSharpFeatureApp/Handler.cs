using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
      //object oriented function pointer

    public  static class TaxHandler
    {

        public static  void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income Tax "+factor+"deducted from your account");
        }

        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service Tax "+factor+"deducted from your account");
        }

        public static  void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional Tax"+factor+" deducted from your account");
        }

        public static void PayGST(float factor)
        {
            Console.WriteLine("GST Tax "+factor+"deducted from your account");
        }
    }

    public static class PenaltyHandler
    {

        public static void ServiceDisconnectionPenaltyCharges(float amount)
        {
            Console.WriteLine("Disconnection charges applied =" + amount);
        }
        public static  void NotificationPealtyCharges(float amount)
        {
            Console.WriteLine("Notification charges Applied=" + amount);
        }
        
    }

    public static class InterestHandler
    {
        public static void ServiceAddingFixedInterest(float amount)
        {
            Console.WriteLine("Added interest is " + amount);
        }

        public static void ServiceAddingVariableInterest(float amount)
        {
            Console.WriteLine("Added interest is " + amount);
        }

    }
}
