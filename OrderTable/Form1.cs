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
        private List<Menu> GetMenu()
        {
            List<Menu> menuList = MenuService.GetMenu();
            return menuList;
        }


        //DISPLAYING THE LISTS

        private void DisplayMenuItemsLunchStarter(List<Menu> menuLunch)
        {
            listViewStartersLunch.Clear();
            listViewStartersLunch.Columns.Add("Description", 150);
            listViewStartersLunch.Columns.Add("Price", 150);

            foreach (Menu menuItem in menuLunch)
            {
                if (menuItem.ItemType == "Starter")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;

                    listViewStartersLunch.Items.Add(li);
                }
            }

            listViewStartersLunch.View = View.Details;
        }

        private void DisplayMenuItemsLunchMain(List<Menu> menuLunch)
        {
            listViewMain.Clear();
            listViewMain.Columns.Add("Description", 150);
            listViewMain.Columns.Add("Price", 150);

            foreach (Menu menuItem in menuLunch)
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

        private void DisplayMenuItemsLunchDessert(List<Menu> menuLunch)
        {
            listViewDessert.Clear();
            listViewDessert.Columns.Add("Description", 150);
            listViewDessert.Columns.Add("Price", 150);

            foreach (Menu menuItem in menuLunch)
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
            List<Menu> lunchItems = MenuService.GetMenuByCategory(category);
            DisplayMenuItemsLunchStarter(lunchItems);
            DisplayMenuItemsLunchMain(lunchItems);
            DisplayMenuItemsLunchDessert(lunchItems);
        }

        private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}