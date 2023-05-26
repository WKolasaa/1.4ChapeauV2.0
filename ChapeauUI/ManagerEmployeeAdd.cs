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
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
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
}
