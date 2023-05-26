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
    public partial class ManagerStockAdd : Form
    {
        public ManagerStockAdd()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btAddStock_Click(object sender, EventArgs e)
        {
            if (txtAddStockName.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");
            if (int.Parse(txtAddStockID.Text) < 0 || int.Parse(txtAddStockQuantity.Text) < 0)
                MessageBox.Show("value cannot be lower then 0!");

            else
            {
                Stock stock = new Stock();
                stock.StockID = int.Parse(txtAddStockID.Text);
                stock.StockName = txtAddStockName.Text;
                stock.Quantity = int.Parse(txtAddStockQuantity.Text);

                StockService stockService = new StockService();
                stockService.AddStock(stock);

                MessageBox.Show("Stock Item Added!");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerStockAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
