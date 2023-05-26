using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }

        public List<Order> GetOrder()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }

        public void AddOrder(Order order)
        {
            orderdb.AddOrder(order);
        }

        public void RemoveOrder(Order order)
        {
            orderdb.DeleteOrder(order);
        }
        public void UpdateOrder(Order order)
        {
            orderdb.UpdateOrder(order);
        }

    }
}
