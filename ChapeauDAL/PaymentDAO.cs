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
         public int AddPaymentHistory(Payment payment)
         {
            conn.Open();
            int paymentHistoryID;

            // Insert into PaymentHistory table
            SqlCommand command = new SqlCommand(
                "INSERT INTO PaymentHistory (TotalAmount, Tip, Feedback, TableNumber) " +
                "VALUES (@TotalAmount, @Tip, @Feedback, @TableNumber); SELECT SCOPE_IDENTITY();",
                conn);
            
                // Preventing SQL injections
                command.Parameters.AddWithValue("@TotalAmount", payment.TotalAmount);
                command.Parameters.AddWithValue("@Tip", payment.Tips);
                command.Parameters.AddWithValue("@Feedback", payment.Feedback);
                command.Parameters.AddWithValue("@TableNumber", payment.tableNumber);

                paymentHistoryID = Convert.ToInt32(command.ExecuteScalar());

            // Insert into PaymentHistoryPaymentMethod table
            SqlCommand paymentMethodCommand = new SqlCommand(
                "INSERT INTO PaymentHistoryPaymentMethod (PaymentHistoryID, PaymentMethodID) " +
                "VALUES (@PaymentHistoryID, @PaymentMethodID)",
                conn);
            
                paymentMethodCommand.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryID);
                paymentMethodCommand.Parameters.AddWithValue("@PaymentMethodID", payment.PaymentMethodID);

           
            paymentMethodCommand.ExecuteNonQuery();

            conn.Close();
            return paymentHistoryID;

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



 public List<Payment> GetPaymentHistory()  // getting data from database 
 {
     string query = "SELECT ph.paymentHistoryID, ph.TotalAmount, ph.Tip, ph.Feedback, ph.TableNumber, pm.PaymentMethodName " +
            "FROM PaymentHistory ph " +
            "INNER JOIN PaymentHistoryPaymentMethod phpm ON ph.paymentHistoryID = phpm.PaymentHistoryID " +
            "INNER JOIN PaymentMethod pm ON phpm.PaymentMethodID = pm.PaymentMethodID"; 
     SqlParameter[] sqlParameters = new SqlParameter[0];
     return ReadPaymentHistory(ExecuteSelectQuery(query, sqlParameters));
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
          "SELECT tableNumber, PricePerItem, itemName, Quantity, Comments FROM OrderItems WHERE tableNumber = @tableNumber", conn);
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
                 Comment = reader.IsDBNull(4) ? "" : reader.GetString(4)  
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

         foreach (DataRow dr in dataTable.Rows)
         {
            Payment payment = new Payment()
            {
              PaymentHistoryID = (int)dr["paymentHistoryID"],
              TotalAmount = (decimal)dr["TotalAmount"],
              Tips = (decimal)dr["Tip"],
               Feedback = dr["Feedback"].ToString(),
              tableNumber = (int)dr["TableNumber"],
              PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), GetPaymentMethod((int)dr["paymentHistoryID"])) // Convert string to enum
            };
           payments.Add(payment);
         }
           return payments;
       }

 private int GetPaymentMethodID(int paymentHistoryID)
 {
     int paymentMethodID = 0;
     conn.Open();

     SqlCommand command = new SqlCommand(
         "SELECT PaymentMethodID FROM PaymentHistoryPaymentMethod WHERE PaymentHistoryID = @PaymentHistoryID", conn);
     command.Parameters.AddWithValue("@PaymentHistoryID", paymentHistoryID);

     object result = command.ExecuteScalar();
     if (result != null)
     {
         paymentMethodID = Convert.ToInt32(result);
     }

     conn.Close();
     return paymentMethodID;
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

 /// ////////////////////////////////////////////////////////////////////////////

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
}
}
