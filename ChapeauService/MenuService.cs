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

        public List<Menu> GetMenu()
        {
            return menudb.GetMenu();
        }

        public void AddMenu(Menu menu)
        {
            menudb.AddMenuItem(menu);
        }

        public void RemoveMenu(Menu menu)
        {
            menudb.DeleteMenuItem(menu);
        }
        public void UpdateMenu(Menu menu)
        {
            menudb.UpdateMenu(menu);
        }
    }
}
