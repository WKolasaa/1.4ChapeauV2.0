using ChapeauModel;
using Org.BouncyCastle.Asn1.X509;
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
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category FROM OrderItems";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }
        public List<OrderItem> GetOrderStatusByTableId(int tableId)
        {
            string query = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@tableNumber", tableId) };
            return ReadOrderStatus(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetOrderItemsByTableId(int tableId)
        {
            string query = "SELECT OrderItemID, OrderStatus ,PricePerItem, TableNumber, itemName, Quantity, vat_category, Comments FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@tableNumber", tableId) };
            return ReadOrderItemsbyId(ExecuteSelectQuery(query, sp));

        }
        public bool CheckIfTableHasOrderItems(Table table)
        {
            string query = "SELECT OrderItemID FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tableNumber", table.TableId)
            };

            DataTable result = ExecuteSelectQuery(query, parameters);

            return result.Rows.Count > 0; // Return true if there are order items, false otherwise
        }






        private List<OrderItem> ReadOrderStatus(DataTable dataTable)
        {
            List<OrderItem> orderItemList = new List<OrderItem>();

            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.OrderItemID = Convert.ToInt32(row["OrderItemID"]);
                orderItem.Status = (OrderStatus)(int)row["OrderStatus"];
                orderItemList.Add(orderItem);
            }

            return orderItemList;
        }
        private List<OrderItem> ReadOrderItemsbyId(DataTable dataTable)
        {
            List<OrderItem> orderItemList = new List<OrderItem>();

            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.ItemName = (string)row["itemName"];
                orderItem.Quantity = (int)row["Quantity"];
                orderItem.PricePerItem = (decimal)row["PricePerItem"];
                orderItem.Status = (OrderStatus)(int)row["OrderStatus"];
                orderItem.Comment = (string)row["Comments"];
                orderItemList.Add(orderItem);
            }

            return orderItemList;
        }
        public List<OrderItem> GetFoodStatusByTableId(int tableId)
        {
            string foodQuery = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE Category = '0' AND TableNumber = @tableNumber";
            SqlParameter[] foodParameters = { new SqlParameter("@tableNumber", tableId) };
            DataTable foodDataTable = ExecuteSelectQuery(foodQuery, foodParameters);
            return ReadOrderStatus(foodDataTable);
        }

        public List<OrderItem> GetDrinkStatusByTableId(int tableId)
        {
            string drinkQuery = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE Category = '1' AND TableNumber = @tableNumber";
            SqlParameter[] drinkParameters = { new SqlParameter("@tableNumber", tableId) };
            DataTable drinkDataTable = ExecuteSelectQuery(drinkQuery, drinkParameters);
            return ReadOrderStatus(drinkDataTable);
        }





        public List<OrderItem> GetAllFood()
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = 0";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetAllDrinks()
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = 1";
            SqlParameter[] sp = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }
        public List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            //string query = "SELECT * FROM [OrderItems]";
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    OrderItemID = (int)dr["OrderItemID"],
                    PricePerItem = (decimal)dr["PricePerItem"],
                    TableNumber = (int)dr["tableNumber"],
                    ItemName = (string)dr["itemName"],
                    Quantity = (int)dr["Quantity"],
                    VatCategory = (bool)dr["vat_category"],
                    Comment = (string)dr["Comments"],
                    Category = (int)dr["Category"],
                    //MenuItem = (Menu)dr["menu_item_id"], 
                    Status = (dr["OrderStatus"] != DBNull.Value) ? (OrderStatus)dr["OrderStatus"] : OrderStatus.Ordered,
                    TimePlaced = (dr["TimePlaced"] != DBNull.Value) ? (DateTime)dr["TimePlaced"] : DateTime.Now
                };

                items.Add(item);
            }


            return items;
        }

        /*private OrderItem ReadOrderItem(SqlDataReader reader)
        {
            MenuDAO menuDAO = new MenuDAO();
            TableDAO tableDAO = new TableDAO();

            decimal PricePerItem = (decimal)reader["PricePerItem"];
            int TableNumber = (int)reader["tableNumber"];
            string ItemName = (string)reader["itemName"];
            int Quantity = (int)reader["Quantity"];
            OrderStatus Status = (OrderStatus)reader["OrderStatus"];
            bool VatCategory = (bool)reader["vat_category"];
            string Comment = (string)reader["Comments"];
            int Category = (int)reader["Category"];
            Menu MenuItem = (Menu)reader["menu_item_id"];

            return new OrderItem(PricePerItem, TableNumber, ItemName, Quantity, VatCategory, Comment, Category, MenuItem);

        }
        */
   
        public void AddOrderItem(OrderItem orderItem)
        {
            int tableNumber = orderItem.TableNumber;

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

        public void UpdateOrderItemStatus(OrderItem orderItem, int orderStatus)
        {

            string query = "UPDATE OrderItems SET OrderStatus = @orderStatus WHERE OrderItemID = @orderItemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@orderStatus", orderStatus),
                new SqlParameter("@orderItemID", orderItem.OrderItemID)
                
            };

            ExecuteEditQuery(query, parameter);
        }

        public void UpdateOrderStatus(OrderItem orderItem, OrderStatus status)
        {
            string query = "UPDATE OrderItems SET OrderStatus = @orderStatus WHERE OrderItemID = @orderItemID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@orderStatus", (int)status),
                new SqlParameter("@orderItemID", orderItem.OrderItemID)
            };
            ExecuteEditQuery(query, parameters);
        }


        public void DeleteOrder()
        {
        }
    }



}

