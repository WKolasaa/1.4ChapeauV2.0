using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool VAT_Category { get; set; }
        public ItemCategory ItemType { get; set; }   
        public int Quantity { get; set; }

        public MenuItem(int menuItemID, string description, double price, int contains, bool vAT_Category, ItemCategory itemType, int quantity)
        {
            MenuItemID = menuItemID;
            Description = description;
            Price = price;
            VAT_Category = vAT_Category;
            ItemType = itemType;
            Quantity = quantity;
        }   

        public MenuItem() { }
    }
}
