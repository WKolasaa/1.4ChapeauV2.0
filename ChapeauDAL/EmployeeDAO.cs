﻿using System;
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
        public List<Employee> GetAllEmployees()
        {
            conn.Open();
            String query = "SELECT employeeID,employeeType,firstName,lastName,dateOfBirth,password,Username FROM Employee";
            SqlParameter[] parameter = new SqlParameter[0];
            conn.Close();
            return ReadEmployees(ExecuteSelectQuery(query, parameter));
        }

        private List<Employee> ReadEmployees(DataTable dataTable)
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
                    Password = dr["password"].ToString(),
                    UserName = dr["Username"].ToString()
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
            string query = "INSERT INTO Employee (employeeID, EmployeeType, FirstName, LastName, Password, dateOfBirth, Username) VALUES (@employeeID, @employeeType, @firstName, @lastName, @password, @dateOfBirth, @UserName)";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@employeeID", employee.EmployeeId),
                new SqlParameter("@employeeType", Convert.ToInt32(employee.EmployeeType)),
                new SqlParameter("@firstName",employee.FirstName),
                new SqlParameter("@lastName",employee.LastName),
                new SqlParameter("@password",employee.Password),
                new SqlParameter("@dateOfBirth", DateTime.Now), // DELETE THIS AND FROM DATABASE !!!!
                new SqlParameter("@UserName", employee.UserName)
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
            string query = "DELETE FROM Employee WHERE employeeID=@employeeID";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@employeeID", employee.EmployeeId)
            };
            ExecuteEditQuery(query, parameter);
            conn.Close();
        }
        public string GetHashedPassword(string UserName)
        {
            conn.Open();
            string query = "SELECT password FROM Employee WHERE Username = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", UserName)
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
