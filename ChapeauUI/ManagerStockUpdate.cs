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
    public partial class ManagerStockUpdate : Form
    {
        public ManagerStockUpdate(Stock stock)
        {
            InitializeComponent();
            this.CenterToScreen();
            DisplayStock(stock);
        }

        private void DisplayStock(Stock stock)
        {
            txtUpdateStockID.Text = stock.StockID.ToString();
            txtUpdateStockName.Text = stock.StockName.ToString();
            txtUpdateStockQuantity.Text = stock.Quantity.ToString();
        }

        private void btAddStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            if (int.Parse(txtUpdateStockID.Text) <= 0 || int.Parse(txtUpdateStockQuantity.Text) < 0)
            {
                MessageBox.Show("Value cannot be lover then 0!");
            }
            else
            {
                stock.StockID = int.Parse(txtUpdateStockID.Text);
                stock.StockName = txtUpdateStockName.Text;
                stock.Quantity = int.Parse(txtUpdateStockQuantity.Text);

                StockService service = new StockService();
                service.UpdateStock(stock);

                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerStockUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
