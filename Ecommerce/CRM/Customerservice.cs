using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
   public class Customerservice:ICustomerService
    {
        private List<Customer> _customerList;
        public Customerservice()
        {
            this._customerList = new List<Customer>();
        }

        public bool Delete(int id)
        {
            Customer theCustomer = this.Get(id);
            return this._customerList.Remove(theCustomer);
            //throw new NotImplemented Exception()
        }

        public Customer Get(int id)
        {
            foreach(Customer customer in _customerList)
            {
                if (customer.Id == id) return customer;
            }
            return null;
            //throw new NotImplemented Exception()
        }

        public List<Customer> GetAll()
        {
            return this._customerList;
            //throw new NotImplemented Exception()
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);
            return true;    
            //throw new NotImplemented Exception()
        }

        public bool Update(Customer customer) 
        {
            Customer theCustomer = this.Get(customer.Id);
            this._customerList.Remove(theCustomer);
            this._customerList.Add(customer);
            return true;
            //throw newNotImplemented Exception()
        }

    }
}
