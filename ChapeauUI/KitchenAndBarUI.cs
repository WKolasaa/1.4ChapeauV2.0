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

namespace ChapeauUI
{
    public partial class KitchenAndBarUI : Form
    {
        private Employee employee;
        private List<OrderItem> orderedItems;

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

                item.Tag = orderItem;
                item.SubItems.Add($"{orderItem.ItemName}");
                item.SubItems.Add($"{orderItem.Quantity}");
                item.SubItems.Add($"{orderItem.Comment}");

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
                ListViewItem item = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)item.Tag;

                listViewSelectedItem.Items.Clear();

                ListViewItem item2 = new ListViewItem($"{orderItem.ItemName}");//change with orderItem.OrderId
                item2.SubItems.Add($"{orderItem.OrderStatus}");

                listViewSelectedItem.Items.Add(item2);
                listViewSelectedItem.View = View.Details;
            }
        }

        private void TransferSelectedItem()
        {
            if (orderesListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedOrderItem = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)selectedOrderItem.Tag;

                listViewSelectedItem.Items.Clear();

                ListViewItem selectedItem = new ListViewItem(orderItem.ItemName);
                selectedItem.SubItems.Add(orderItem.ItemName);
                selectedItem.SubItems.Add(orderItem.Quantity.ToString());

                listViewSelectedItem.Items.Add(selectedItem);
                listViewSelectedItem.View = View.Details;
            }
        }

        private void orderesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //TransferSelectedItem();
        }

        private void btnInPreparation_Click(object sender, EventArgs e)
        {
            if (listViewSelectedItem.Items.Count > 0)
            {
                ListViewItem selectedItem = listViewSelectedItem.Items[0];
                OrderItem orderItem = (OrderItem)selectedItem.Tag;
                //orderItem.OrderStatus = OrderStatus.;
                //orderItemService.UpdateOrderItem(orderItem);
                LoadOrders();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new LoginScreen();
            this.Hide();
            form.Show();
        }
    }

    /*
    public partial class KitchenAndBarUI : Form
    {
        private Employee employee;

        OrderItemService orderItemService = new OrderItemService();

        List<OrderItem> orderedItems;

        public KitchenAndBarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            btnLogout.Text = $"{employee.Name}";
            LoadOrders();
        }

        //make me a method where i show the select item From the orderesListView into listViewSelectedItem
        private void orderesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderesListView.SelectedItems.Count > 0)
            {
                ListViewItem item = orderesListView.SelectedItems[0];
                OrderItem orderItem = (OrderItem)item.Tag;

                listViewSelectedItem.Items.Clear();

                ListViewItem item2 = new ListViewItem($"{orderItem.TableNumber}");
                item2.SubItems.Add($"{orderItem.ItemName}");
                item2.SubItems.Add($"{orderItem.Quantity}");
                item2.SubItems.Add($"{orderItem.Comment}");

                listViewSelectedItem.Items.Add(item2);
                listViewSelectedItem.View = View.Details;
            }
        }

        private List<OrderItem> GetAllItems()
        {
            List<OrderItem> orderedItems = new List<OrderItem>();

            //orderedItems = orderItemService.GetAllFood();

            try
            {
                if (employee.EmployeeType == EmployeeType.Chef)
                {
                    orderedItems = orderItemService.GetAllFood();
                    labelMenuBar.Text = "Kitchen Orders";
                }
                if (employee.EmployeeType == EmployeeType.Bartender)
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


        private void LoadOrders()
        {
            List<OrderItem> orderedItems = GetAllItems();
            orderesListView.Items.Clear();


            foreach (OrderItem orderItem in orderedItems)
            {
                ListViewItem item = new ListViewItem($"{orderItem.TableNumber}");

                item.Tag = orderItem;
                item.SubItems.Add($"{orderItem.ItemName}");
                item.SubItems.Add($"{orderItem.Quantity}");
                item.SubItems.Add($"{orderItem.Comment}");

                orderesListView.Items.Add(item);

                orderesListView.View = View.Details;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new LoginScreen();
            this.Hide();
            form.Show();
        }

        private void btnInPreparation_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = (OrderItem)listViewSelectedItem.Tag;
            // orderItem.OrderStatus = OrderStatus.InPreparation;
            // orderItemService.UpdateOrderItem(orderItem);
            LoadOrders();
        }

        private void orderesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (orderesListView.Items.Count > 0)
            {
                // Retrieves the value in the tag of a selected row back to an item from the class OrderItem
                OrderItem orderItem = (OrderItem)orderesListView.SelectedItems[0].Tag;

                ListViewItem item = new ListViewItem($"{orderItem.ItemName}");//change this to ID
                item.Tag = orderItem;
                item.SubItems.Add($"{orderItem.OrderStatus}");


                listViewSelectedItem.Items.Add(item);

                listViewSelectedItem.View = View.Details;
            }
        }
    }
    */
}
