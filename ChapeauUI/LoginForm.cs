
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

        private void ValidateForm(Employee employee)
        {
            UniqueLoggedInEmployee loggedEmployee = UniqueLoggedInEmployee.GetInstance();
            loggedEmployee.LogEmployee(employee);

            switch (employee.EmployeeType)
            {
                case EmployeeType.Waiter:
                    {
                        this.Hide();
                        TableOverview tableOverview = new TableOverview(); 
                        tableOverview.ShowDialog();
                        this.Close();
                        break;
                    }

                case EmployeeType.Bartender:
                    {
                        this.Hide();
                        KitchenAndBarUI kitchenUI = new KitchenAndBarUI(employee);
                        kitchenUI.ShowDialog();
                        this.Close();
                        break;
                    }

                case EmployeeType.Chef:
                    {
                        this.Hide();
                        KitchenAndBarUI barUI = new KitchenAndBarUI(employee);
                        barUI.ShowDialog();
                        this.Close();
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

                ValidateForm(employeeService.LoginEmployee(username, password));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loginbtn.Enabled = true;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }
    }
}