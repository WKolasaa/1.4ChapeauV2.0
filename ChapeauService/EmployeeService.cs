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
            // Verify the login credentials
            if (VerifyLogin(username, password))
            {
                // If the credentials are valid, retrieve the employee from the DAO
                return employeeDAO.GetEmployeeByUserName(username);
            }
            else
            {
               
                throw new Exception("invalid credentials");
            }
        }

        public bool VerifyLogin(string username, string password)
        {
            try
            {
                // Retrieve the hashed password from the database
                string hashedPasswordFromDB = employeeDAO.GetHashedPassword(username);

                // Verify the provided password against the hashed password using BCrypt
                return BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);
            }
            catch (Exception e)
            {

                Console.WriteLine($"An error occurred during login verification: {e}");
                return false;
            }
        }

        public string HashPassword(string plainTextPassword)
        {
            // Generate a salt for the password hashing
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            // Hash the plain text password using BCrypt and the generated salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainTextPassword, salt);

            // Return the hashed password
            return hashedPassword;
        }

    }
}