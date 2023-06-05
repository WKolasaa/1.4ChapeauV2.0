using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public decimal PricePerItem { get; set; }
        public int TableNumber { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public bool VatCategory { get; set; }

        public ItemCategory ItemCategroy { get; set; }

        public string Comment { get; set; } 

        public Menu MenuItem { get; set; }

        public Order OrderStatus { get; set; }  

        public OrderItem() { }  
    }
}
