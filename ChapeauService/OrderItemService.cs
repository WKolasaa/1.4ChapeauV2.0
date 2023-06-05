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
        
        public List<OrderItem> GetAllFood()
        {
            List<OrderItem> orderItems= new List<OrderItem>();

            foreach (OrderItem orderItem in GetOrderItems())
            {
                if (orderItem.ItemCategroy == ItemCategory.Food)
                {
                    orderItems.Add(orderItem);
                }
            }
            return orderItems;
        }

        public List<OrderItem> GetAllDrinks()
        {
            List<OrderItem> allDrinks = orderitemdao.GetAllDrinks();

            //orderItems = GetAllDrinks();
            /*foreach (OrderItem orderItem in GetAllDrinks())
            {
                if (orderItem.ItemCategroy == ItemCategory.Drink)
                {
                    orderItems.Add(orderItem);
                }
            }*/
            return allDrinks;
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
