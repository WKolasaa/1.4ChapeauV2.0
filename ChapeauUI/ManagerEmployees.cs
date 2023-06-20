using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerEmployees : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();
        public ManagerEmployees()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void ManagerEmployees_Load(object sender, EventArgs e)
        {
            DisplayEmployees(GetEmployees());
        }

        private List<Employee> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetAllEmployees();
            return employees;
        }

        private void DisplayEmployees(List<Employee> employees)
        {
            lvEmployees.Items.Clear();

            foreach (Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.EmployeeId.ToString());
                li.SubItems.Add(employee.Name);
                li.SubItems.Add(employee.UserName);
                li.SubItems.Add(employee.DateOfBirth.ToShortDateString());
                li.SubItems.Add(employee.EmployeeType.ToString());

                li.Tag = employee;
                lvEmployees.Items.Add(li);
            }
        }

        private void btEmployeesAdd_Click(object sender, EventArgs e)
        {
            ManagerEmployeeAdd form = new ManagerEmployeeAdd(true, tempEmployee);
            form.ShowDialog();
            DisplayEmployees(GetEmployees());
        }

        Employee tempEmployee;

        private void btEmployeesUpdate_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Employee!!");
            }
            else
            {
                ManagerEmployeeAdd form = new ManagerEmployeeAdd(false, tempEmployee);
                form.ShowDialog();
                DisplayEmployees(GetEmployees());
            }
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count > 0)
            {
                ListViewItem listViewItem = lvEmployees.SelectedItems[0];
                tempEmployee = (Employee)listViewItem.Tag;
            }
        }

        private void btEmployeesRemove_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Employee!!");
            }
            else
            {
                EmployeeService employeeService = new EmployeeService();

                DialogResult result = MessageBox.Show("Are you sure you want to remove this Employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        employeeService.DeleteEmployee(tempEmployee);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                DisplayEmployees(GetEmployees());
            }

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMainView(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenStockView(this);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }
    }
}
