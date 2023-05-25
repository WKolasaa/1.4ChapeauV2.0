using ChapeauModel;
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
    public class StockDAO : BaseDao
    {
        public List<Stock> GetStock()
        {
            conn.Open();
            string query = "SELECT itemID, itemName, quantity FROM InventoryItem";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadStock(ExecuteSelectQuery(query,parameter));
        }

        private List<Stock> ReadStock(DataTable dataTable)
        {
            List<Stock> stocks = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stock = new Stock()
                {
                    StockID = (uint)dr["itemID"],
                    StockName = (string)dr["itemName"],
                    Quantity = (uint)dr["quantity"]
                };

                stocks.Add(stock);
            }

            return stocks;
        }

        public void AddStock(Stock stock)
        {
            conn.Open();
            string query = "INSERT INTO InventoryItem (itemID, itemName, quantity) VALUES (@itemID, itemName, quantity)";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", stock.StockID),
                new SqlParameter("@itemName", stock.StockName),
                new SqlParameter("@quantity", stock.Quantity)
            };

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
            }
           
            conn.Close();
        }

        public void UpdateStock(Stock stock)
        {
            conn.Open();
            string query = "UPDATE InventoryItem SET itemID = @itemID, itemName = @itemName, quantity = @quantity WHERE itemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", stock.StockID),
                new SqlParameter("@itemName", stock.StockName),
                new SqlParameter("@quantity", stock.Quantity)
            };

            ExecuteEditQuery(query, parameter);
            conn.Close(); 
        }

        public void DeleteStock(Stock stock)
        {
            conn.Open();
            string query = "DELETE FROM InventoryItem WHERE itemID = @itemID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@itemID", stock.StockID)
            };
            ExecuteEditQuery(query, parameter);
            conn.Close();
        }
    }
}
