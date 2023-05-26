using Org.BouncyCastle.Asn1.X509;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT orderID, tableNumber, totalPrice, paymentID, contains FROM Order ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrdersTable(ExecuteSelectQuery(query, sqlParameters));
        }

        /* public void GetOrder()
         {
             string query = "SELECT orderID, tableNumber, totalPrice, paymentID, contains FROM Order ";
             SqlParameter[] sqlParameters = new SqlParameter[0];
             // return ReadOrdersTable(ExecuteSelectQuery(query, sqlParameters));
         } */

        private List<Order> ReadOrdersTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    // OrderID = (int)dr["orderID"],
                    TableNumber = (int)dr["tableNumber"],
                    TotalPrice = (int)dr["totalPrice"],
                    // PaymentID = (int)dr[""],
                    // Contains = (int)dr["contains"],
                };
                orders.Add(order);
            }
            return orders;
        }

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
