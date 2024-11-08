using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public static class PenaltyHandler
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
}
