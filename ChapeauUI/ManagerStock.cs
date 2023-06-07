using ChapeauModel;
using ChapeauService;
using Org.BouncyCastle.Math.EC.Multiplier;
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
    public partial class ManagerStock : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip();
        public ManagerStock()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ManagerStock_Load(object sender, EventArgs e)
        {
            DisplayStock(GetStock());
        }

        private List<Stock> GetStock()
        {
            StockService service = new StockService();
            return service.GetStock();
        }

        private void DisplayStock(List<Stock> stock)
        {
            lvStock.Clear();

            lvStock.Columns.Add("ID", 50);
            lvStock.Columns.Add("Name", 400);
            lvStock.Columns.Add("Quantity", 100);

            foreach (Stock st in stock)
            {
                ListViewItem li = new ListViewItem(st.StockID.ToString());
                li.SubItems.Add(st.StockName.ToString());
                li.SubItems.Add(st.Quantity.ToString());

                li.Tag = st;
                lvStock.Items.Add(li);
            }

            lvStock.View = View.Details;
        }

        private void btStockAdd_Click(object sender, EventArgs e)
        {
            ManagerStockAdd managerStockAdd = new ManagerStockAdd();
            managerStockAdd.ShowDialog();
            DisplayStock(GetStock());
        }

        Stock temp = new Stock();

        private void btStockUpdate_Click(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count == 0)
                MessageBox.Show("Stock item wasn't selected");
            else
            {
                ManagerStockUpdate managerStockUpdate = new ManagerStockUpdate(temp);
                managerStockUpdate.ShowDialog();
                DisplayStock(GetStock());
            }
        }

        private void btStockRemove_Click(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count == 0)
                MessageBox.Show("Stock item wasn't selected");
            else
            {
                StockService stockService = new StockService();

                DialogResult result = MessageBox.Show("Are you sure you want to remove this Menu Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    stockService.DeleteStock(temp);
                }

                DisplayStock(GetStock());
            }
        }

        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count > 0)
            {
                ListViewItem li = lvStock.SelectedItems[0];
                temp = (Stock)li.Tag;
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
