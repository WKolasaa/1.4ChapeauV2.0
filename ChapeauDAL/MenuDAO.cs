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

        public List<Menu> GetMenu()
        {
            List<Menu> menuItems = new List<Menu>();

            conn.Open();
            string query = "SELECT description, price, category, sequence FROM MenuItem";
            SqlParameter[] parameter = new SqlParameter[0];

            DataTable dataTable = ExecuteSelectQuery(query, parameter);
            menuItems = ReadMenuItems(dataTable);

            conn.Close();

            return menuItems;
        }

        private List<Menu> ReadMenuItems(DataTable dataTable)
        {
            List<Menu> menu = new List<Menu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu menuItem = new Menu()
                {
                    Description = (string)dr["description"],
                    Price = (double)dr["price"],
<<<<<<< HEAD
                    Category = (string)dr["category"],
                    ItemType = ItemSequence(Convert.ToInt32(dr["sequence"])),
=======
                    Contains = (int)dr["contains"],
                    //Category = (string)dr["category"],
>>>>>>> main
                };

                menu.Add(menuItem);
            }

            return menu;
        }
<<<<<<< HEAD
=======

        private Menu ReadMenuItem(DataTable dataTable)
        {
            if (dataTable != null)
            {
                DataRow row = dataTable.Rows[0];
                Menu menuItem = new Menu()
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

>>>>>>> main
        public List<Menu> GetMenuItemByCategory(string category)
        {
            List<Menu> menuItems = new List<Menu>();
            string query = "SELECT description, price, category,sequence FROM MenuItem WHERE CHARINDEX(@category, category) > 0";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@category", category)
            };

            DataTable reader = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow row in reader.Rows)
            {
                Menu menuItem = new Menu
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

        public void AddMenuItem(Menu menu)
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

        public void UpdateMenu(Menu menu)
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

        public void DeleteMenuItem(Menu menu)
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
