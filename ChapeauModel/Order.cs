using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public partial class Order
    {
        public List<OrderItem> OrderedItems { get; set; }   
        public int OrderID { get; set; } // refer to order
        public Table TableNumber { get; set; } 
        public float TotalPrice { get; set; }
        public Employee Employee { get; set; }
        
        public OrderStatus Status { get; set; }
        public DateTime OrderTime { get; set; }

        public OrderItem Comment { get; set; }

        public Order(int orderID, Table tableNumber, Employee employee, OrderStatus order_Status, float totalPrice, DateTime dateTime, OrderItem comment)
        {
            OrderID = orderID;
            TableNumber = tableNumber;
            Employee = employee;
            Status = order_Status;
            TotalPrice = totalPrice;
            OrderTime = dateTime;
            Comment = comment;  
        }

        public Order()
        {
            OrderedItems = new List<OrderItem>();   
        }

    }

}
