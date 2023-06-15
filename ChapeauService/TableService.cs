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

        public Table GetTableById(int tableID)
        {
            return tableDAO.GetTableById(tableID);
        }

        public void UpdateTableStatus(Table table)
        {
            tableDAO.UpdateTableStatus(table);
        }

        public void FreeTable(int tableID, TableStatus status)
        {
            
            Table table = tableDAO.GetTableById(tableID);
            if (table != null)
            {
                table.TableStatus = status;
                tableDAO.UpdateTableStatus(table);
            }
        }
    }
    
}