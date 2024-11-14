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
    //ublic class BinaryRepository<T>:IDataRepository<T>
    //
    /* public bool  serialize(string filename, List<Product> products)
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
      }*/

    /*public bool serializuser(string filename, List<Credentials>credentials )
    {
        bool status = false;
        //Code for saving
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);

        formatter.Serialize(stream, credentials);
        stream.Close();
        return status;
    }*/

    /*public List<Credentials> deserializeuser(string filename)
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
     }*/

    
    public class BinaryRepository<T> :IDataRepository<T>
    {
        private static BinaryRepository<T> _ref = null;
        public  BinaryRepository()
        {
        }
        public static BinaryRepository<T> Create()
        {
            if (_ref == null) return new BinaryRepository<T>();
            return _ref;
        }
        public bool Serialize<T>(string filename, List<T> products)
        {
            bool status = false;
            //code for saving

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream, products);
            stream.Close();
            status = true;
            return status;
        }



        List<T> IDataRepository<T>.Deserialize<T>(string filename)
        {
            List<T> products = new List<T>();
            BinaryFormatter formatter = new BinaryFormatter();
            //string path = HttpContext.Current.Server.MapPath(filename);
            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                products = (List<T>)formatter.Deserialize(stream);
            }
            stream.Close();
            return products;
        }



    }
}
