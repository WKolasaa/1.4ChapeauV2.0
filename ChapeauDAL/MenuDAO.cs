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
        // ...

        public List<MenuItem> GetMenu()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            conn.Open();
            string query = "SELECT description, price, category, sequence FROM MenuItem";
            SqlParameter[] parameter = new SqlParameter[0];

            DataTable dataTable = ExecuteSelectQuery(query, parameter);
            menuItems = ReadMenuItems(dataTable);

            conn.Close();

            return menuItems;
        }

        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Description = (string)dr["description"],
                    Price = (double)dr["price"],

                    Category = (string)dr["category"],
                    ItemType = ItemSequence(Convert.ToInt32(dr["sequence"])),

                    // Contains = (int)dr["contains"],
                    // Category = (string)dr["category"],
                };

                menu.Add(menuItem);
            }

            return menu;
        }
        private MenuItem ReadMenuItem(DataTable dataTable)
        {
            if (dataTable != null)
            {
                DataRow row = dataTable.Rows[0];
                MenuItem menuItem = new MenuItem()
                {
                    Description = (string)row["description"],
                    Price = (double)row["price"],
                    Contains = (int)row["contains"],
                    //Category = (string)row["category"],
                };
                return menuItem;
            }

            return null;
        }

        public List<MenuItem> GetMenuItemByCategory(string category)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            string query = "SELECT description, price, category,sequence FROM MenuItem WHERE CHARINDEX(@category, category) > 0";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@category", category)
            };

            DataTable reader = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow row in reader.Rows)
            {
                MenuItem menuItem = new MenuItem
                {
                    Description = row["description"].ToString(),
                    Price = Convert.ToSingle(row["price"]),
                    Category = row["category"].ToString(),
                    ItemType = ItemSequence(Convert.ToInt32(row["sequence"])),
                };

                menuItems.Add(menuItem);
            }

            return menuItems;
        }
        private string ItemSequence(int sequence)//Remember to change its place 
        {
            switch (sequence)
            {
                case 1:
                    return "Starter";
                case 2:
                    return "Main";
                case 3:
                    return "Dessert";
                default:
                    return "Unknown";
            }
        }

        // ...

        public void AddMenuItem(MenuItem menu)
        {
            conn.Open();
            string query = "INSERT INTO MenuItem (menuItemID, description, price) VALUES (@menuItemID, @description, @price)";

            SqlParameter[] parameter = new SqlParameter[]
            {
            new SqlParameter("@menuItemID", menu.MenuItemID),
            new SqlParameter("@description", menu.Description),
            new SqlParameter("@price", menu.Price)
            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }

        public void UpdateMenu(MenuItem menu)
        {
            conn.Open();
            string query = "UPDATE MenuItem SET description = @description, price = @price WHERE menuItemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
            new SqlParameter("@itemID", menu.MenuItemID),
            new SqlParameter("@description", menu.Description),
            new SqlParameter("@price", menu.Price)
            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }

        public void DeleteMenuItem(MenuItem menu)
        {
            conn.Open();
            string query = "DELETE FROM MenuItem WHERE menuItemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
            new SqlParameter("@itemID", menu.MenuItemID)
            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }
    }




}
