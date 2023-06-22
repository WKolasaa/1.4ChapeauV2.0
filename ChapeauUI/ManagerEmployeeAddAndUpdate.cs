using ChapeauModel;
using ChapeauService;

namespace ChapeauUI;

public partial class ManagerEmployeeAdd : Form
{
    public ManagerEmployeeAdd(Employee employee)
    {
        PrepareForm("Adjust employee");
        importData(employee);
    }

    public ManagerEmployeeAdd()
    {
        PrepareForm("Add employee");
    }

    private void PrepareForm(string text)
    {
        InitializeComponent();
        cbAddEmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeType)); //loading data into ComboBox 
        txtAddEmployeePassword.UseSystemPasswordChar = true;
        CenterToScreen();
        btAddEmployee.Text = text;
    }

    private void btAddEmployee_Click(object sender, EventArgs e)
    {
        if (txtAddEmployeeFirstName.Text.Length == 0 || txtAddEmployeeLastName.Text.Length == 0 ||
            txtAddEmployeePassword.Text.Length == 0 || txtAddEmployeeUserName.Text.Length == 0)
        {
            MessageBox.Show("Field cannot be empty!");
            return;
        }

        try
        {
            EmployeeService employeeService = new EmployeeService();

            if (btAddEmployee.Text == "Add employee")
            {
                employeeService.AddEmployee(insertData());
                MessageBox.Show("Employee Added!");
            }
            else
            {
                employeeService.EditEmployee(insertData());
                MessageBox.Show("Employee Adjusted!");
            }

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private void btCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void importData(Employee employee) //import data from employee object 
    {
        try
        {
            txtAddEmployeeID.Text = employee.EmployeeId.ToString();
            txtAddEmployeeFirstName.Text = employee.FirstName;
            txtAddEmployeeLastName.Text = employee.LastName;
            cbAddEmployeeRole.SelectedItem = employee.EmployeeType;
            txtAddEmployeeUserName.Text = employee.UserName;
            txtAddEmployeePassword.Text = employee.Password;
            dateTimePicker1.Value = employee.DateOfBirth;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private Employee insertData() //insert data to temporary Employee object
    {
        Employee importedEmployee = new Employee();

        importedEmployee.FirstName = txtAddEmployeeFirstName.Text;
        importedEmployee.LastName = txtAddEmployeeLastName.Text;
        if(btAddEmployee.Text == "Adjust employee")
            importedEmployee.EmployeeId = int.Parse(txtAddEmployeeID.Text);
        importedEmployee.EmployeeType = (EmployeeType)cbAddEmployeeRole.SelectedIndex;
        importedEmployee.Password = txtAddEmployeePassword.Text;
        importedEmployee.UserName = txtAddEmployeeUserName.Text;
        importedEmployee.DateOfBirth = dateTimePicker1.Value;

        return importedEmployee;
    }
}