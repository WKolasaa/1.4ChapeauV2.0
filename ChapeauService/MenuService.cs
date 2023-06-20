using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class MenuService
    {
        private MenuDAO menudb;
        public MenuService()
        {
            menudb = new MenuDAO();
        }

        public List<MenuItem> GetMenu()
        {
            return menudb.GetMenu();
        }

        public void AddMenu(MenuItem menu)
        { 
            menudb.AddMenuItem(menu);
        }

        public void RemoveMenu(MenuItem menu)
        {
            menudb.DeleteMenuItem(menu);
        }
        public void UpdateMenu(MenuItem menu)
        {
            menudb.UpdateMenu(menu);
        }
        public List<MenuItem> GetMenuByCategory(int category)
        {
            return menudb.GetMenuItemByCategory(category);
        }
    }
}
