using Pokolib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification

{
    public interface IDataRepository<T>
    {
        bool Serialize<T>(string filename, List<T> products);
        List<T> Deserialize<T>(string filename);
    }


        /*  bool serializeuser(string filename, List<Credentials> credentials);
          List<Credentials>deserailizeuser(string filename);*/

}

