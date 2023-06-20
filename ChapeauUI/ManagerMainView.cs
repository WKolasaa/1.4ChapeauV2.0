using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerMainView : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();
        Employee employee;
        public ManagerMainView(Employee employee)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.employee = employee;
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

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMainView(this);
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
            lbUser.Text = $"Welcome {employee.Name}!";
            PaymentService service = new PaymentService();
            lbIncome.Text = $"{service.TodayIncome()}€";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            //loginScree = null;
            loginScreen.ShowDialog();
            this.Close();
        }
    }
}
