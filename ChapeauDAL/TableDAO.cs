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
        public List<Table> GetAllTables()//Get all the tables available
        {
            conn.Open();
            string query = "SELECT tableID,occuppided,FROM Tables";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadTables(ExecuteSelectQuery(query, parameter));
        }

        public Table GeTable(int tableID)//get one specific table by tableid
        {
            String query = "SELECT tableID,occuppided FROM Tables WHERE tableID=@tableID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@tableID", tableID)

            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateStatus(int tableID, TableStatus status)//update table status
        {
            string query = "UPDATE Tables set occuppided=@occuppided WHERE tableID=@tableID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@occuppided", status.ToString()),
                new SqlParameter("@tableID", tableID),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                table = new Table()
                {
                    TableId = (int)dr["tableID"],
                    TableStatus = (TableStatus)Enum.Parse(typeof(TableStatus),
                    dr["occuppided"].ToString()),
                };

            }

            return table;
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
                        dr["occuppided"].ToString()),
                };
                tables.Add(table);
            }

            return tables;
        }






    }
}