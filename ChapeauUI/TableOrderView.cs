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
using OrderTable;

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
            UniqueLoggedInEmployee loggedEmployee = UniqueLoggedInEmployee.GetInstance();
            namelabel.Text = $"{loggedEmployee.GetEmployee().Name}";
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
                listItem.SubItems.Add($"{DateTime.Now.Subtract(item.TimePlaced).Duration()}");
                listItem.Tag = item;

                listViewOrders.Items.Add(listItem);
            }

            listViewOrders.View = View.Details;
        }

        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            Hide();
            OrderForm form = new OrderForm(table.TableId);
            form.ShowDialog();
            Show();
            DisplayOrders();

            if (listViewOrders.Items.Count > 0)
            {
                table.TableStatus = TableStatus.Occupied;
                tableService.UpdateTableStatus(table);
                OcuppiedTableButtons();
            }


        }


        private void OccupyTableBtn_Click(object sender, EventArgs e)
        {

            table.TableStatus = TableStatus.Reserved;
            tableService.UpdateTableStatus(table);
            AddOrderbtn.Enabled = false;
            FreeTableBtn.Enabled = true;

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
            FreeTableButtons();
        }

        private void serveBtn_Click(object sender, EventArgs e)
        {
            // Check if the selected order item is ready to be served
            if (orderItem.Status == OrderStatus.Ready)
            {
                // Update the state of the selected order item to Served and display the updated orders
                orderItemService.UpdateOrderItemState(orderItem, OrderStatus.Served);
                DisplayOrders();
            }
            else if (orderItem.Status == OrderStatus.Served)
            {
                MessageBox.Show("The order is already served", "Order Served", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("The order is not ready to be served yet.", "Order Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        private void BillBtn_Click(object sender, EventArgs e)
        {
            // Check if any orders are not served before generating the bill
            bool allOrdersReady = CheckAllOrdersServed();

            if (allOrdersReady)
            {

                // Show the DisplayBill form, hide the current form
                this.Hide();
                DisplayBill display = new DisplayBill(table.TableId);
                display.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Orders are not served. Please wait for all orders to be served before generating the bill.", "Orders Not Served", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckAllOrdersServed()
        {
            foreach (ListViewItem listItem in listViewOrders.Items)
            {
                OrderItem orderItem = (OrderItem)listItem.Tag;
                if (orderItem.Status != OrderStatus.Served)
                {
                    return false;
                }
            }
            return true;
        }


    }

}

