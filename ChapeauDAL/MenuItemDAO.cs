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
    public class MenuItemDAO : BaseDao
    {
        public List<MenuItem> GetMenuItem()
        {
            conn.Open();
            string query = "SELECT menuItemID, description, price FROM MenuItem";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadMenuItem(ExecuteSelectQuery(query, parameter));
        }

        private List<MenuItem> ReadMenuItem(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemID = (int)dr["menuItemID"],
                    Description = (string)dr["description"],
                    Price = (double)dr["price"]
                };

                menuItems.Add(menuItem);
            }

            return menuItems;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            conn.Open();
            string query = "INSERT INTO MenuItem (menuItemID, description, price) VALUES (@menuItemID, @description, @price)";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@menuItemID", menuItem.MenuItemID),
                new SqlParameter("@description", menuItem.Description),
                new SqlParameter("@price", menuItem.Price)
            };

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            conn.Open();
            string query = "UPDATE MenuItem SET menuItemID = @itemID, description = @itemName, price = @quantity WHERE menuItemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", menuItem.MenuItemID),
                new SqlParameter("@itemName", menuItem.Description),
                new SqlParameter("@quantity", menuItem.Price)
            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            conn.Open();
            string query = "DELETE FROM MenuItem WHERE menuItemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", menuItem.MenuItemID)
            };
            ExecuteEditQuery(query, parameter);
            conn.Close();
        }
    }
}
