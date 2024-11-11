using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderProcessing
{
    public class Order
    {
        public int OrderId { get; set; }

        public string Amount { get; set; }

        public string Status{ get; set; }

        // If you only want the current date
       // DateTime today = DateTime.Today;
        public string currentdate { get; set; }


    }
}
