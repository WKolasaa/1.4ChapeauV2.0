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
using System.Windows.Forms;
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
            LoadOrders();
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
        }
        private void btnPrepared_Click(object sender, EventArgs e)
        {
            buttonClick(2);
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

      /*  private void KitchenAndBarUI_Load(object sender, EventArgs e)
        {
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
      */



        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnViewOngoingOrders_Click(object sender, EventArgs e)
        {
            List<OrderItem> ongoingOrders = orderedItems.Where(item => item.Status != ChapeauModel.OrderStatus.Ready).ToList();
            UpdateOrderListView(ongoingOrders);
        }

        private void btnViewPastOrders_Click(object sender, EventArgs e)
        {
            List<OrderItem> pastOrders = orderedItems.Where(item => item.Status == ChapeauModel.OrderStatus.Ready).ToList();
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
