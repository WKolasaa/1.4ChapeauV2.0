using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace ChapeauUI
{
    public partial class KitchenAndBarUI : Form
    {
        private Employee employee;
        private List<OrderItem> orderedItems;

        Timer timer = new Timer();
        OrderItemService orderItemService = new OrderItemService();

        public KitchenAndBarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();

            btnLogout.Text = $"{employee.Name}";

            btnViewPastOrders.BackColor = Color.FromArgb(255, 224, 192); //this part makes the viewallorders button orange so you can see what orderItems there are
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 128, 0);

            LoadOrders();

            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void LoadOrders()
        {
            orderedItems = GetAllItems();
            orderesListView.Items.Clear();

            foreach (OrderItem orderItem in orderedItems)
            {
                ListViewItem item = new ListViewItem($"{orderItem.TableNumber}");

                TimeSpan timeSpan = DateTime.Now - orderItem.TimePlaced;

                item.Tag = orderItem;
                item.SubItems.Add($"{orderItem.ItemName}");
                item.SubItems.Add($"{orderItem.Quantity}");
                item.SubItems.Add($"{orderItem.Comment}");
                item.SubItems.Add(timeSpan.ToString("%m'm'%s's'"));
                item.SubItems.Add($"{orderItem.OrderItemID}");

                orderesListView.Items.Add(item);
            }

            orderesListView.View = View.Details;
        }

        private List<OrderItem> GetAllItems()
        {
            List<OrderItem> orderedItems = new List<OrderItem>();

            try
            {
                if (employee.EmployeeType == EmployeeType.Chef)
                {
                    orderedItems = orderItemService.GetAllFood();
                    labelMenuBar.Text = "Kitchen Orders";
                }
                else if (employee.EmployeeType == EmployeeType.Bartender)
                {
                    orderedItems = orderItemService.GetAllDrinks();
                    labelMenuBar.Text = "Bar Orders";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting the ordered items!", "Error", MessageBoxButtons.OK);
            }

            return orderedItems;
        }

        private void orderesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderesListView.SelectedItems.Count > 0)
            {
                btnInPreparation.Enabled = true;
                btnPrepared.Enabled = true;

                ListViewItem item = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)item.Tag;

                listViewSelectedItem.Items.Clear();

                ListViewItem item2 = new ListViewItem($"{orderItem.OrderItemID}");
                item2.SubItems.Add($"{orderItem.Status}");

                listViewSelectedItem.Items.Add(item2);
                listViewSelectedItem.View = View.Details;
            }
        }

        private void btnInPreparation_Click(object sender, EventArgs e)
        {
            buttonClick(1);

            RefreshListView();
        }
        private void btnPrepared_Click(object sender, EventArgs e)
        {
            buttonClick(2);

            RefreshListView();
        }

        public void RefreshListView()
        {
            if (btnViewPastOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                btnViewPastOrders.PerformClick();
            }
            else if (btnViewOngoingOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                btnViewOngoingOrders.PerformClick();
            }
            else if (btnViewAllOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                btnViewAllOrders.PerformClick();
            }
        }

        public void buttonClick(int changedStatus)
        {
            if (orderesListView.Items.Count > 0)
            {
                ListViewItem selectedItem = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)selectedItem.Tag;
                orderItemService.UpdateOrderItemStatus(orderItem, changedStatus);

                listViewSelectedItem.Items.Clear();

                orderItem.Status = (OrderStatus)changedStatus;
                ListViewItem item2 = new ListViewItem($"{orderItem.OrderItemID}");
                item2.SubItems.Add($"{orderItem.Status}");

                listViewSelectedItem.Items.Add(item2);
                listViewSelectedItem.View = View.Details;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        void timer_Tick(object sender, EventArgs e)
        {
            // Counter to iterate through the list of ordered items
            int counter = 0;

            // Update time on interface
            lblTime.Text = DateTime.Now.ToString("hh:mm");

            // Iterate through the ListView items
            foreach (ListViewItem item in orderesListView.Items)
            {
                // Alternates the colors in the ListView
                if (counter % 2 == 0)
                {
                    item.BackColor = Color.Orange;
                }
                else
                {
                    item.BackColor = Color.White;
                }

                // Makes the text red if an item is older than 10 minutes
                OrderItem orderItem = (OrderItem)item.Tag;
                TimeSpan elapsedTime = DateTime.Now - orderItem.TimePlaced;


                // Check if the elapsed time is greater than 10 minutes
                if (elapsedTime.TotalMinutes > 10)
                {
                    // Change the item's foreground color to red
                    item.ForeColor = Color.Red;
                }
                else
                {
                    // Reset the item's foreground color to default
                    item.ForeColor = orderesListView.ForeColor;
                }


                // Update the time since ordered for each item
                item.SubItems[4].Text = elapsedTime.ToString(@"mm'm'ss's'");

                counter++;
            }

            // Load orders if it is the first fetch
            if (orderedItems == null)
            {
                LoadOrders();
            }
            else
            {
                // Fetch updated order items from the service
                List<OrderItem> updatedItems = GetAllItems();

                // Check if there is a change in the number of order items
                if (updatedItems.Count != orderedItems.Count)
                {
                    LoadOrders();
                }
            }
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            btnViewPastOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 128, 0);

            LoadOrders();
        }

        private List<OrderItem> GetOrdersByStatus(OrderStatus status)
        {
            List<OrderItem> orders = orderedItems.Where(item => item.Status == status).ToList();
            return orders;
        }

        private void btnViewOngoingOrders_Click(object sender, EventArgs e)
        {
            btnViewPastOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 128, 0);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 224, 192);

            List<OrderItem> ongoingOrders = GetOrdersByStatus(ChapeauModel.OrderStatus.Preparing);
            UpdateOrderListView(ongoingOrders);
        }

        private void btnViewPastOrders_Click(object sender, EventArgs e)
        {
            btnViewPastOrders.BackColor = Color.FromArgb(255, 128, 0);
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 224, 192);

            List<OrderItem> pastOrders = GetOrdersByStatus(ChapeauModel.OrderStatus.Ready);
            UpdateOrderListView(pastOrders);
        }

        private void UpdateOrderListView(List<OrderItem> orders)
        {
            orderesListView.Items.Clear();

            foreach (OrderItem orderItem in orders)
            {
                ListViewItem item = new ListViewItem($"{orderItem.TableNumber}");

                TimeSpan timeSpan = DateTime.Now - orderItem.TimePlaced;

                item.Tag = orderItem;
                item.SubItems.Add($"{orderItem.ItemName}");
                item.SubItems.Add($"{orderItem.Quantity}");
                item.SubItems.Add($"{orderItem.Comment}");
                item.SubItems.Add(timeSpan.ToString("%m'm'%s's'"));
                item.SubItems.Add($"{orderItem.OrderItemID}");

                orderesListView.Items.Add(item);
            }

            orderesListView.View = View.Details;
        }
    }
}
