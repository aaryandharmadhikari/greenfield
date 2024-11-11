using Pokolib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification

{
    public interface IDataRepository
    {
        bool serialize(string filename, List<Product> products);
        List<Product> deserialize(string filename);

        bool serializeuser(string filename, List<Credentials> credentials);
        List<Credentials>deserailizeuser(string filename);
        
            
      }
}
