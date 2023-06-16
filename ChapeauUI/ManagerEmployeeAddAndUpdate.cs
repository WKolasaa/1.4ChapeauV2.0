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
        private Employee employee;
        private bool AddForm;

        public ManagerEmployeeAdd(bool Add, Employee employee)
        {
            InitializeComponent();
            cbAddEmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeType));
            txtAddEmployeePassword.UseSystemPasswordChar = true;
            CenterToScreen();
            this.employee = employee;
            AddForm = Add;
            if (Add)
                btAddEmployee.Text = "Add employee";
            else
                UpdateForm();
        }

        private void UpdateForm()
        {
            importData();
            btAddEmployee.Text = "Update employee";
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtAddEmployeeFirstName.Text.Length == 0 || txtAddEmployeeLastName.Text.Length == 0 || txtAddEmployeePassword.Text.Length == 0 || txtAddEmployeeUserName.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");

            if (int.Parse(txtAddEmployeeID.Text) < 0)
                MessageBox.Show("ID cannot be lover then 0!");

            else
            {
                EmployeeService employeeService = new EmployeeService();

                if (AddForm)
                {
                    Employee newEmployee = insertData();
                    employeeService.AddEmployee(newEmployee);
                    MessageBox.Show("Employee Added!");
                    
                }
                else
                {
                    employee = insertData();
                    employeeService.EditEmployee(employee);
                    MessageBox.Show("Employee updated!");
                }

                Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importData()
        {
            txtAddEmployeeID.Text = employee.EmployeeId.ToString();
            txtAddEmployeeFirstName.Text = employee.FirstName;
            txtAddEmployeeLastName.Text = employee.LastName;
            cbAddEmployeeRole.SelectedItem = employee.EmployeeType;
            txtAddEmployeeUserName.Text = employee.UserName;
            txtAddEmployeePassword.Text = employee.Password;
        }

        private Employee insertData()
        {
            Employee importedEmployee = new Employee();

            importedEmployee.FirstName = txtAddEmployeeFirstName.Text;
            importedEmployee.LastName = txtAddEmployeeLastName.Text;
            importedEmployee.EmployeeId = int.Parse(txtAddEmployeeID.Text);
            importedEmployee.EmployeeType = (EmployeeType)cbAddEmployeeRole.SelectedIndex;
            importedEmployee.Password = txtAddEmployeePassword.Text;
            importedEmployee.UserName = txtAddEmployeeUserName.Text;

            return importedEmployee;
        }
    }
}
