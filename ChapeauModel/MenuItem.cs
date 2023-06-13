using Model;
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
        public int Contains { get; set; }
        public bool VAT_Category { get; set; }
        public MenuType Type { get; set; }
    }
}
