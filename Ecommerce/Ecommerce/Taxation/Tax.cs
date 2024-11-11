namespace Taxation
{
    public class Tax
    {
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income Tax " + factor + "deducted from your account");
        }

        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service Tax " + factor + "deducted from your account");
        }

        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional Tax" + factor + " deducted from your account");
        }

        public static void PayGST(float factor)
        {
            Console.WriteLine("GST Tax " + factor + "deducted from your account");
        }
    }
}

