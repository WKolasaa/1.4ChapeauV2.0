using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        OrderItemService orderItemService;
        OrderItem orderItem;
        public TableOrderView(Employee employee, Table table)
        {
            this.employee = employee;
            tableService = new TableService();
            orderService = new OrderService();
            orderItemService = new OrderItemService();
            this.table = table;
            InitializeComponent();
            this.CenterToScreen();
            Userlbl.Text = $"{employee.Name}";
            tableNumberlbl.Text = $"Table{table.TableNumber}";
            CheckTableAvailability();
            DisplayOrders();
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
                AddOrderbtn.Enabled = true;
                FreeTableBtn.Enabled = false;
            }
        }
        private void DisplayOrders()
        {
            List<OrderItem> itemsList = orderItemService.GetOrderItemsByTable(table.TableNumber);


            foreach (OrderItem item in itemsList)
            {
                ListViewItem listItem = new ListViewItem(item.ItemName);
                listItem.SubItems.Add(item.OrderItemID.ToString());
                listItem.SubItems.Add(item.Quantity.ToString());
                listItem.SubItems.Add(item.PricePerItem.ToString());
                listItem.SubItems.Add(item.Status.ToString());
                listItem.SubItems.Add($"{item.Comment}");
                listItem.SubItems.Add(item.TimePlaced.ToString("%m'm'%s's'"));
                listItem.Tag = item;

                listViewOrders.Items.Add(listItem);
            }

            listViewOrders.View = View.Details;

        }


        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            table.TableStatus = TableStatus.Occupied;
            tableService.UpdateTableStatus(table);
        }

        private void OccupyTableBtn_Click(object sender, EventArgs e)
        {
            if (!orderItemService.CheckIfTableHasActiveOrders(table))
            {
                table.TableStatus = TableStatus.Reserved;
                tableService.UpdateTableStatus(table);
                AddOrderbtn.Enabled = true;
            }
            else
            {
                ReserveTableBtn.Enabled = false;
            }
        }


        private void GoBackBtn_Click(object sender, EventArgs e)
        {
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
            tableService.FreeTable(table.TableNumber, TableStatus.Free);
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            DisplayBill display = new DisplayBill(table);
            this.Hide();
            display.ShowDialog();
            this.Close();
            tableService.FreeTable(table.TableNumber, TableStatus.Free);

        }

    }
}
