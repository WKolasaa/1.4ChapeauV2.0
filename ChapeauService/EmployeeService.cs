using ChapeauDAL;
using ChapeauModel;
using System.Data;

namespace ChapeauService
{
    public class EmployeeService
    {
        private EmployeeDAO employeeDAO = new EmployeeDAO();

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            employee.Password = HashPassword(employee.Password);
            employeeDAO.AddEmployee(employee);
        }

        public void EditEmployee(Employee employee)
        {
            employeeDAO.EditEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            if (employee.EmployeeType == EmployeeType.Waiter)
            {
                throw new SystemException("Waiter cannot be deleted if they are pending orders");
            }
            employeeDAO.DeleteEmployee(employee);
        }

        public Employee LoginEmployee(string username, string password)
        {
            if (VerifyLogin(username, password))
            {
                return employeeDAO.GetEmployeeByUserName(username);
            }
            else throw new Exception("invalid credentials");
        }

        public bool VerifyLogin(string username, string password)
        {
            string hashedPasswordFromDB = employeeDAO.GetHashedPassword(username);
            return BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);

        }

        public string HashPassword(string plainTextPassword)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainTextPassword, salt);
            return hashedPassword;
        }

        public Employee GetEmployeeByUserName(string userName)
        {
            return employeeDAO.GetEmployeeByUserName(userName);
        }
    }
}