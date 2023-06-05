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
            string query = "SELECT PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments FROM OrderItems";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            string query = "SELECT * FROM [OrderItems]";
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    PricePerItem = (double)dr["PricePerItem"],
                    TableNumber = (Table)dr["tableNumber"],
                    ItemName = (string)dr["itemName"],
                    Quantity = (int)dr["Quantity"],
                    VatCategory = (bool)dr["vat_category"],
                    Comment = (string)dr["Comments"],
                };

                items.Add(item);
            }


            return items;
        }

        private OrderItem ReadOrderItem(SqlDataReader reader)
        {
            MenuDAO menuDAO = new MenuDAO();
            TableDAO tableDAO = new TableDAO();

            double PricePerItem = (double)reader["PricePerItem"];
            Table TableNumber = (Table)reader["tableNumber"];
            string ItemName = (string)reader["itemName"];
            int Quantity = (int)reader["Quantity"];
            //OrderStatus Status = (OrderStatus)reader["status"];
            bool VatCategory = (bool)reader["vat_category"];
            string Comment = (string)reader["Comments"];
            int Category = (int)reader["Cateogry"];
            Menu MenuItem = (Menu)reader["menu_item_id"];

            return new OrderItem(PricePerItem, TableNumber, ItemName, Quantity, VatCategory, Comment, Category, MenuItem);

        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Table tableNumber = orderItem.TableNumber;

            string query = "INSERT INTO [OrderItems] (PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, menu_item_id) VALUES (@PricePerItem, @tableNumber, @itemName, @Quantity, @vat_category, @Comments, @Category, @menu_item_id); ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@PricePerItem", orderItem.PricePerItem),
                new SqlParameter("@tableNumber", orderItem.TableNumber),
                new SqlParameter("@itemName", orderItem.ItemName),
                new SqlParameter("@Quantity", orderItem.Quantity),
                new SqlParameter("@vat_category", orderItem.VatCategory),
                new SqlParameter("@Comments", orderItem.Comment),
                new SqlParameter("@Category", orderItem.Category),
                new SqlParameter("@menu_item_id", orderItem.MenuItem),

            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrder(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [OrderItems] SET Quantity ={newQuantity} WHERE Quantity ={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteOrder()
        {
        }
    }



}

