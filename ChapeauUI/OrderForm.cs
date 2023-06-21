using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using ChapeauDAL;
using ChapeauModel;
using ChapeauService;
using Org.BouncyCastle.Asn1.Esf;

namespace OrderTable
{
    public partial class OrderForm : Form
    {
        private MenuService MenuService;
        private OrderItemService OrderItemService;
        private OrderItem itemFromListView;
        private List<OrderItem> order;
        private int TableNumber;
        private string comment = "";
        private OrderItem selectedOrderItem;
        private DateTime Now;

        public OrderForm(int tableNumber)
        {
            InitializeComponent();
            Now = DateTime.Now;
            MenuService = new MenuService();
            DisplayMenuItems(GetMenu());
            pnComment.Hide();
            order = new List<OrderItem>();
            TableNumber = tableNumber;
            OrderItemService = new OrderItemService();
        }

        //LISTS
        private List<MenuItem> GetMenu()
        {
            List<MenuItem> menuList = MenuService.GetMenu();
            return menuList;
        }

        //DISPLAYING THE LISTS

        private void DisplayMenuItems(List<MenuItem> menu)
        {
            listView1.Items.Clear();
            foreach (MenuItem item in menu)
            {
                ListViewItem li = new ListViewItem(item.Description);
                li.SubItems.Add($"{item.Price:0.00}€");
                li.SubItems.Add(item.ItemType.ToString());

                li.Tag = item;
                listView1.Items.Add(li);
            }
        }

        private void DisplayOrder(List<OrderItem> order)
        {
            try
            {
                orderListView.Items.Clear();
                foreach (OrderItem item in order)
                {
                    ListViewItem li = new ListViewItem(item.ItemName);
                    li.SubItems.Add($"{item.MenuItem.Price:0.00}€");
                    li.SubItems.Add(item.Comment);

                    li.Tag = item;
                    orderListView.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BUTTONS 

        private void btnLunch_Click(object sender, EventArgs e)
        {
            List<MenuItem> lunchItems = new List<MenuItem>();
            for (int i = (int)ItemCategory.StartersLunch; i <= (int)ItemCategory.DesertLunch; i++)
            {
                lunchItems.AddRange(MenuService.GetMenuByCategory(i));
            }
            DisplayMenuItems(lunchItems);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            List<MenuItem> dinnerItems = new List<MenuItem>();
            for (int i = (int)ItemCategory.StartersDiner; i <= (int)ItemCategory.DesertDiner; i++)
            {
                dinnerItems.AddRange(MenuService.GetMenuByCategory(i));
            }
            DisplayMenuItems(dinnerItems);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            List<MenuItem> drinks = new List<MenuItem>();
            for (int i = (int)ItemCategory.SoftDrinks; i <= (int)ItemCategory.CoffeTea; i++)
            {
                drinks.AddRange(MenuService.GetMenuByCategory(i));
            }
            DisplayMenuItems(drinks);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem li = listView1.SelectedItems[0];
                MenuItem temp = (MenuItem)li.Tag;
                int category;

                if (temp.ItemType > 0 && (int)temp.ItemType < 8)
                    category = 0;
                else
                    category = 1;

                OrderItem orderItemTemp = new OrderItem()
                {
                    OrderItemID = temp.MenuItemID,
                    PricePerItem = (decimal)temp.Price,
                    TableNumber = TableNumber,
                    ItemName = temp.Description,
                    Status = OrderStatus.Ordered,
                    VatCategory = temp.VAT_Category,
                    Comment = comment,
                    Category = category,
                    MenuItem = temp,
                    Quantity = 1,
                    TimePlaced = Now,
                };

                itemFromListView = orderItemTemp;
            }
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem li = orderListView.SelectedItems[0];
                selectedOrderItem = (OrderItem)li.Tag;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            order.Add(itemFromListView);
            DisplayOrder(order);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (selectedOrderItem == null)
            {
                MessageBox.Show("Select order item!");
                return;
            }
            if (order.Count == 0)
            {
                MessageBox.Show("Order is empty!");
                return;
            }
            pnComment.Show();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (selectedOrderItem == null)
            {
                MessageBox.Show("Select order item!");
                return;
            }
            if (order.Count == 0)
            {
                MessageBox.Show("Order is empty!");
                return;
            }

            order.Remove(selectedOrderItem);
            DisplayOrder(order);
        }

        private void btSubmitComment_Click(object sender, EventArgs e)
        {
            selectedOrderItem.Comment = txtComment.Text;
            pnComment.Hide();
            DisplayOrder(order);
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            foreach (OrderItem orderItem in order)
            {
                OrderItemService.AddOrderItem(orderItem);
            }
            Close();
        }
    }

}