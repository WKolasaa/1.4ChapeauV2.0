using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerMenu : Form
    {
        private ManagerMenuStip strip = new ManagerMenuStip();
        private MenuItem temp;

        public ManagerMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayMenu(GetMenu());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<MenuItem> GetMenu()
        {
            MenuService menuService = new MenuService();
            return menuService.GetMenu();
        }

        private void DisplayMenu(List<MenuItem> Menu)
        {
            lvMenu.Items.Clear();

            foreach (MenuItem m in Menu)
            {
                ListViewItem li = new ListViewItem(m.MenuItemID.ToString());
                li.SubItems.Add(m.Description);
                li.SubItems.Add($"{m.Price:0.00}€");
                if (m.VAT_Category)
                    li.SubItems.Add("21%");
                else
                    li.SubItems.Add("6%");
                li.SubItems.Add(m.ItemType.ToString());

                li.Tag = m;
                lvMenu.Items.Add(li);
            }
        }

        private void btMenuAdd_Click(object sender, EventArgs e)
        {
            ManagerMenuAddAndUpdate managerMenuAdd = new ManagerMenuAddAndUpdate(true, temp);
            managerMenuAdd.ShowDialog();
            DisplayMenu(GetMenu());
        }

        private void btMenuUpdate_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Menu Item!!");
            }
            else
            {
                ManagerMenuAddAndUpdate managerMenuAdd = new ManagerMenuAddAndUpdate(false, temp);
                managerMenuAdd.ShowDialog();
                DisplayMenu(GetMenu());
            }
        }

        private void btMenuRemove_Click(object sender, EventArgs e)
        {
            if (lvMenu.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select Menu Item!!");
            }
            else
            {
                MenuService menuService = new MenuService();

                DialogResult result = MessageBox.Show("Are you sure you want to remove this Menu Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        menuService.RemoveMenu(temp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                DisplayMenu(GetMenu());
            }
        }

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMenu.SelectedIndices.Count > 0)
            {
                ListViewItem listViewItem = lvMenu.SelectedItems[0];
                temp = (MenuItem)listViewItem.Tag;
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMainView(this);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenEmployeesView(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenStockView(this);
        }
    }
}
