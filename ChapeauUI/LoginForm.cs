
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class LoginScreen : Form
    {
        private EmployeeService employeeService;

        public LoginScreen()
        {
            employeeService = new EmployeeService();
            InitializeComponent();

        }

        private void ValidateForm(string UserName)
        {
            Employee employee = new Employee();
            employee = employeeService.GetEmployeeByUserName(UserName);

            switch (employee.EmployeeType)
            {
                case EmployeeType.Waiter:
                    {
                        //
                        break;
                    }

                case EmployeeType.Bartender:
                    {
                        // 
                        break;
                    }

                case EmployeeType.Chef:
                    {
                        //
                        break;
                    }
                case EmployeeType.Manager:
                    {
                        this.Hide();
                        ManagerMainView managerMainView = new ManagerMainView();
                        managerMainView.ShowDialog();
                        this.Close();
                        break;
                    }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Required fields need to be filled");
                    return;
                }

                bool isValidLogin = employeeService.VerifyLogin(username, password);
                if (isValidLogin)
                {
                    MessageBox.Show("Successful login");
                    ValidateForm(username);
                }
                else
                {
                    MessageBox.Show("Failed to login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}