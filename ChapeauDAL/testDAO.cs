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
    public class testDAO : BaseDao
    {
        public List<int> Rooms()
        {
            string query = "SELECT * FROM Rooms";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<int> ReadTables(DataTable dataTable)
        {
            List<int> list = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add((int)dr["roomID"]);
            }

            return list;
        }

        public void test()
        {
            List<int> list = Rooms();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
