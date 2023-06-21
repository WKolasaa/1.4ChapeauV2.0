using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerMainView : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();

        public ManagerMainView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btManagerEmployees_Click(object sender, EventArgs e)
        {
            strip.OpenEmployeesView(this);
        }

        private void btMenuEmployees_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }

        private void btStockEmployees_Click(object sender, EventArgs e)
        {
            strip.OpenStockView(this);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenEmployeesView(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenStockView(this);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }

        private void ManagerMainView_Load(object sender, EventArgs e)
        {
            UniqueLoggedInEmployee loggedEmployee = UniqueLoggedInEmployee.GetInstance(); //Get instance of employee
            Employee employee = loggedEmployee.GetEmployee();

            lbUser.Text = $"Welcome {employee.Name}!";
            PaymentService service = new PaymentService();
            lbIncome.Text = $"{service.TodayIncome()}€";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
            this.Close();
        }

    }
}
