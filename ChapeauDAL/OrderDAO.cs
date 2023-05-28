﻿using Org.BouncyCastle.Asn1.X509;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using static ChapeauModel.Order;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {

      

       


        //read order and orders
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT tableNumber, totalPrice, orderID FROM OrderTable ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrdersTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> ReadOrdersTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["orderID"],
                    TableNumber = (int)dr["tableNumber"],
                    TotalPrice = (int)dr["totalPrice"],
                };
                orders.Add(order);
            }
            return orders;
        }

        private Order ReadOrder(SqlDataReader reader)
        {
         
            int OrderID = (int)reader["orderID"];
            int TableNumber = (int)reader["tableNumber"];
            OrderStatus orderStatus = (OrderStatus)reader["OrderStatus"];
            float TotalPrice = (float)reader["totalPrice"];
            DateTime DateTime = (DateTime)reader["OrderDateTime"];
            OrderItem Comment = (OrderItem)reader["comment"];

           return new Order(OrderID, TableNumber, orderStatus, TotalPrice,DateTime, Comment);
        } 



        //add / edit / delete orders
        public void AddOrder(Order order)
        { 
            string query = "INSERT INTO OrderTable (tableNumber, totalPrice) + VALUES (@tableNumber, @totalPrice)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", order.TableNumber),
               new SqlParameter("@totalPrice", order.TotalPrice),
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrder(Order order)
        {
            conn.Open();
            string query = "UPDATE OrderTable SET tableNumber = @tableNumber, totalPrice = @totalPrice WHERE tableNumber = @tableNumber, totalPrice = @totalPrice";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@tableNumber", order.TableNumber),
                new SqlParameter("@totalPrice", order.TotalPrice),

            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }

        public void DeleteOrder(Order order)
        {
            string query = "DELETE FROM [OrderTable] WHERE tableNumber = @tableNumber";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableNumber", order.TableNumber),
            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }

}
