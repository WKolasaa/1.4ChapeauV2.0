
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

        private void loginbtn_Click(object sender, EventArgs e)
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