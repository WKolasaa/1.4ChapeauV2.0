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
        public List<Table> GetAllTables() //Get all the tables available
        {
            conn.Open();
            string query = "SELECT tableID,Occupied,FROM Tables";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadTables(ExecuteSelectQuery(query, parameter));
        }

        public Table GeTableById(int tableID) //get one specific table by tableid
        {
            String query = "SELECT tableID,Occupied FROM Tables WHERE tableID=@tableID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableID", tableID)

            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateTableStatus(int tableID, TableStatus status) //update table status
        {
            string query = "UPDATE Tables Set Occupied=@Occupied WHERE tableID=@tableID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Occupied", status.ToString()),
                new SqlParameter("@tableID", tableID),
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
                    TableStatus = (TableStatus)Enum.Parse(typeof(TableStatus), row["occuppided"].ToString())
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
                    TableStatus = (TableStatus)Enum.Parse(typeof(TableStatus),
                        dr["Occupied"].ToString()),
                };
                tables.Add(table);
            }

            return tables;


        }
    }
}