using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChapeauModel.Order;

namespace ChapeauModel
{
    public class OrderItem 
    {
        public int OrderItemID { get; set; }

        public decimal PricePerItem { get; set; }
        public int TableNumber { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public OrderStatus Status { get; set; }

        public bool VatCategory { get; set; }

        public string Comment { get; set; }

        public int Category { get; set; }
        public Menu MenuItem { get; set; }

        public OrderItem() { }

        public OrderItem(decimal price, int table, string name, int quantity, bool vatCategory, string comment, int category, Menu menuItem)
        {
            PricePerItem = price;
            TableNumber = table;
            ItemName = name;
            Quantity = quantity;
            // Status = status;
            VatCategory = vatCategory;
            Comment = comment;
            Category = category;
            MenuItem = menuItem;
        }
    }
}
