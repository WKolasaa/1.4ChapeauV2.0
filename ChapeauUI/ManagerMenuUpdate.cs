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
using Menu = ChapeauModel.Menu;

namespace ChapeauUI
{
    public partial class ManagerMenuUpdate : Form
    {
        Menu menu;
        public ManagerMenuUpdate(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.CenterToScreen();
        }

        private void ManagerMenuUpdate_Load(object sender, EventArgs e)
        {
            txtAddMenuID.Text = menu.MenuItemID.ToString();
            txtAddMenuDesciprion.Text = menu.Description.ToString();
            txtAddMenuPrice.Text = menu.Price.ToString();
        }

        private void btUpdateMenu_Click_1(object sender, EventArgs e)
        {
            if (txtAddMenuDesciprion.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");
            if (int.Parse(txtAddMenuID.Text) < 0 || int.Parse(txtAddMenuPrice.Text) < 0)
                MessageBox.Show("Valie cannot be lover then 0!");

            else
            {
                menu.MenuItemID = int.Parse(txtAddMenuID.Text);
                menu.Description = txtAddMenuDesciprion.Text;
                menu.Price = double.Parse(txtAddMenuPrice.Text);

                MenuService menuService = new MenuService();
                //menuService.UpdateMenu(menu);

                this.Close();

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
