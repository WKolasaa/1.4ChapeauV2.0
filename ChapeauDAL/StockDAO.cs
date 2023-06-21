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
            string query = "SELECT itemID, itemName, quantity FROM InventoryItem";

            return ReadStock(ExecuteSelectQuery(query));
        }

        private List<Stock> ReadStock(DataTable dataTable)
        {
            List<Stock> stocks = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stock = new Stock()
                {
                    StockID = (int)dr["itemID"],
                    StockName = (string)dr["itemName"],
                    Quantity = (int)dr["quantity"]
                };

                stocks.Add(stock);
            }

            return stocks;
        }

        public void AddStock(Stock stock)
        {
            string query = "INSERT INTO InventoryItem (itemID, itemName, quantity) VALUES (@itemID, @itemName, @quantity)";

            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", stock.StockID),
                new SqlParameter("@itemName", stock.StockName),
                new SqlParameter("@quantity", stock.Quantity)
            };

            ExecuteEditQuery(query,parameter);
        }

        public void UpdateStock(Stock stock)
        {
            string query = "UPDATE InventoryItem SET itemID = @itemID, itemName = @itemName, quantity = @quantity WHERE itemID = @itemID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", stock.StockID),
                new SqlParameter("@itemName", stock.StockName),
                new SqlParameter("@quantity", stock.Quantity)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void DeleteStock(Stock stock)
        {
            string query = "DELETE FROM InventoryItem WHERE itemID = @itemID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@itemID", stock.StockID)
            };

            ExecuteEditQuery(query, parameter);
        }
    }
}
