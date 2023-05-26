using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ManagerEmployees : Form
    {
        public ManagerEmployees()
        {
            InitializeComponent();
        }
        private void ManagerEmployees_Load(object sender, EventArgs e)
        {
            UpdateList();

        }

        private void UpdateList()
        {
            List<Employee> list = GetEmployees();
            DisplayEmployees(list);
        }

        private List<Employee> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetAllEmployees();
            return employees;
        }

        private void DisplayEmployees(List<Employee> employees)
        {
            lvEmployees.Clear();

            lvEmployees.Columns.Add("ID", 50);
            lvEmployees.Columns.Add("Name", 150);
            lvEmployees.Columns.Add("User Name", 150);
            lvEmployees.Columns.Add("Role", 100);
            lvEmployees.Columns.Add("Password", 150);

            foreach (var employee in employees)
            {
                //ListViewItem li = new ListViewItem();
                ListViewItem li = new ListViewItem(employee.EmployeeId.ToString());
                li.SubItems.Add(employee.Name);
                li.SubItems.Add(employee.UserName);
                li.SubItems.Add(employee.EmployeeType.ToString());
                li.SubItems.Add(employee.Password);

                li.Tag = employee;
                lvEmployees.Items.Add(li);
            }

            lvEmployees.Columns[0].Width = 50;
            lvEmployees.Columns[1].Width = 150;
            lvEmployees.Columns[2].Width = 150;
            lvEmployees.Columns[3].Width = 100;
            lvEmployees.Columns[4].Width = 250;

            lvEmployees.View = View.Details;
        }

        private void btEmployeesAdd_Click(object sender, EventArgs e)
        {
            ManagerEmployeeAdd sistema = new ManagerEmployeeAdd();
            sistema.ShowDialog();
            UpdateList();
        }
        Employee tempEmployee = new Employee();
        private void btEmployeesUpdate_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Employee!!");
            }
            ManagerEmployeeUpdate managerEmployeeUpdate = new ManagerEmployeeUpdate(tempEmployee);
            managerEmployeeUpdate.ShowDialog();
            UpdateList();
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count > 0)
            {
                ListViewItem listViewItem = lvEmployees.SelectedItems[0];
                Employee selectedEmployee = (Employee)listViewItem.Tag;
                tempEmployee.EmployeeId = selectedEmployee.EmployeeId;
                tempEmployee.FirstName = selectedEmployee.FirstName;
                tempEmployee.LastName = selectedEmployee.LastName;
                tempEmployee.UserName = selectedEmployee.UserName;
                tempEmployee.EmployeeType = selectedEmployee.EmployeeType;
            }
        }

        private void btEmployeesRemove_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Employee!!");
            }
            EmployeeService employeeService = new EmployeeService();

            DialogResult result = MessageBox.Show("Are you sure you want to remove this Employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                employeeService.DeleteEmployee(tempEmployee);
            }

            UpdateList();
        }
    }
}
