
using ChapeauModel;
using ChapeauService;
using System.CodeDom;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChapeauUI
{
    public partial class LoginScreen : Form
    {
        public Employee employeeLogged = new Employee(); // instead of creating an employee object try to get the whole employee if it exist 

        private EmployeeService employeeService;

        public LoginScreen()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
            this.CenterToScreen();
            passwordTextBox.UseSystemPasswordChar = true;


        }

        private void ValidateForm(string UserName)
        {
            employeeLogged = employeeService.GetEmployeeByUserName(UserName);
            switch (employeeLogged.EmployeeType)
            {
                case EmployeeType.Waiter:
                    {
                        this.Hide();
                        TableOverview tableOverview = new TableOverview(employeeLogged);
                        tableOverview.ShowDialog();
                        this.Close();
                        break;
                    }

                case EmployeeType.Bartender:
                    {

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
                        ManagerMainView managerMainView = new ManagerMainView(employeeLogged);
                        managerMainView.ShowDialog();
                        this.Close();
                        break;
                    }
            }
        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            try
            {


                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                usernameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;



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

            loginbtn.Enabled = true;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }
    }
}