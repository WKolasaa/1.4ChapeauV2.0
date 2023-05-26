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
    public partial class ManagerMenu : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();
        Menu temp = new Menu();
        public ManagerMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            DisplayMenu(GetMenu());
        }

        private List<Menu> GetMenu()
        {
            MenuService menuService = new MenuService();
            return menuService.GetMenu();
        }

        private void DisplayMenu(List<Menu> Menu)
        {
            lvMenu.Clear();

            lvMenu.Columns.Add("Item ID", 50);
            lvMenu.Columns.Add("Name", 550);
            lvMenu.Columns.Add("Price", 100);

            foreach (Menu m in Menu)
            {
                ListViewItem li = new ListViewItem(m.MenuItemID.ToString());
                li.SubItems.Add(m.Description.ToString());
                li.SubItems.Add($"{m.Price:0.00}€");

                li.Tag = m;
                lvMenu.Items.Add(li);
            }

            lvMenu.View = View.Details;
        }

        private void btMenuAdd_Click(object sender, EventArgs e)
        {
            ManagerMenuAdd managerMenuAdd = new ManagerMenuAdd();
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
                ManagerMenuUpdate managerMenuUpdate = new ManagerMenuUpdate(temp);
                managerMenuUpdate.ShowDialog();
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
                    menuService.RemoveMenu(temp);
                }

                DisplayMenu(GetMenu());
            }
        }

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMenu.SelectedIndices.Count > 0)
            {
                ListViewItem listViewItem = lvMenu.SelectedItems[0];
                temp = (Menu)listViewItem.Tag;
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }
    }
}
