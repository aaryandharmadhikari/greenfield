namespace Penalty
{
    public  static class Penalty
    {
        public static void ServiceDisconnectionPenaltyCharges(float amount)
        {
            Console.WriteLine("Disconnection charges applied =" + amount);
        }
        public static void NotificationPealtyCharges(float amount)
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
    

