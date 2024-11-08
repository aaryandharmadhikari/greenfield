using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    //Prototype,contract ,specification, etc
    public interface ICustomerService 
    {
        List<Customer> GetAll();

        Customer Get(int id);

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
        // Customer Update(Customer customer)
    }
}
