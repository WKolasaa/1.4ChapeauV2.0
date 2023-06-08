using ChapeauModel;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
         public int PaymentHistory(Payment payment)
         {
            conn.Open();
            int paymentHistoryID;

            // Insert into PaymentHistory table
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO PaymentHistory (TotalAmount, Tip, Feedback, TableNumber) " +
                "VALUES (@TotalAmount, @Tip, @Feedback, @TableNumber); SELECT SCOPE_IDENTITY();",
                conn))
            {
                // Preventing SQL injections
                command.Parameters.AddWithValue("@TotalAmount", payment.TotalAmount);
                command.Parameters.AddWithValue("@Tip", payment.Tips);
                command.Parameters.AddWithValue("@Feedback", payment.FeedBack);
                command.Parameters.AddWithValue("@TableNumber", payment.tableNumber);

                paymentHistoryID = Convert.ToInt32(command.ExecuteScalar());
            }

            // Insert into PaymentHistoryPaymentMethod table
            using (SqlCommand paymentMethodCommand = new SqlCommand(
                "INSERT INTO PaymentHistoryPaymentMethod (PaymentHistoryID, PaymentMethodID) " +
                "VALUES (@PaymentHistoryID, @PaymentMethodID)",
                conn))
            {
                paymentMethodCommand.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryID);
                paymentMethodCommand.Parameters.AddWithValue("@PaymentMethodID", payment.PaymentMethodID);
                paymentMethodCommand.ExecuteNonQuery();
            }

            conn.Close();
            return paymentHistoryID;

         }

        public string GetPaymentMethod(int paymentHistoryId)
        {
            string paymentMethod = string.Empty;

            using (SqlCommand command = new SqlCommand(
                "SELECT PaymentMethod.PaymentMethodName " +
                "FROM PaymentHistoryPaymentMethod " +
                "INNER JOIN PaymentMethod ON PaymentHistoryPaymentMethod.PaymentMethodID = PaymentMethod.PaymentMethodID " +
                "WHERE PaymentHistoryPaymentMethod.PaymentHistoryID = @PaymentHistoryID", conn))
            {
                conn.Open();
                command.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        paymentMethod = reader.GetString(0);
                    }
                }
            }
            conn.Close();
            return paymentMethod;
        }



        public List<Payment> GetPaymentHistory()  // getting data from database 
       {
            string query = "Select paymentHistoryID, TotalAmount,Tip,Feedback,TableNumber FROM [PaymentHistory]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadPaymentHistory(ExecuteSelectQuery(query, sqlParameters));
       }

        public bool GetVATStatus(Payment item)
        {
            bool isAlcoholic = false; // Default value if the item is not found or error occurs
                                      
            conn.Open();
            SqlCommand command = new SqlCommand
               ("SELECT vat_category FROM OrderItems WHERE itemName = @itemName",conn);
                        // Preventing SQL injections
            command.Parameters.AddWithValue("@itemName", item.itemName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isAlcoholic = reader.GetBoolean(0);//method in the SqlDataReader
                    }
                }
            return isAlcoholic;
        }

        public List<Payment> GetAllItems()
        {
            string query = "SELECT ItemName, Quantity, PricePerItem,tableNumber,vat_category,Comments FROM OrderItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Payment> GetItemsByTableNumber(int tableNumber)//
        {
            List<Payment> items = new List<Payment>();

            conn.Open();

            SqlCommand command = new SqlCommand(
        "SELECT tableNumber, PricePerItem, itemName, Quantity, Comments FROM OrderItems WHERE tableNumber = @tableNumber", conn);
            command.Parameters.AddWithValue("@tableNumber", tableNumber);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Payment payment = new Payment()
                    {
                        tableNumber=reader.GetInt32(0),// after check remove the table number.
                        ItemPrice = reader.GetDecimal(1),
                        itemName = reader.GetString(2),
                        Quantity = reader.GetInt32(3),
                        Comment = reader.IsDBNull(4) ? null : reader.GetString(4)// if the comment is Null
                    };
                    items.Add(payment);
                }  
            }
            conn.Close();
            return items;
        }

        private List<Payment> ReadPaymentHistory(DataTable dataTable) // data from database into class
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    PaymentHistoryID = (int)dr["paymentHistoryID"],
                    TotalAmount = (decimal)dr["TotalAmount"],
                    Tips = (decimal)dr["Tip"],
                    FeedBack = dr["Feedback"].ToString(),
                    tableNumber = (int)dr["TableNumber"],
                };
                payments.Add(payment);
            }
            return payments;
        }


        private SqlCommand CreatePaymentMethodCommand(int paymentHistoryID)
            {
                SqlCommand paymentMethodCommand = new SqlCommand(
                    "SELECT PaymentMethod.PaymentMethodName FROM PaymentHistoryPaymentMethod " +
                    "INNER JOIN PaymentMethod ON PaymentHistoryPaymentMethod.PaymentMethodID = PaymentMethod.PaymentMethodID " +
                    "WHERE PaymentHistoryPaymentMethod.PaymentHistoryID = @PaymentHistoryID", conn);

                paymentMethodCommand.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryID);

                return paymentMethodCommand;
            }

            private PaymentMethod ExecutePaymentMethodCommand(SqlCommand command)
            {
                string paymentMethodString = string.Empty;

                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        paymentMethodString = reader.GetString(0);
                    }
                }
                conn.Close();

                return (PaymentMethod)Enum.Parse(typeof(PaymentMethod), paymentMethodString);
            }

            private List<Payment> ReadOrderItems(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    ItemPrice = (decimal)dr["PricePerItem"],
                    tableNumber = (int)dr["tableNumber"],
                    itemName = dr["itemName"].ToString(),
                    Quantity = (int)dr["Quantity"],
                    IsAlcoholic = (bool)dr["vat_category"],
                    Comment = dr["Comments"].ToString(),
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}
