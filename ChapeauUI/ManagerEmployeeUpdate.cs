using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ManagerEmployeeUpdate : Form
    {
        Employee employee;
        public ManagerEmployeeUpdate(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            cbUpdateEmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeType));
            this.CenterToScreen();
            DisplayData(employee);
        }

        private void DisplayData(Employee employee)
        {
            txtUpdateEmployeeID.Text = employee.EmployeeId.ToString();
            txtUpdateEmployeeFirstName.Text = employee.FirstName;
            txtUpdateEmployeeLastName.Text = employee.LastName;
            txtUpdateEmployeePassword.Text = employee.Password;
            cbUpdateEmployeeRole.SelectedItem = employee.EmployeeType;
            txtUpdateEmployeeUserName.Text = employee.UserName;
        }

        private void btUpdateEmployee_Click(object sender, EventArgs e)
        {

            if (txtUpdateEmployeeFirstName.Text.Length == 0 || txtUpdateEmployeeLastName.Text.Length == 0 || txtUpdateEmployeePassword.Text.Length == 0 || txtUpdateEmployeeUserName.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");

            if (int.Parse(txtUpdateEmployeeID.Text) < 0)
                MessageBox.Show("ID cannot be lover then 0!");

            else
            {
                Employee employee = new Employee();
                employee.FirstName = txtUpdateEmployeeFirstName.Text;
                employee.LastName = txtUpdateEmployeeLastName.Text;
                employee.EmployeeId = int.Parse(txtUpdateEmployeeID.Text);
                employee.EmployeeType = (EmployeeType)cbUpdateEmployeeRole.SelectedIndex;
                employee.Password = txtUpdateEmployeePassword.Text;
                employee.UserName = txtUpdateEmployeeUserName.Text;

                EmployeeService employeeService = new EmployeeService();
                employeeService.EditEmployee(employee);

                MessageBox.Show("Employee Updated!");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerEmployeeUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
