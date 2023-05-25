using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class TableService
    {
        private TableDAO tableDAO = new TableDAO();

        public List<Table> GetAllTables()
        {
            return tableDAO.GetAllTables();
        }

        public Table GetTable(int tableID)
        {
            return tableDAO.GeTable(tableID);
        }

        public void UpdateStatus(int tableID, TableStatus status)
        {
            tableDAO.UpdateStatus(tableID, status);
        }
    }
}