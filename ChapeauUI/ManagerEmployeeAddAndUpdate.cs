using ChapeauModel;
using ChapeauService;

namespace ChapeauUI;

public partial class ManagerEmployeeAdd : Form
{
    private Employee employee;
    private readonly bool AddForm;

    public ManagerEmployeeAdd(bool Add, Employee employee)
    {
        InitializeComponent();
        cbAddEmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeType)); //ComboBox 
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
        btAddEmployee.Text = "Adjust employee";
    }

    private void btAddEmployee_Click(object sender, EventArgs e)
    {
        if (txtAddEmployeeFirstName.Text.Length == 0 || txtAddEmployeeLastName.Text.Length == 0 ||
            txtAddEmployeePassword.Text.Length == 0 || txtAddEmployeeUserName.Text.Length == 0)
        {
            MessageBox.Show("Field cannot be empty!");
            return;
        }

        if (int.Parse(txtAddEmployeeID.Text) < 0)
        {
            MessageBox.Show("ID cannot be lover then 0!");
            return;
        }

        try
        {
            EmployeeService employeeService = new EmployeeService();
            if (AddForm)
            {
                var newEmployee = insertData();
                employeeService.AddEmployee(newEmployee);
                MessageBox.Show("Employee Added!");
            }
            else
            {
                employee = insertData();
                employeeService.EditEmployee(employee);
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

    private void importData()
    {
        try
        {
            txtAddEmployeeID.Text = employee.EmployeeId.ToString();
            txtAddEmployeeFirstName.Text = employee.FirstName;
            txtAddEmployeeLastName.Text = employee.LastName;
            cbAddEmployeeRole.SelectedItem = employee.EmployeeType;
            txtAddEmployeeUserName.Text = employee.UserName;
            txtAddEmployeePassword.Text = employee.Password;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
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