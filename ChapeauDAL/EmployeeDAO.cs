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
using System.Collections;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDao
    {
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT employeeID,employeeType,firstName,lastName,dateOfBirth,password,Username FROM Employee";

            return ReadEmployees(ExecuteSelectQuery(query));
        }

        private List<Employee> ReadEmployees(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee
                {
                    EmployeeId = (int)dr["employeeID"],
                    EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString()),
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    Password = dr["password"].ToString(),
                    UserName = dr["Username"].ToString(),
                    DateOfBirth = (DateTime)dr["dateOfBirth"]
                };

                employees.Add(employee);
            }
            return employees;

        }

        public void AddEmployee(Employee employee)
        {
            string query = "INSERT INTO Employee (EmployeeType, FirstName, LastName, Password, dateOfBirth, Username) VALUES (@employeeType, @firstName, @lastName, @password, @dateOfBirth, @UserName)";

            SqlParameter[] parameter =
            {
                new SqlParameter("@employeeType", Convert.ToInt32(employee.EmployeeType)),
                new SqlParameter("@firstName",employee.FirstName),
                new SqlParameter("@lastName",employee.LastName),
                new SqlParameter("@password",employee.Password),
                new SqlParameter("@dateOfBirth", employee.DateOfBirth), 
                new SqlParameter("@UserName", employee.UserName)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void EditEmployee(Employee employee)
        {
            string query = "UPDATE Employee SET employeeType=@employeeType,firstName=@firstName, lastName=@lastName, dateOfBirth=@dateOfBirth, Username=@Username, [password]=@password WHERE EmployeeID=@employeeID;";

            SqlParameter[] parameter =
            {
                new SqlParameter("@employeeID", employee.EmployeeId),
                new SqlParameter("@employeeType", employee.EmployeeType.ToString()),
                new SqlParameter("@firstName", employee.FirstName),
                new SqlParameter("@lastName", employee.LastName),
                new SqlParameter("@dateOfBirth", employee.DateOfBirth),
                new SqlParameter("@Username", employee.UserName),
                new SqlParameter("@password", BCrypt.Net.BCrypt.HashPassword(employee.Password))
            };

            ExecuteEditQuery(query, parameter);
        }

        public void DeleteEmployee(Employee employee)
        {
            string query = "DELETE FROM Employee WHERE employeeID=@employeeID";

            SqlParameter[] parameter =
            {
                new SqlParameter("@employeeID", employee.EmployeeId)
            };

            ExecuteEditQuery(query, parameter);
        }

        public string GetHashedPassword(string UserName)
        {
            string query = "SELECT password FROM Employee WHERE Username = @Username";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", UserName)
            };

            DataTable dataTable = ExecuteSelectQuery(query, parameters);

            return dataTable.Rows[0]["password"].ToString();
        }

        public Employee GetEmployeeByUserName(string UserName)
        {
            string command = "SELECT employeeID,employeeType,firstName,lastName,password,Username, dateOfBirth FROM Employee WHERE Username = @UserName";

            SqlParameter[] parameter =
            {
                new SqlParameter("@UserName", UserName)
            };
            DataTable reader = ExecuteSelectQuery(command, parameter);

            Employee employee = ReadEmployee(reader);

            return employee;
        }

        private Employee ReadEmployee(DataTable reader)
        {
            DataRow dr = reader.Rows[0];
            Employee employee = new Employee();

            employee.EmployeeId = (int)dr["employeeID"];
            employee.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString());
            employee.FirstName = dr["firstName"].ToString();
            employee.LastName = dr["lastName"].ToString();
            employee.Password = dr["password"].ToString();
            employee.UserName = dr["Username"].ToString();
            employee.DateOfBirth = (DateTime)dr["dateOfBirth"];

            return employee;
        }



    }
}
