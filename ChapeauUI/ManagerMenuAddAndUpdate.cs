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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MenuItem = ChapeauModel.MenuItem;

namespace ChapeauUI
{
    public partial class ManagerMenuAddAndUpdate : Form
    {
        private bool AddForm;
        private MenuItem MenuItem;

        public ManagerMenuAddAndUpdate(bool Add, MenuItem menuItem)
        {
            InitializeComponent();
            CenterToScreen();
            AddForm = Add;
            MenuItem = menuItem;
            if (!AddForm)
                UpdateForm();
        }

        private void UpdateForm()
        {
            importData();
            btAddMenu.Text = "Update Menu Item";
        }

        private void btAddMenu_Click(object sender, EventArgs e)
        {
            if (txtAddMenuDesciprion.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");
            if (int.Parse(txtAddMenuID.Text) < 0 || int.Parse(txtAddMenuPrice.Text) < 0)
                MessageBox.Show("Value cannot be lover then 0!");

            else
            {
                MenuService menuService = new MenuService();
                if (AddForm)
                {
                    MenuItem menu = insertData();
                    menuService.AddMenu(menu);
                    MessageBox.Show("Menu Item Added!");
                }
                else
                {
                    MenuItem = insertData();
                    menuService.RemoveMenu(MenuItem);
                    MessageBox.Show("Menu Item Updated!");
                }
                
                Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importData()
        {
            txtAddMenuID.Text = MenuItem.MenuItemID.ToString();
            txtAddMenuDesciprion.Text = MenuItem.Description;
            txtAddMenuPrice.Text = MenuItem.Price.ToString();
        }

        private MenuItem insertData()
        {
            MenuItem tempMenu = new MenuItem();

            tempMenu.MenuItemID = int.Parse(txtAddMenuID.Text);
            tempMenu.Description = txtAddMenuDesciprion.Text;
            tempMenu.Price = double.Parse(txtAddMenuPrice.Text);

            return tempMenu;
        }
    }
}
