using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using SomerenDAL;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using Org.BouncyCastle.Crypto.Generators;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDao
    {
        public List<Employee> GetEmployee()
        {
            conn.Open();
            String query = "SELECT employeeID,employeeType,firstName,lastName,dateOfBirth,password FROM Employee";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadEmployee(ExecuteSelectQuery(query, parameter));
        }

        private List<Employee> ReadEmployee(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeId = (int)dr["employeeID"],
                    EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString()),
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    Password = dr["password"].ToString()
                };

                employees.Add(employee);
            }
            return employees;

        }

        public void AddEmployee(Employee employee)
        {
            conn.Open();
            /*            string salt = BCrypt.Net.BCrypt.GenerateSalt();
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(employee.Password);*/
            string query = "INSERT INTO Employee (EmployeeType, FirstName, LastName, Password) VALUES (@employeeType, @firstName, @lastName, @password)";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@employeeType", Convert.ToInt32(employee.EmployeeType)),
                new SqlParameter("@firstName",employee.FirstName),
                new SqlParameter("@lastName",employee.LastName),
                new SqlParameter("@password",employee.Password)
            };

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
            }

            conn.Close();
        }


        public void EditEmployee(Employee employee)
        {
            conn.Open();
            string query = "UPDATE Employee SET employeeType=@employeeType,firstName=@firstName,[password]=@password WHERE EmployeeID=@employeeID;";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@employeeID", employee.EmployeeId),
                new SqlParameter("@employeeType", employee.EmployeeType.ToString()),
                new SqlParameter("@firstName", employee.FirstName),
                new SqlParameter("@password", BCrypt.Net.BCrypt.HashPassword(employee.Password))
            };

            ExecuteEditQuery(query, parameter);
            conn.Close();
        }

        public void DeleteEmployee(Employee employee)
        {
            conn.Open();
            string query = "DELETE FROM Employees WHERE employeeID=@employeeID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@employeeID", employee.EmployeeId)
            };
            ExecuteEditQuery(query, parameter);
            conn.Close();
        }
        public string HashedPassword(string firstName)
        {
            conn.Open();
            string query = "SELECT password FROM Employee WHERE firstName = @firstName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@firstName", firstName)
            };
            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            conn.Close();
            return dataTable.Rows[0]["password"].ToString();

            /*if (dataTable.Rows.Count == 1)
            {
                string hashedPasswordFromDB = dataTable.Rows[0]["password"].ToString();
                return BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);
            }*/


        }



    }
}
