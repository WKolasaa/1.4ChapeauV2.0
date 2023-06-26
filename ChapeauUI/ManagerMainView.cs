using System.Transactions;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public enum Income
    {
        Today,
        Yesterday,
        ThisWeek,
        LastWeek,
        ThisMonth,
        LastMonth,
        ThisYear,
        LastYear,
        Custom
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
            decimal amount = 0;
            string when = "";

            if ((Income)cbIncome.SelectedItem != Income.Custom)
                pnCustom.Hide();

            Dictionary<Income, (DateTime start, DateTime end, string label)> Dictonary = GetDictionary();

            if (Dictonary.TryGetValue((Income)cbIncome.SelectedValue, out var incomeMapping))
            {
                amount = service.Income(incomeMapping.start, incomeMapping.end);
                when = incomeMapping.label;
            }
            else if ((Income)cbIncome.SelectedValue == Income.Custom)
            {
                pnCustom.Show();
                amount = service.Income(dtStart.Value, dtEnd.Value);
                when = "Custom's";
            }
            else
            {
                label1.Text = "Select a valid value!";
                return;
            }

            label1.Text = $"{when} Income: €{amount}";
        }

        private void cbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowIncome();
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            ShowIncome();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            ShowIncome();
        }

        private Dictionary<Income, (DateTime start, DateTime end, string label)> GetDictionary()
        {
            Dictionary<Income, (DateTime start, DateTime end, string label)> temp = new Dictionary<Income, (DateTime start, DateTime end, string label)>()
                {
                    { Income.Today, (DateTime.Today, DateTime.Today, "Today's") },
                    { Income.Yesterday, (DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1), "Yesterday's") },
                    { Income.ThisMonth, (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Today, "This month's") },
                    { Income.LastMonth, (new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1), new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month - 1)), "Last month's") },
                    { Income.ThisYear, (new DateTime(DateTime.Today.Year, 1, 1), DateTime.Today, "This Year's") },
                    { Income.ThisWeek, (DateTime.Today.AddDays(-7), DateTime.Today, "This week's") },
                    { Income.LastWeek, (DateTime.Today.AddDays(-14), DateTime.Today.AddDays(-8), "Last week's") },
                    { Income.LastYear, (new DateTime(DateTime.Now.Year - 1, 1, 1), new DateTime(DateTime.Now.Year - 1, 12, 31), "Last Year's") }
                };

            return temp;
        }
    }
}
