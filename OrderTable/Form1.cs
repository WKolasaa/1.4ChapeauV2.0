using ChapeauDAL;
using ChapeauModel;
using ChapeauService;

namespace OrderTable
{
    public partial class Form1 : Form
    {
        public MenuDAO MenuDAO;

        public Form1()
        {
            InitializeComponent();
            MenuDAO = new MenuDAO();
        }


        //LISTS
        private List<Menu> GetMenu()
        {
            MenuService menuService = new MenuService();
            List<Menu> menuList = menuService.GetMenu();
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
        }


        private void DisplayMenuItemsLunchMain(List<Menu> menuLunch)
        {
            listViewStartersLunch.Clear();
            listViewStartersLunch.Columns.Add("Description", 150);
            listViewStartersLunch.Columns.Add("Price", 150);

            foreach (Menu menuItem in menuLunch)
            {
                if (menuItem.ItemType == "Main")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;


                    listViewStartersLunch.Items.Add(li);
                }

            }
        }

        private void DisplayMenuItemsLunchDessert(List<Menu> menuLunch)
        {
            listViewStartersLunch.Clear();
            listViewStartersLunch.Columns.Add("Description", 150);
            listViewStartersLunch.Columns.Add("Price", 150);

            foreach (Menu menuItem in menuLunch)
            {
                if (menuItem.ItemType == "Desserts")
                {
                    ListViewItem li = new ListViewItem(menuItem.Description);
                    li.SubItems.Add(menuItem.Price.ToString());
                    li.Tag = menuItem;


                    listViewStartersLunch.Items.Add(li);
                }

            }
        }


        //BUTTONS 

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string category = "Lunch";
            List<Menu> lunchItems = MenuDAO.GetMenuItemByCategory(category);
            DisplayMenuItemsLunchStarter(lunchItems);
            DisplayMenuItemsLunchMain(lunchItems);
            DisplayMenuItemsLunchDessert(lunchItems);
        }

        private void listViewStartersLunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}