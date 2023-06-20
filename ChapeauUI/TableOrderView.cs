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
using System.Windows.Forms.VisualStyles;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class TableOrderView : Form
    {
        private Employee employee;
        private Table table;
        private TableService tableService;
        private OrderService orderService;
        private OrderItemService orderItemService;
        private OrderItem orderItem;
        public TableOrderView(Employee employee, Table table)
        {
            this.employee = employee;
            tableService = new TableService();
            orderService = new OrderService();
            orderItemService = new OrderItemService();
            orderItem = new OrderItem();
            this.table = table;
            InitializeComponent();
            this.CenterToScreen();
            namelabel.Text = $"{employee.Name}";
            tableNumberlbl.Text = $"Table{table.TableId}";
            DisplayOrders();
            CheckTableAvailability();
        }

        // Check the availability of the table and enable/disable buttons accordingly
        private void CheckTableAvailability()
        {
            switch (table.TableStatus)
            {
                case TableStatus.Occupied:
                    OcuppiedTableButtons();
                    break;
                case TableStatus.Free:
                    FreeTableButtons();
                    break;
                default:
                    ReserveTableButtons();
                    break;
            }
        }

        private void OcuppiedTableButtons()
        {
            // Enable buttons when table is occupied
            AddOrderbtn.Enabled = true;
            FreeTableBtn.Enabled = false;
            ReserveTableBtn.Enabled = false;
            BillBtn.Enabled = true;
            serveBtn.Enabled = true;
        }

        private void FreeTableButtons()
        {
            // Disable buttons when table is free
            AddOrderbtn.Enabled = true;
            FreeTableBtn.Enabled = false;
            ReserveTableBtn.Enabled = true;
            BillBtn.Enabled = false;
            serveBtn.Enabled = false;
        }

        private void ReserveTableButtons()
        {
            AddOrderbtn.Enabled = false;
            FreeTableBtn.Enabled = true;
            ReserveTableBtn.Enabled = false;
            BillBtn.Enabled = false;
            serveBtn.Enabled = false;
        }


        // Display the orders for the current table in the ListView control
        private void DisplayOrders()
        {
            listViewOrders.Items.Clear();
            List<OrderItem> itemsList = orderItemService.GetOrderItemsByTable(table.TableId);

            foreach (OrderItem item in itemsList)
            {
                ListViewItem listItem = new ListViewItem(item.ItemName);
                listItem.SubItems.Add(item.Quantity.ToString());
                listItem.SubItems.Add(item.PricePerItem.ToString());
                listItem.SubItems.Add(item.Status.ToString());
                listItem.SubItems.Add(item.Comment.ToString());
                listItem.SubItems.Add(item.TimePlaced.ToString("%m'm'%s's'"));
                listItem.Tag = item;

                listViewOrders.Items.Add(listItem);
            }

            listViewOrders.View = View.Details;
        }

        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            // Handle the button click event to add an order
        }

        private void OccupyTableBtn_Click(object sender, EventArgs e)
        {

            table.TableStatus = TableStatus.Reserved;
            tableService.UpdateTableStatus(table);
            FreeTableButtons();

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            // Close the form when the Go Back button is clicked
            Close();


        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                // Hide the current form, show the LoginScreen form, and close the current form
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.ShowDialog();
                this.Close();
            }
        }

        private void FreeTableBtn_Click(object sender, EventArgs e)
        {
            // Free the table by updating its status
            tableService.FreeTable(table.TableId, TableStatus.Free);
            ReserveTableButtons();
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            // Show the DisplayBill form, hide the current form, and then free the table
            DisplayBill display = new DisplayBill(table);
            this.Hide();
            display.ShowDialog();
            this.Close();
            tableService.FreeTable(table.TableId, TableStatus.Free);
        }

        private void serveBtn_Click(object sender, EventArgs e)
        {
            // Update the state of the selected order item to Served and display the updated orders
            orderItemService.UpdateOrderItemState(orderItem, OrderStatus.Served);
            DisplayOrders();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected order item when the selection changes in the ListView
            if (listViewOrders.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewOrders.SelectedItems[0];
                orderItem = (OrderItem)listView.Tag;
            }
        }

    }

}

