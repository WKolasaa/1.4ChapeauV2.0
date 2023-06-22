using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public enum Income
    {
        Today, Yesterday, ThisWeek, LastWeek, ThisMonth, LastMonth, ThisYear, LastYear
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
            decimal amount = 0;
            string when = "";
            switch (cbIncome.SelectedValue)
            {
                case Income.Today:
                    date = DateTime.Today;
                    amount = service.Income(date, date);
                    when = "Today's";
                    break;
                case Income.Yesterday:
                    date = DateTime.Today.AddDays(-1);
                    amount = service.Income(date, date);
                    when = "Yesterday's";
                    break;
                case Income.ThisMonth:
                    date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    amount = service.Income(date, DateTime.Today);
                    when = "This month's";
                    break;
                case Income.LastMonth:
                    date = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
                    amount = service.Income(date, new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month - 1)));
                    when = "Last month's";
                    break;
                case Income.ThisYear:
                    date = new DateTime(DateTime.Today.Year, 1, 1);
                    amount = service.Income(date, DateTime.Today);
                    when = "This Year's";
                    break;
                case Income.ThisWeek:
                    date = DateTime.Today.AddDays(-7);
                    amount = service.Income(date, DateTime.Today);
                    when = "This week's";
                    break;
                case Income.LastWeek:
                    date = DateTime.Today.AddDays(-14);
                    amount = service.Income(date, DateTime.Today.AddDays(-8));
                    when = "Last week's";
                    break;
                case Income.LastYear:
                    date = new DateTime(DateTime.Now.Year - 1, 1, 1);
                    amount = service.Income(date, new DateTime(DateTime.Now.Year - 1, 12, 31));
                    when = "Last Year's";
                    break;
            }
            label1.Text = $"{when} Income: €{amount}";
        }

        private void cbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowIncome();
        }
    }
}
