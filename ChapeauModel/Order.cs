using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TableNumber { get; set; }
        public float TotalPrice { get; set; }

        Employee Employee { get; set; }

        public enum Order_Status { Ordered = 0 , Preparing = 1, Ready = 2, Delivered = 3}

        Order_Status orderStatus;
        DateTime OrderTime { get; set; }

        OrderItem Comment { get; set; }

        public Order(int orderID, int tableNumber, Order_Status order_Status, float totalPrice, DateTime dateTime, OrderItem comment)
        {
            OrderID = orderID;
            TableNumber = tableNumber;
            orderStatus = order_Status; 
            TotalPrice = totalPrice;
            // Employee = employee;
            OrderTime = dateTime;
            Comment = comment;  
        }

        public Order()
        {

        }

    }

}
