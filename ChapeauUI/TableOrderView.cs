using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class TableOrderView : Form
    {
        Employee employee;
        Table table;
        TableService tableService;
        OrderService orderService;

        public TableOrderView(Employee employee, Table table)
        {
            this.employee = employee;
            tableService = new TableService();
            orderService = new OrderService();
            this.table = table;
            InitializeComponent();
            this.CenterToScreen();

            Userlbl.Text = $"{employee.Name}";
            CheckTableAvailability();

        }

        private void CheckTableAvailability()
        {
            if (table.TableStatus == TableStatus.Occupied)
            {
                AddOrderbtn.Enabled = true;
                FreeTableBtn.Enabled = false;
                ReserveTableBtn.Enabled = false;

            }
            else if (table.TableStatus == TableStatus.Reserved)
            {
                ReserveTableBtn.Enabled = false;
                BillBtn.Enabled = false;
                AddOrderbtn.Enabled = false;

            }
            else
            {
                BillBtn.Enabled = false;
                AddOrderbtn.Enabled = true;
                FreeTableBtn.Enabled = false;
            }
        }
        private void DisplayOrders(List<OrderItem> orderItems)//Waiting on getOrder
        {



        }


        private void AddOrderbtn_Click(object sender, EventArgs e)//waiting for Orders
        {

            table.TableStatus = TableStatus.Occupied;
            tableService.UpdateTableStatus(table);


        }

        private void OccupyTableBtn_Click(object sender, EventArgs e)
        {
            table.TableStatus = TableStatus.Reserved;
            tableService.UpdateTableStatus(table);
            AddOrderbtn.Enabled = true;

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverview displayTables = new TableOverview(employee);
            displayTables.ShowDialog();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
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

        private void FreeTableBtn_Click(object sender, EventArgs e)
        {
            table.TableStatus = TableStatus.Free;
            tableService.UpdateTableStatus(table);


        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            DisplayBill display = new DisplayBill();
            this.Hide();
            display.ShowDialog();
            this.Close();
            table.TableStatus = TableStatus.Free;
            tableService.UpdateTableStatus(table);



        }
    }

}
