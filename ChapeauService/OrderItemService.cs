using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class OrderItemService
    {
        private OrderItemDAO orderitemdao;
        public OrderItemService()
        {
           orderitemdao = new OrderItemDAO();
        }

        public List<OrderItem> GetOrderItems()
        {
            return orderitemdao.GetAllItems();
        }

      /*  public void AddMenu(Menu menu)
        {
            orderitemdao.(menu);
        }

        public void RemoveMenu(Menu menu)
        {
            menudb.DeleteMenuItem(menu);
        }
        public void UpdateMenu(Menu menu)
        {
            menudb.UpdateMenu(menu);
        } */
    }
}
