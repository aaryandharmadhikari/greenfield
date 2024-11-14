using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using System.Text.Json;
using System.Threading.Tasks;
using Specification;
using Newtonsoft;
using Newtonsoft.Json;
namespace JsonDataRepository
{
    public class JsonRepository<T>:IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> items)
        {
           /* bool status = false;
            FileStream createStream = File.Create(filename);
            JsonSerializer.Serialize(createStream, items);
            createStream.Close();
            return status;*/

           string jsondata=JsonConvert.SerializeObject(items);
            File.WriteAllText(filename, jsondata); ;
            return true;
        }
        public List<T> Deserialize(string filename)
        {
            List<T> items = new List<T>();
            // FileStream stream = new FileStream(filename, FileMode.Open);
            string jsondata = File.ReadAllText(filename);
            /*if (stream != null)
            {
                items = JsonSerializer.Deserialize<List<T>>(stream);
            }*/
            items=JsonConvert.DeserializeObject<List<T>>(jsondata);

           // stream.Close();
            // retrive all products from file
            return items;
        }
    }
}
