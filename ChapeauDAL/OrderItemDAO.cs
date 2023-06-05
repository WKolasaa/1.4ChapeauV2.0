using ChapeauModel;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class OrderItemDAO : BaseDao
    {
        public List<OrderItem> GetAllItems()
        {
            string query = "SELECT PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category FROM OrderItems";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    PricePerItem = (decimal)dr["PricePerItem"],
                    TableNumber = (int)dr["tableNumber"],
                    ItemName = (string)dr["itemName"],
                    Quantity = (int)dr["Quantity"],
                    VatCategory = (bool)dr["vat_category"],
                    Comment = (string)dr["Comments"],
                    ItemCategroy = (ItemCategory)(int)dr["Category"]
                };

                items.Add(item);
            }

            return items;
        }

        /*private OrderItem ReadOrderItem(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                OrderItem item = new OrderItem()
                {
                    PricePerItem = (double)row["PricePerItem"],
                    TableNumber = (int)row["tableNumber"],
                    ItemName = (string)row["itemName"],
                    Quantity = (int)row["Quantity"],
                    VatCategory = (bool)row["vat_category"],
                    Comment = (string)row["Comments"],
                };

                return item;
            }

            return null;
        }
        */

        public List<OrderItem> GetAllFood()
        {
            string query = "SELECT PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category FROM OrderItems WHERE Category = 0";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetAllDrinks()
        {
            string query = "SELECT PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category FROM OrderItems WHERE Category = 1";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public void AddOrder()
        {
            string query = "INSERT INTO OrderItem ([PricePerItem], [tableNumber], [itemName], [Quantity], [vat_category], [Comments]) VALUES (@PricePerItem, @tableNumber, @itemName, @Quantity, @vat_category, @Comments)";
            SqlParameter[] sql = new SqlParameter[0];
            ExecuteEditQuery(query, sql);
        }

        public void EditOrder()
        {

        }

        public void DeleteOrder()
        {
        }
    }





}

