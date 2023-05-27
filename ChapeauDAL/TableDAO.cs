using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using SomerenDAL;

namespace ChapeauDAL
{
    public class TableDAO : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT tableID, Occupied, tableNumber FROM [Tables]";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameter);
            return ReadTables(dataTable);
        }

        public Table GetTable(int tableID)
        {
            string query = "SELECT tableID, Occupied, tableNumber FROM [Tables] WHERE tableID = @tableID";
            SqlParameter[] sqlParameters =
            {
              new SqlParameter("@tableID", tableID)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTable(dataTable);
        }

        public void UpdateTableStatus(Table table)
        {
            string query = "UPDATE [Tables] SET Occupied = @Occupied WHERE tableID = @tableID";
            SqlParameter[] sqlParameters =
            {
           new SqlParameter("@Occupied", (int)table.TableStatus),
           new SqlParameter("@tableID", table.TableId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Table ReadTable(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                Table table = new Table()
                {
                    TableId = (int)row["tableID"],
                    TableStatus = (TableStatus)(int)row["Occupied"],
                    TableNumber = (int)row["tableNumber"]
                };

                return table;
            }

            return null;
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableId = (int)dr["tableID"],
                    TableStatus = (TableStatus)(int)dr["Occupied"],
                    TableNumber = (int)dr["tableNumber"],
                };
                tables.Add(table);
            }

            return tables;
        }
    }
}