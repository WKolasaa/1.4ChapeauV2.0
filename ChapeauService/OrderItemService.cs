﻿using ChapeauDAL;
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

        public void AddOrderItem(Menu menu)
        {
            
        }

        public void UpdateOrderItemStatus(OrderItem orderitem, int orderStatus)
        {
            orderitemdao.UpdateOrderItemStatus(orderitem, orderStatus);
        }

        public List<OrderItem> GetAllDrinks()
        {
            return orderitemdao.GetAllDrinks();
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
