using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;

namespace ChapeauDAL
{
    public class MenuDAO : BaseDao
    {
        public List<MenuItem> GetMenu()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            string query = "SELECT menuItemID, description, price, course_type, vat_category FROM MenuItem";

            DataTable dataTable = ExecuteSelectQuery(query);
            menuItems = ReadMenuItems(dataTable);

            return menuItems;
        }

        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemID = (int)dr["menuItemID"],
                    Description = (string)dr["description"],
                    Price = (double)dr["price"],
                    ItemType = (ItemCategory)dr["course_type"],
                    VAT_Category = (bool)dr["vat_category"]
                };

                menu.Add(menuItem);
            }

            return menu;
        }

        public List<MenuItem> GetMenuItemByCategory(int category)
        {
            string query = "SELECT menuItemID, description, price, course_type, vat_category FROM MenuItem WHERE course_type = @course_type";

            SqlParameter[] sqlParameters = 
            {
               new SqlParameter("course_type", category)
            };

            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddMenuItem(MenuItem menu)
        {
            string query = "INSERT INTO MenuItem (menuItemID, description, price, vat_category, course_type) VALUES (@menuItemID, @description, @price, @vat_category, @course_type)";

            SqlParameter[] parameter =
            {
                new SqlParameter("@menuItemID", menu.MenuItemID),
                new SqlParameter("@description", menu.Description),
                new SqlParameter("@price", menu.Price),
                new SqlParameter("@vat_category", menu.VAT_Category),
                new SqlParameter("@course_type", (int)menu.ItemType)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void UpdateMenu(MenuItem menu)
        {
            string query = "UPDATE MenuItem SET description = @description, price = @price, vat_category = @vat_category, course_type = @course_type WHERE menuItemID = @itemID";
            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", menu.MenuItemID),
                new SqlParameter("@description", menu.Description),
                new SqlParameter("@price", menu.Price),
                new SqlParameter("@vat_category", menu.VAT_Category),
                new SqlParameter("@course_type", (int)menu.ItemType)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void DeleteMenuItem(MenuItem menu)
        {
            string query = "DELETE FROM MenuItem WHERE menuItemID = @itemID";
            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", menu.MenuItemID)
            };

            ExecuteEditQuery(query, parameter);
        }
    }




}
