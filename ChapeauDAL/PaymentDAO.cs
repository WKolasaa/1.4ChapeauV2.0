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
         public void AddPaymentHistory(Payment payment)
         {
            conn.Open();

            // Convert the payment methods list to a string representation
            string paymentMethodsString = string.Join(",", payment.PaymentMethods);

            // Insert into PaymentHistory table
            SqlCommand command = new SqlCommand(
                  "INSERT INTO PaymentHistory (TotalAmount, Tip, Feedback, TableNumber, PaymentMethods) " +
                "VALUES (@TotalAmount, @Tip, @Feedback, @TableNumber, @PaymentMethods); SELECT SCOPE_IDENTITY();",
                 conn);


            // Preventing SQL injections
            command.Parameters.AddWithValue("@TotalAmount", payment.TotalAmount);
                command.Parameters.AddWithValue("@Tip", payment.Tips);
                command.Parameters.AddWithValue("@Feedback", payment.Feedback);
                command.Parameters.AddWithValue("@TableNumber", payment.tableNumber);
                command.Parameters.AddWithValue("@PaymentMethods", paymentMethodsString);

            command.ExecuteNonQuery();

           

            conn.Close();            
         }

        public string GetPaymentMethod(int paymentHistoryId)
        {
            string paymentMethod = string.Empty;
            conn.Open();

            SqlCommand command = new SqlCommand(
              "SELECT PaymentMethod.PaymentMethodName " +
              "FROM PaymentHistoryPaymentMethod " +
              "INNER JOIN PaymentMethod ON PaymentHistoryPaymentMethod.PaymentMethodID = PaymentMethod.PaymentMethodID " +
              "WHERE PaymentHistoryPaymentMethod.PaymentHistoryID = @PaymentHistoryID", conn);
       
                command.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryId);

               
            
            conn.Close();
            return paymentMethod;
        }



        public List<Payment> GetPaymentHistory()
        {
            string query = "SELECT paymentHistoryID, TotalAmount, Tip, Feedback, TableNumber, PaymentMethods " +
                           "FROM PaymentHistory";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadPaymentHistory(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Payment> GetLastPaymentHistory()
        {
            string query = "SELECT TOP 1 paymentHistoryID, TotalAmount, Tip, Feedback, TableNumber, PaymentMethods " +
                           "FROM PaymentHistory " +
                           "ORDER BY paymentHistoryID DESC"; // Select only the top (highest) paymentHistoryID

            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            return ReadPaymentHistory(dataTable);
        }

        public bool GetVATStatus(OrderItem item)
        {   
       conn.Open();
         SqlCommand command = new SqlCommand
        ("SELECT vat_category FROM OrderItems WHERE itemName = @itemName",conn);
                 // Preventing SQL injections
         command.Parameters.AddWithValue("@itemName", item.ItemName);

         using (SqlDataReader reader = command.ExecuteReader())
         {
             if (reader.Read())
             {
             item.VatCategory = reader.GetBoolean(0);// 0 means the first column 
             }
         }
        return item.VatCategory;
     }

  public List<OrderItem> GetAllItems()
  {
     string query = "SELECT ItemName, Quantity, PricePerItem,tableNumber,vat_category,Comments FROM OrderItems";
     SqlParameter[] sqlParameters = new SqlParameter[0];
     return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
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
                 Comment = reader.IsDBNull(4) ? "" : reader.GetString(4),
                 VatCategory=reader.GetBoolean(5),

             };
             items.Add(item);
         }  
     }
     conn.Close();
     return items;
 }

       private List<Payment> ReadPaymentHistory(DataTable dataTable) // data from database into class
       {
            List<Payment> payments = new List<Payment>();
            HashSet<string> uniquePaymentMethods = new HashSet<string>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int paymentHistoryID = (int)dr["paymentHistoryID"];
                string paymentMethoddd = dr["PaymentMethods"].ToString();

                Payment payment = new Payment()
                {
                    PaymentHistoryID = (int)dr["paymentHistoryID"],
                    TotalAmount = (decimal)dr["TotalAmount"],
                    Tips = (decimal)dr["Tip"],
                    Feedback = dr["Feedback"].ToString(),
                    tableNumber = (int)dr["TableNumber"],
                    PaymentMethods = new List<PaymentMethod>()
                };
                string paymentMethodsString = dr["PaymentMethods"].ToString();
                List<string> paymentMethods = paymentMethodsString.Split(',').ToList();

                foreach (string method in paymentMethods)
                {
                    if (Enum.TryParse(method, out PaymentMethod paymentMethod))
                    {
                        payment.PaymentMethods.Add(paymentMethod);
                    }
                }

                payments.Add(payment);
            }
            return payments;

        }





        private List<OrderItem> ReadOrderItems(DataTable dataTable)
       {
         List<OrderItem> items = new List<OrderItem>();
          foreach (DataRow dr in dataTable.Rows)
          {
             OrderItem item = new OrderItem()
             {
             PricePerItem = (decimal)dr["PricePerItem"],
             TableNumber = (int)dr["tableNumber"],
             ItemName = dr["itemName"].ToString(),
             Quantity = (int)dr["Quantity"],
             VatCategory = (bool)dr["vat_category"],
             Comment = dr["Comments"].ToString(),
            };
             items.Add(item);
          }
          return items;
       }
    }
}
