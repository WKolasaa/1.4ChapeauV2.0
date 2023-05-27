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
            return tableDAO.GetTable(tableID);
        }

        public void UpdateTableStatus(Table table)
        {
            tableDAO.UpdateTableStatus(table);
        }

        public void FreeTabTable(int tableID, TableStatus status)
        {
            
            Table table = tableDAO.GetTable(tableID);
            if (table != null)
            {
                table.TableStatus = status;
                tableDAO.UpdateTableStatus(table);
            }
        }
    }
    
}