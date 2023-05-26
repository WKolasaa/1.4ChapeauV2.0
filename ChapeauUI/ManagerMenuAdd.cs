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
    public partial class ManagerMenuAdd : Form
    {
        public ManagerMenuAdd()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btAddMenu_Click(object sender, EventArgs e)
        {
            if (txtAddMenuDesciprion.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");
            if (int.Parse(txtAddMenuID.Text) < 0 || int.Parse(txtAddMenuPrice.Text) < 0)
                MessageBox.Show("Valie cannot be lover then 0!");

            else
            {
                Menu menu = new Menu();
                menu.MenuItemID = int.Parse(txtAddMenuID.Text);
                menu.Description = txtAddMenuDesciprion.Text;
                menu.Price = double.Parse(txtAddMenuPrice.Text);

                MenuService menuService = new MenuService();
                menuService.AddMenu(menu);

                MessageBox.Show("Menu Item Added!");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerMenuAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
