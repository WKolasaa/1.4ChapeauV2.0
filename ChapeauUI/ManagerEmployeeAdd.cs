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
    public partial class ManagerEmployeeAdd : Form
    {
        public ManagerEmployeeAdd()
        {
            InitializeComponent();
            cbAddEmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeType));
            this.CenterToScreen();
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtAddEmployeeFirstName.Text.Length == 0 || txtAddEmployeeLastName.Text.Length == 0 || txtAddEmployeePassword.Text.Length == 0 || txtAddEmployeeUserName.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");

            if (int.Parse(txtAddEmployeeID.Text) < 0)
                MessageBox.Show("ID cannot be lover then 0!");

            else
            {
                Employee employee = new Employee();
                employee.FirstName = txtAddEmployeeFirstName.Text;
                employee.LastName = txtAddEmployeeLastName.Text;
                employee.EmployeeId = int.Parse(txtAddEmployeeID.Text);
                employee.EmployeeType = (EmployeeType)cbAddEmployeeRole.SelectedIndex;
                employee.Password = txtAddEmployeePassword.Text;
                employee.UserName = txtAddEmployeeUserName.Text;

                EmployeeService employeeService = new EmployeeService();
                employeeService.AddEmployee(employee);

                MessageBox.Show("Employee Added!");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerEmployeeAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
