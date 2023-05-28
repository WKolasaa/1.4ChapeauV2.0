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
        public List<Menu> GetMenu()
        {
            conn.Open();
            string query = "SELECT description, price, contains, category FROM MenuItem";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadMenuItems(ExecuteSelectQuery(query, parameter));
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
                    Contains = (int)dr["contains"],
                    Category = (string)dr["category"],
                };

                menu.Add(menuItem);
            }

            return menu;
        }

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
                    Category = (string)row["category"],
                };
                return menuItem;    
            }

            return null;
        }

        public Menu GetMenuItemByCategory(string category)
        {
            string query = "SELECT description, price, category FROM MenuItem WHERE category = @category";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("category", category)
            };

            DataTable reader = ExecuteSelectQuery(query, sqlParameters);
            Menu menuItem = ReadMenuItem(reader);
            return menuItem;
        }

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

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void UpdateMenu(Menu menu)
        {
            conn.Open();
            string query = "UPDATE MenuItem SET menuItemID = @itemID, description = @itemName, price = @quantity WHERE menuItemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", menu.MenuItemID),
                new SqlParameter("@itemName", menu.Description),
                new SqlParameter("@quantity", menu.Price)
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
