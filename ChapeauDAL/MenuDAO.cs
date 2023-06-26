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
        public List<MenuItem> GetMenu(string sort)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            string query = "SELECT menuItemID, description, price, course_type, vat_category, quantity FROM MenuItemTable ORDER BY CASE WHEN @sort ='ID' THEN menuItemID WHEN @sort = 'VatCategory' THEN vat_category WHEN @sort = 'Price' THEN price WHEN @sort = 'CourseType' THEN course_type WHEN @sort = 'Quantity' THEN quantity WHEN @sort = 'Description' THEN CONVERT(varchar(4000), description) END ASC"; // TODO manage parameter

            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@sort", sort)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameter);
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
                    VAT_Category = (bool)dr["vat_category"],
                    Quantity = (int)dr["quantity"]
                };

                menu.Add(menuItem);
            }

            return menu;
        }

        public List<MenuItem> GetMenuItemByCategory(int category)
        {
            string query = "SELECT menuItemID, description, price, course_type, vat_category, quantity FROM MenuItemTable WHERE course_type = @course_type";

            SqlParameter[] sqlParameters = 
            {
               new SqlParameter("course_type", category)
            };

            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddMenuItem(MenuItem menu)
        {
            string query = "INSERT INTO MenuItemTable (description, price, vat_category, course_type, quantity) VALUES (@description, @price, @vat_category, @course_type, @quantity)";

            SqlParameter[] parameter =
            {
                new SqlParameter("@description", menu.Description),
                new SqlParameter("@price", menu.Price),
                new SqlParameter("@vat_category", menu.VAT_Category),
                new SqlParameter("@course_type", (int)menu.ItemType),
                new SqlParameter("@quantity", menu.Quantity)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void UpdateMenu(MenuItem menu)
        {
            string query = "UPDATE MenuItemTable SET description = @description, price = @price, vat_category = @vat_category, course_type = @course_type, quantity = @quantity WHERE menuItemID = @itemID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", menu.MenuItemID),
                new SqlParameter("@description", menu.Description),
                new SqlParameter("@price", menu.Price),
                new SqlParameter("@vat_category", menu.VAT_Category),
                new SqlParameter("@course_type", (int)menu.ItemType),
                new SqlParameter("@quantity", menu.Quantity)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void DeleteMenuItem(MenuItem menu)
        {
            string query = "DELETE FROM MenuItemTable WHERE menuItemID = @itemID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", menu.MenuItemID)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void MenuItemOrdered(MenuItem item)
        {
            string query = "UPDATE MenuItemTable SET quantity = @quantity WHERE menuItemID = @itemID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@quantity", item.Quantity),
                new SqlParameter("itemID", item.MenuItemID)
            };

            ExecuteEditQuery(query, parameter);
        }
    }




}
