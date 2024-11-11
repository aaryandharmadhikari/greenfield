using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokolib
{
    [Serializable]
    public class Product
    {
        public int ProductID {  get; set; }

       public string Title { get; set; }

       public string Description { get; set; } 

        public int Unitprice { get; set; }

        public int Quantity { get; set; }

        public string ImageURL { get; set; }


    }
}
