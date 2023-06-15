
using ChapeauModel;
using ChapeauService;
using System.CodeDom;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChapeauUI
{
    public partial class LoginScreen : Form
    {
        private readonly EmployeeService employeeService;

        public LoginScreen()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
            this.CenterToScreen();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void ValidateForm(Employee employee)
        {
            switch (employee.EmployeeType)
            {
                case EmployeeType.Waiter:
                    {
                        this.Hide();
                        TableOverview tableOverview = new TableOverview(employee);
                        tableOverview.ShowDialog();
                        this.Close();
                        break;
                    }

                case EmployeeType.Bartender:
                case EmployeeType.Chef:
                    {
                        this.Hide();
                        KitchenAndBarUI kitchenUI = new KitchenAndBarUI(employee);
                        kitchenUI.ShowDialog();
                        this.Close();
                        break;
                    }
                case EmployeeType.Manager:
                    {
                        this.Hide();
                        ManagerMainView managerMainView = new ManagerMainView(employee);
                        managerMainView.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    throw new Exception("Invalid employee");
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

                Employee loggedEmployee = employeeService.LoginEmployee(username, password);
                ValidateForm(loggedEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                passwordTextBox.Clear();
                loginbtn.Enabled = true;
                usernameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
        }
    }

}