using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Pokolib;

namespace Specification
{
    public interface IDataRepository
    {
        bool Serialize(string filename, List<Product> products);
        List<Product> Deserialize(string filename);
       
    }
}
