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
        private TableDAO tabledao;

        public OrderItemService()
        {
            orderitemdao = new OrderItemDAO();
        }

        public List<OrderItem> GetOrderItems()
        {
            return orderitemdao.GetAllItems();
        }

        public void AddOrderItem(OrderItem order)
        {
            orderitemdao.AddOrderItem(order);
        }

        public void UpdateOrderItemStatus(OrderItem orderitem, int orderStatus)
        {
            orderitemdao.UpdateOrderItemStatus(orderitem, orderStatus);
        }

        public void UpdateOrderItemState(OrderItem orderItem, OrderStatus status)
        {
            orderitemdao.UpdateOrderStatus(orderItem,status);
        }
      
        public List<OrderItem> GetFoodStatusByTableId(int tableId)
        {
            return orderitemdao.GetFoodStatusByTableId(tableId);
        }

        public List<OrderItem> GetDrinkStatusByTableId(int tableId)
        {
            return orderitemdao.GetDrinkStatusByTableId(tableId);
        }


        public List<OrderItem> GetAllDrinks()
        {
            return orderitemdao.GetAllDrinks();
        }

        public List<OrderItem> GetOrderStatusByTable(int taleId)
        {
            return orderitemdao.GetOrderStatusByTableId(taleId);
        }

        public List<OrderItem> GetOrderItemsByTable(int taleId)
        {
            return orderitemdao.GetOrderItemsByTableId(taleId);
        }

        public bool CheckIfTableHasActiveOrders(Table table)
        {
            return orderitemdao.CheckIfTableHasOrderItems(table);
        }


        public List<OrderItem> GetAllFood()
        {
            return orderitemdao.GetAllFood();
        }

        /*  public void RemoveMenu(Menu menu)
          {
              orderitemdao.DeleteMenuItem(menu);
          }
          public void UpdateMenu(Menu menu)
          {
              orderitemdao.UpdateMenu(menu);
          } */

    }
}
