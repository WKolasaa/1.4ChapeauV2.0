using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public enum Income
    {
        today, yesterday, thisWeek, lastWeek, thisMonth, lastMonth, thisYear
    }
    public partial class ManagerMainView : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();

        public ManagerMainView()
        {
            InitializeComponent();
            this.CenterToScreen();
            cbIncome.DataSource = Enum.GetValues(typeof(Income));
        }

        private void btManagerEmployees_Click(object sender, EventArgs e)
        {
            strip.OpenEmployeesView(this);
        }

        private void btMenuEmployees_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenEmployeesView(this);
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
            ShowIncome();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
            this.Close();
        }

        private void ShowIncome()
        {
            PaymentService service = new PaymentService();
            DateTime date;
            decimal amount;
            switch (cbIncome.SelectedValue)
            {
                case Income.today:
                    date = DateTime.Today;
                    amount = service.Income(date, date);
                    label1.Text = $"Today's Income: €{amount}";
                    break;
                case Income.yesterday:
                    date = DateTime.Today.AddDays(-1);
                    amount = service.Income(date, date);
                    label1.Text = $"Yesterday's Income: €{amount}";
                    break;
                case Income.thisMonth:
                    date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    amount = service.Income(date, DateTime.Today);
                    label1.Text = $"This Month's Income: €{amount}";
                    break;
                case Income.lastMonth:
                    date = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
                    amount = service.Income(date, new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month - 1)));
                    label1.Text = $"Last Month's Income: €{amount}";
                    break;
                case Income.thisYear:
                    date = new DateTime(DateTime.Today.Year, 1, 1);
                    amount = service.Income(date, DateTime.Today);
                    label1.Text = $"This Year's Income: €{amount}";
                    break;
                case Income.thisWeek:
                    date = DateTime.Today.AddDays(-7);
                    amount = service.Income(date, DateTime.Today);
                    label1.Text = $"This Year's Income: €{amount}";
                    break;
                case Income.lastWeek:
                    date = DateTime.Today.AddDays(-14);
                    amount = service.Income(date, DateTime.Today.AddDays(-8));
                    label1.Text = $"This Year's Income: €{amount}";
                    break;
            }
        }

        private void cbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowIncome();
        }
    }
}
