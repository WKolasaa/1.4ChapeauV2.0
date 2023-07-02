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
        private Button selectedButton;
        private int category;

        Timer timer = new Timer();
        OrderItemService orderItemService = new OrderItemService();

        public KitchenAndBarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            // Set the name of the logged-in employee on the logout button
            btnLogout.Text = $"{employee.Name}";

            // Set the initial background color of the view buttons
            SetInitialButtonColors();

            // Load the orders and start the timer
            LoadOrders();

            StartTimer();
        }

        private void StartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void SetInitialButtonColors()
        {
            btnViewPastOrders.BackColor = Color.FromArgb(255, 224, 192); //this part makes the viewallorders button orange so you can see what orderItems there are
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 128, 0);
            btnOrdersOfToday.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void LoadOrders()
        {
            // Retrieve all the ordered items
            orderedItems = GetOrderItemsByEmployee();
            FillInListView(orderedItems);
        }

        private void FillInListView(List<OrderItem> orderItems)
        {
            orderesListView.Items.Clear();

            foreach (OrderItem orderItem in orderItems)// adds all the order items into the listview
            {
                ListViewItem item = new ListViewItem($"{orderItem.TableNumber}");
                // Calculate the elapsed time since the order was placed
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

        private List<OrderItem> GetOrderItemsByEmployee()
        {
            List<OrderItem> orderedItems = new List<OrderItem>();

            try
            {
                // Check the role of the logged-in employee
                if (employee.EmployeeType == EmployeeType.Chef)
                {
                    category = 0;
                    labelMenuBar.Text = "Kitchen Orders";
                }
                else if (employee.EmployeeType == EmployeeType.Bartender)
                {
                    category = 1;
                    labelMenuBar.Text = "Bar Orders";
                }
                //Get the ordered items by category
                orderedItems = orderItemService.GetOrderItemsByCategory(category);
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
                // Enable the "Prepared" and "In Preparation" buttons

                btnPrepared.Enabled = true;
                btnInPreparation.Enabled = true;

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
            // Change the status of the selected item to "In Preparation"
            ChangeOrderItemStatus(ChapeauModel.OrderStatus.Preparing);
            // Refresh the order list
            RefreshListView();
        }

        private void btnPrepared_Click(object sender, EventArgs e)
        {
            // Change the status of the selected item to "Prepared"
            ChangeOrderItemStatus(ChapeauModel.OrderStatus.Ready);
            // Refresh the order list
            RefreshListView();
        }

        public void RefreshListView()// Refresh the order list to redisplay orders
        {
            if (btnViewPastOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                btnViewPastOrders.PerformClick();
            }
            else if (btnViewOngoingOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                btnViewOngoingOrders.PerformClick();
            }
        }

        public void ChangeOrderItemStatus(OrderStatus changedStatus)
        {
            if (orderesListView.Items.Count > 0)
            {
                ListViewItem selectedItem = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)selectedItem.Tag;
                // Update the status of the selected item
                orderItemService.UpdateOrderItemState(orderItem, changedStatus);

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

        private void DetermineSelectedButton()
        {
            if (btnViewPastOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                selectedButton = btnViewPastOrders;
            }
            else if (btnViewOngoingOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                selectedButton = btnViewOngoingOrders;
            }
            else if (btnViewAllOrders.BackColor == Color.FromArgb(255, 128, 0))
            {
                selectedButton = btnViewAllOrders;
            }
            else
            {
                selectedButton = btnOrdersOfToday;
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


                // Check if the elapsed time is greater than 15 minutes
                if (elapsedTime.TotalMinutes > 15)
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

            // Fetch updated order items from the service
            List<OrderItem> updatedItems = GetOrderItemsByEmployee();

            DetermineSelectedButton();

            // Check if there is a change in the number of order items
            if (updatedItems.Count != orderedItems.Count)
            {
                selectedButton.PerformClick();
            }
        }

        private void ChangeButtonColor(Button button)
        {
            btnViewPastOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewOngoingOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnViewAllOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnOrdersOfToday.BackColor = Color.FromArgb(255, 224, 192);

            button.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)//changes the button color and loads orders
        {
            ChangeButtonColor(btnViewAllOrders);

            LoadOrders();
        }

        private void btnViewOngoingOrders_Click(object sender, EventArgs e)//changes the button color and reloads orders
        {// chagnge to switch when i press to go to the service layer and then the dao layeR
            ChangeButtonColor(btnViewOngoingOrders);

            List<OrderItem> ongoingOrders = orderItemService.GetOrdersWithCategoryWithoutStatusLower(category, ChapeauModel.OrderStatus.Ready);

            FillInListView(ongoingOrders);
        }

        private void btnViewPastOrders_Click(object sender, EventArgs e)//changes button color and reloads orders
        {
            ChangeButtonColor(btnViewPastOrders);

            List<OrderItem> pastOrders = orderItemService.GetOrdersWithCategoryWithoutStatusHigher(category, ChapeauModel.OrderStatus.Preparing);

            FillInListView(pastOrders);
        }

        private void btnOrdersOfToday_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnOrdersOfToday);

            LoadOrdersOfTheDay();
        }

        private void LoadOrdersOfTheDay()
        {
            DateTime todaysDate = DateTime.Today.Date;
            List<OrderItem> todaysOrders = orderItemService.GetTodaysOrdersItems(todaysDate, category);

            FillInListView(todaysOrders);
        }
    }
}