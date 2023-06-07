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
             SqlCommand command = new SqlCommand
                 (
              "INSERT INTO PaymentHistory (TotalAmount,Tip,Feedback,TableNumber) VALUES (@PaymentMethod, @TotalAmount, @Tip, @Feedback, @TableNumber);SELECT SCOPE_IDENTITY(); ", conn);

             // Preventing SQL injections
             command.Parameters.AddWithValue("@TotalAmount", payment.TotalMoney);
             command.Parameters.AddWithValue("@Tip", payment.Tips);
             command.Parameters.AddWithValue("@Feedback", payment.FeedBack);
             command.Parameters.AddWithValue("@TableNumber", payment.tableNumber);
            int paymentHistoryID = Convert.ToInt32(command.ExecuteScalar());//give a unique ID assigned to the inserted payment record.
            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was added
             // Convert the enum to an integer and set the parameter value
             if (nrOfRowsAffected == 0)
                 throw new Exception("Payment was not completed!");
             command.ExecuteNonQuery();
            conn.Close();
            return paymentHistoryID;

         }



        public List<Payment> GetPaymentHistory()  // getting data from database 
        {
            string query = "Select PaymentMethod,TotalAmount,Tip,Feedback,TableNumber FROM [PaymentHistory]";
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
                    PaymentMethod = (PaymentMethod)dr["PaymentMethod"],
                    TotalMoney = (decimal)dr["TotalAmount"],
                    Tips = (decimal)dr["Tip"],
                    FeedBack = dr["Feedback"].ToString(),
                    tableNumber = (int)dr["TableNumber"],
                };
                payments.Add(payment);
            }
            return payments;
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
