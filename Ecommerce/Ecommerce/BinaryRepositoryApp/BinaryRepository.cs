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
       public bool  serialize(string filename, List<Product> products)
        {
            bool status = false;
            //Code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
      
            formatter.Serialize(stream, products);
            stream.Close();
            return status;
        }

        public List<Product> deserialize(string filename)
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

        public bool serializuser(string filename, List<Credentials>credentials )
        {
            bool status = false;
            //Code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

            formatter.Serialize(stream, credentials);
            stream.Close();
            return status;
        }

        public List<Credentials> deserializeuser(string filename)
        {
            List<Credentials> credentials = new List<Credentials>();
            // retrieve all products from file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                credentials = (List<Credentials>)formatter.Deserialize(stream);

            }
            stream.Close();
            return credentials ;
        }

        public bool serializeuser(string filename, List<Credentials> credentials)
        {
            bool status = false;
            //Code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

            formatter.Serialize(stream, credentials);
            stream.Close();
            return status;
        }


        public List<Credentials> deserailizeuser(string filename)
        {
            List<Credentials> credentials = new List<Credentials>();
            // retrieve all products from file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                credentials = (List<Credentials>)formatter.Deserialize(stream);

            }
            stream.Close();
            return credentials;
        }
    }
}
