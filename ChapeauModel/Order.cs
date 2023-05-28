using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public int TableNumber { get; set; }
        public float TotalPrice { get; set; }

        Employee Employee { get; set; }
        
        public OrderStatus Status { get; set; }
        DateTime OrderTime { get; set; }

        OrderItem Comment { get; set; }

        public Order(int orderID, int tableNumber, OrderStatus order_Status, float totalPrice, DateTime dateTime, OrderItem comment)
        {
            OrderID = orderID;
            TableNumber = tableNumber;
            Status = order_Status;
            TotalPrice = totalPrice;
            OrderTime = dateTime;
            Comment = comment;  
        }

        public Order()
        {

        }

    }

}
