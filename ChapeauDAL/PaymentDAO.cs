using ChapeauModel;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Org.BouncyCastle.Utilities;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        public int StorePaymentHistory(Payment payment)
        {
            conn.Open();

            // Convert the payment methods list to a string representation
            string paymentMethodsString = string.Join(",", payment.PaymentMethods);

            // Insert into PaymentHistory table
            SqlCommand command = new SqlCommand(
                  "INSERT INTO PaymentHistory (TotalAmount, Tip, Feedback, TableNumber, PaymentMethods,PaymentData) " +
                "VALUES (@TotalAmount, @Tip, @Feedback, @TableNumber, @PaymentMethods,@PaymentData); SELECT SCOPE_IDENTITY();",
                 conn);

            // Preventing SQL injections
            command.Parameters.AddWithValue("@TotalAmount", payment.TotalAmount);
            command.Parameters.AddWithValue("@Tip", payment.Tip);
            command.Parameters.AddWithValue("@Feedback", payment.Feedback);
            command.Parameters.AddWithValue("@TableNumber", payment.TableNumber);
            command.Parameters.AddWithValue("@PaymentMethods", paymentMethodsString);
            command.Parameters.AddWithValue("@PaymentData", payment.Datetime);


            payment.PaymentHistoryID = Convert.ToInt32(command.ExecuteScalar());
            //SQL commands that don't return any result set

            conn.Close();
            return payment.PaymentHistoryID;
        }

        public Payment GetPaymentHistoryByID(int paymentHistoryId)
        {
            Payment payment = new Payment();
            conn.Open();

            SqlCommand command = new SqlCommand(
                "SELECT paymentHistoryID, TotalAmount, Tip, Feedback, TableNumber, PaymentMethods,PaymentData " +
                "FROM PaymentHistory " +
                "WHERE PaymentHistoryID = @PaymentHistoryID", conn);
            command.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryId);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                payment.PaymentHistoryID = reader.GetInt32(0);
                payment.TotalAmount = reader.GetDecimal(1);
                payment.Tip = reader.GetDecimal(2);
                payment.Feedback = reader.GetString(3);
                payment.TableNumber = reader.GetInt32(4);
                // Assuming PaymentMethods is stored as a string in the database
                payment.PaymentMethods = reader.GetString(5).Split(',')
                  // lambda parameter name that represents an individual element in the Split array.
                  .Select(method => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), method))//=> separates the parameter 
                  .ToList<PaymentMethod>();

                payment.Datetime = reader.GetDateTime(6);
            }
            conn.Close();
            return payment;
        }

        public bool GetVATStatus(OrderItem item)
        {
            conn.Open();
            SqlCommand command = new SqlCommand
           ("SELECT vat_category FROM OrderItems WHERE itemName = @itemName", conn);
            // Preventing SQL injections
            command.Parameters.AddWithValue("@itemName", item.ItemName);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    item.VatCategory = reader.GetBoolean(0);// 0 means the first column 
                }
            }
            conn.Close();
            return item.VatCategory;
        }

        public List<OrderItem> GetItemsByTableNumber(int tableNumber)
        {
            List<OrderItem> items = new List<OrderItem>();
            conn.Open();
            SqlCommand command = new SqlCommand(
              "SELECT tableNumber, PricePerItem, itemName, Quantity, Comments, vat_category FROM OrderItems WHERE tableNumber = @tableNumber", conn);
            command.Parameters.AddWithValue("@tableNumber", tableNumber);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    OrderItem item = new OrderItem()
                    {
                        TableNumber = reader.GetInt32(0),
                        PricePerItem = reader.GetDecimal(1),
                        ItemName = reader.GetString(2),
                        Quantity = reader.GetInt32(3),
                        //DBNull is a .NET framework type that represents a missing or nonexistent value.
                        Comment = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        VatCategory = reader.GetBoolean(5),

                    };
                    items.Add(item);
                }
            }
            conn.Close();
            return items;
        }

        public DataTable Income(DateTime startDate, DateTime endDate) // Manager part to display today's income 
        {
            string query = "SELECT TotalAmount FROM PaymentHistory WHERE PaymentData >= @startDate AND PaymentData <= @endDate";

            SqlParameter[] parameter =
            {
                new SqlParameter("startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };

            DataTable table = ExecuteSelectQuery(query, parameter);

            return table;
        }
    }
}
