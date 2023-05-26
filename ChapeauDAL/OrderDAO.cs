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

        public void GetOrder()
        {
            string query = "SELECT orderID, tableNumber, totalPrice, paymentID, contains FROM Order ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            // return ReadOrdersTable(ExecuteSelectQuery(query, sqlParameters));
        }

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

        public void AddOrder(Order order, Menu item)
        {
            string query = "INSERT INTO OrderTable () + VALUES (@description)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@description", item.Description),
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditOrder(Order order)
        {
        }

        public void DeleteOrder(Order order, Menu item)
        {
            string query = "DELETE FROM [Order] WHERE orderID = @orderID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@description", item.Description),
            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }

}
