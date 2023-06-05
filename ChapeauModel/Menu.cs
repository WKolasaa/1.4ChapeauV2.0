using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{ 
    public class Menu
    {
        public int MenuItemID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Contains { get; set; }
        public bool VAT_Category { get; set; }

        public string Category { get; set; }

        public string ItemType { get; set; }

        public Menu(int menuItemID, string description, double price, int contains, bool vAT_Category, string category, string itemType)
        {
            MenuItemID = menuItemID;
            Description = description;
            Price = price;
            Contains = contains;
            VAT_Category = vAT_Category;
            Category = category;
            ItemType = itemType;
        }

        public Menu() { }
    }
}
