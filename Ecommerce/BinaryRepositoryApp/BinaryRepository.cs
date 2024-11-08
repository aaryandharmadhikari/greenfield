using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Specification;
using Pokolib;
namespace BinaryRepositoryApp
{
    public class BinaryReposiTory:IDataRepository
    {
       public bool  Serialize(string filename, List<Product> products)
        {
            bool status = false;
            //Code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.Open);
      
            formatter.Serialize(stream, products);
            stream.Close();
            return status;
        }

        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();
            // retrieve all products from file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                products = (List<Product>)formatter.Deserialize(stream);

            }
            stream.Close();
            return products;
        }
    }
}
