using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class StockService
    {
        private StockDAO stockdb;

        public StockService()
        {
            stockdb = new StockDAO();
        }

        public List<Stock> GetStock()
        {
            return stockdb.GetStock();
        }

        public void AddStock(Stock stock)
        {
            stockdb.AddStock(stock);
        }
        public void UpdateStock(Stock stock)
        {
            stockdb.UpdateStock(stock);
        }
        public void DeleteStock(Stock stock)
        {
            stockdb.DeleteStock(stock);
        }

    }
}
