using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderServices:IOrderService
    {

        private List<Order> _orderList;
        public OrderServices()
        {
            _orderList = new List<Order>();
        }

        public bool Delete(int id)
        {
            Order theorder = this.Get(id);
            return this._orderList.Remove(theorder);
           
        }

        public Order Get(int id)
        {
            foreach ( Order orders in _orderList)
            {
                if (orders.OrderId == id) return orders;
            }
            return null;
        }

        public List<Order> GetAll()
        {
            return this._orderList;
        }

        

        public bool Insert(Order order)
        {
            this._orderList.Add(order);
            return true;
        }

        public bool Update(Order order)
        {
            Order order1 = this.Get(order.OrderId);
            this._orderList.Remove(order1);
            this._orderList.Add(order);
            return true;
            
        }


        
    }

}
