using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChapeauModel.Order;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        Employee employee;
        TableService tableService;
        List<Table> tables;
        Dictionary<Button, Table> buttonDictionary;

        public TableOverview(Employee employee)
        {
            this.employee = employee;

            tables = new List<Table>();
            tableService = new TableService();
            tables = tableService.GetAllTables();
            buttonDictionary = new Dictionary<Button, Table>();

            InitializeComponent();

            AssigneTableButtonHandler();

            this.CenterToScreen();

            UserNamelbl.Text = $"{employee.Name}";

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.ShowDialog();
                this.Close();
            }
        }


        private void SelectedTable(int tableNumber)
        {
            this.Hide();
            TableOrderView tableOrderView = new TableOrderView(employee, tables[tableNumber]);
            tableOrderView.ShowDialog();
            this.Show();
            AssigneTableButtonHandler();


        }
        private void TableButtonClick(object sender, EventArgs e)
        {
            Button tableButton = (Button)sender;
            int tableNumber = int.Parse(tableButton.Tag.ToString());
            SelectedTable(tableNumber);
        }

        private void AssigneTableButtonHandler()
        {
            // TODO: improve
            /* List<Table> tables = tableService.GetAllTables();

             foreach (Table table in tables)
             {
                 // create button, hint dictionary
                 // create eventhandler
             }*/
            tablepanel.Controls.Clear(); // FUCKIGN LINE !!!!
            tables = tableService.GetAllTables();

            for (int i = 0; i < tables.Count; i++)
            {
                Button tableButton = new Button();
                tableButton.Text = "Table " + (i + 1);
                tableButton.Size = new Size(100, 50);
                tableButton.Location = new Point(20 * (i % 3 * 10), 10 + (i / 3) * 50);
                tableButton.Tag = i;
                tableButton.Click += TableButtonClick;
                buttonDictionary.Add(GetColour(tables[i], tableButton), tables[i]);

                // Add the button to a container

                tablepanel.Controls.Add(tableButton);
            }

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            AssigneTableButtonHandler();
        }

        private Button GetColour(Table table, Button button)
        {
            switch (table.TableStatus)
            {
                case TableStatus.Occupied:
                    button.BackColor = Color.Yellow;
                    break;
                case TableStatus.Free:
                    button.BackColor = Color.Green;
                    break;
                case TableStatus.Reserved:
                    button.BackColor = Color.Red;
                    break;
            }

            return button;
        }
    }
}
