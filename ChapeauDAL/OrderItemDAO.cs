﻿using ChapeauModel;
using Org.BouncyCastle.Asn1.X509;
using SomerenDAL;
using System;
using System.Collections;
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
            SqlParameter sp = new SqlParameter();
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }
        public List<OrderItem> GetOrderStatusByTableId(int tableId)
        {
            string query = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter sp = new SqlParameter("@tableNumber", tableId);
            return ReadOrderStatus(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetOrderItemsByTableId(int tableId)
        {
            string query = "SELECT OrderItemID, OrderStatus ,PricePerItem, TableNumber, itemName, Quantity, vat_category, Comments, TimePlaced FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter sp = new SqlParameter("@tableNumber", tableId);
            return ReadOrderItemsbyId(ExecuteSelectQuery(query, sp));

        }
        
        public bool CheckIfTableHasOrderItems(Table table)
        {
            string query = "SELECT OrderItemID FROM OrderItems WHERE TableNumber = @tableNumber";
            SqlParameter parameters = new SqlParameter("@tableNumber", table.TableId);

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
                orderItem.OrderItemID = (int)row["OrderItemID"];
                orderItem.ItemName = (string)row["itemName"];
                orderItem.Quantity = (int)row["Quantity"];
                orderItem.PricePerItem = (decimal)row["PricePerItem"];
                orderItem.Status = (OrderStatus)(int)row["OrderStatus"];
                orderItem.Comment = (string)row["Comments"];
                orderItem.TimePlaced = (DateTime)row["TimePlaced"];
                orderItemList.Add(orderItem);
            }

            return orderItemList;
        }
        public List<OrderItem> GetFoodStatusByTableId(int tableId)
        {
            string foodQuery = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE Category = '0' AND TableNumber = @tableNumber";
            SqlParameter foodParameter = new SqlParameter("@tableNumber", SqlDbType.Int) { Value = tableId };
            DataTable foodDataTable = ExecuteSelectQuery(foodQuery, foodParameter);
            return ReadOrderStatus(foodDataTable);
        }

        public List<OrderItem> GetDrinkStatusByTableId(int tableId)
        {
            string drinkQuery = "SELECT OrderItemID, OrderStatus FROM OrderItems WHERE Category = '1' AND TableNumber = @tableNumber";
            SqlParameter drinkParameter = new SqlParameter("@tableNumber", SqlDbType.Int) { Value = tableId };
            DataTable drinkDataTable = ExecuteSelectQuery(drinkQuery, drinkParameter);
            return ReadOrderStatus(drinkDataTable);
        }

        public List<OrderItem> GetTodaysOrderItems(DateTime todaysDate, int category) // add category
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE CAST(TimePlaced AS DATE) = @timePlaced AND Category = @category";
            SqlParameter spCategory = new SqlParameter("@category", category);
            SqlParameter spTimePlaced = new SqlParameter("@timePlaced", todaysDate.Date);
            return ReadOrderItems(ExecuteSelectQuery(query, spTimePlaced, spCategory));
        }

        public List<OrderItem> GetOrderItemsByCategory(int category)
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = @category";
            SqlParameter sp = new SqlParameter("@category", category);
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetOrderItemsByStatusAndCategory(int category)
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = @category AND OrderStatus = @orderStatus";
            SqlParameter sp = new SqlParameter("@category", category);
            return ReadOrderItems(ExecuteSelectQuery(query, sp));
        }

        public List<OrderItem> GetOrdersWithCategoryWithoutStatusLower(int category, OrderStatus status)
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = @category AND OrderStatus < @orderStatus";
            SqlParameter spCategory = new SqlParameter("@category", category);
            SqlParameter spStatus = new SqlParameter("@orderStatus", (int)status);
            return ReadOrderItems(ExecuteSelectQuery(query, spCategory, spStatus));
        }

        public List<OrderItem> GetOrdersWithCategoryWithoutStatusHigher(int category, OrderStatus status)
        {
            string query = "SELECT OrderItemID, PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, OrderStatus, TimePlaced FROM OrderItems WHERE Category = @category AND OrderStatus > @orderStatus";
            SqlParameter spCategory = new SqlParameter("@category", category);
            SqlParameter spStatus = new SqlParameter("@orderStatus", (int)status);
            return ReadOrderItems(ExecuteSelectQuery(query, spCategory, spStatus));
        }

        public List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
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
                    Status = (dr["OrderStatus"] != DBNull.Value) ? (OrderStatus)dr["OrderStatus"] : OrderStatus.Ordered,
                    TimePlaced = (dr["TimePlaced"] != DBNull.Value) ? (DateTime)dr["TimePlaced"] : DateTime.Now
                };

                items.Add(item);
            }


            return items;
        }
   
        public void AddOrderItem(OrderItem orderItem)
        {
            string query = "INSERT INTO [OrderItems] (PricePerItem, tableNumber, itemName, Quantity, vat_category, Comments, Category, menuItemId, TimePlaced, OrderStatus, ItemStatus) VALUES (@PricePerItem, @tableNumber, @itemName, @Quantity, @vat_category, @Comments, @Category, @menu_item_id, @TimePlaced, @OrderStatus, @ItemStatus);";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@PricePerItem", orderItem.PricePerItem),
                new SqlParameter("@tableNumber", orderItem.TableNumber),
                new SqlParameter("@itemName", orderItem.ItemName),
                new SqlParameter("@Quantity", orderItem.Quantity),
                new SqlParameter("@vat_category", orderItem.VatCategory),
                new SqlParameter("@Comments", orderItem.Comment),
                new SqlParameter("@Category", orderItem.Category),
                new SqlParameter("@menu_item_id", orderItem.MenuItem.MenuItemID),
                new SqlParameter("@TimePlaced", orderItem.TimePlaced),
                new SqlParameter("@OrderStatus", orderItem.Status),
                new SqlParameter("@ItemStatus", 1)

            };

            ExecuteEditQuery(query, sqlParameters);
        }

        /*
        public void UpdateOrder(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [OrderItems] SET Quantity ={newQuantity} WHERE Quantity ={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }*/

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

