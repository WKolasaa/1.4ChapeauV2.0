using ChapeauDAL;
using ChapeauModel;
using ChapeauService;

namespace OrderTable
{
    public partial class Form1 : Form
    {
        public MenuDAO MenuDAO;
        public MenuService MenuService;

        public Form1()
        {
            InitializeComponent();
            MenuDAO = new MenuDAO();
            MenuService = new MenuService();
        }

        //LISTS
        private List<MenuItem> GetMenu()
        {
            List<MenuItem> menuList = MenuService.GetMenu();
            return menuList;
        }

        //DISPLAYING THE LISTS

        private void DisplayMenuItemsStarter(List<MenuItem> menu)
        {
            listViewStarters.Clear();
            listViewStarters.Columns.Add("Description", 150);
            listViewStarters.Columns.Add("Price", 150);

            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.ItemType == "Starter")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;

                    listViewStarters.Items.Add(li);
                }
            }

            listViewStarters.View = View.Details;
        }
        private void DisplayMenuItemsMain(List<MenuItem> menu)
        {
            listViewMain.Clear();
            listViewMain.Columns.Add("Description", 150);
            listViewMain.Columns.Add("Price", 150);

            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.ItemType == "Main")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;

                    listViewMain.Items.Add(li);
                }
            }

            listViewMain.View = View.Details;
        }

        private void DisplayMenuItemsDessert(List<MenuItem> menu)
        {
            listViewDessert.Clear();
            listViewDessert.Columns.Add("Description", 150);
            listViewDessert.Columns.Add("Price", 150);

            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.ItemType == "Desserts")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;

                    listViewDessert.Items.Add(li);
                }
            }

            listViewDessert.View = View.Details;
        }



        //BUTTONS 

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string category = "Lunch";
            List<MenuItem> lunchItems = MenuService.GetMenuByCategory(category);
            DisplayMenuItemsStarter(lunchItems);
            DisplayMenuItemsMain(lunchItems);
            DisplayMenuItemsDessert(lunchItems);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            string category = "Diner";
            List<MenuItem> dinnerItems = MenuService.GetMenuByCategory(category);
            DisplayMenuItemsStarter(dinnerItems);
            DisplayMenuItemsMain(dinnerItems);
            DisplayMenuItemsDessert(dinnerItems);
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            OrderItemService orderItemService = new OrderItemService();
            if (listViewMain.SelectedItems.Count > 0 || listViewStarters.SelectedItems.Count > 0 || listViewDessert.SelectedItems.Count > 0)
            {
                /* ListViewItem selectedItem = listViewMain.SelectedItems[0];
                 //selectedItem = listViewDessert.SelectedItems[0];
                 //selectedItem = listViewStarters.SelectedItems[0];


                 Menu selectedMenuItem = new Menu()
                 {
                     Description = selectedItem.SubItems[0].Text,
                     Price = float.Parse(selectedItem.SubItems[1].Text),
                 };

                 OrderItem orderItem = new OrderItem()
                 {
                     MenuItem = selectedMenuItem
                 }; */

                AddSelectedItem(listViewMain.SelectedItems[0]);

            }
        }

        private void AddSelectedItem(ListViewItem selectedItem)
        {
            string itemName = selectedItem.SubItems[0].Text;
            string price = selectedItem.SubItems[1].Text;

            ListViewItem orderItem = new ListViewItem(itemName);
            orderItem.SubItems.Add(price);
            orderListView.Items.Add(orderItem); 
        }


        /*   private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
           {

           } */
    }

}