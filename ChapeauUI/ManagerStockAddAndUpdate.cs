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
    public partial class ManagerStockAddAndUpdate : Form
    {
        private bool AddForm;
        private Stock stockItem;

        public ManagerStockAddAndUpdate(bool Add, Stock stock)
        {
            InitializeComponent();
            CenterToScreen();
            AddForm = Add;
            stockItem = stock;
            if (!AddForm)
                UpdateForm();
        }

        private void UpdateForm()
        {
            importData();
            btAddStock.Text = "Update Stock Item";
        }

        private void btAddStock_Click(object sender, EventArgs e)
        {
            if (txtAddStockName.Text.Length == 0)
                MessageBox.Show("Field cannot be empty!");
            if (int.Parse(txtAddStockID.Text) < 0 || int.Parse(txtAddStockQuantity.Text) < 0)
                MessageBox.Show("value cannot be lower then 0!");

            else
            {
                StockService stockService = new StockService();

                if (AddForm)
                {
                    Stock stock = insertData();

                    stockService.AddStock(stock);

                    MessageBox.Show("Stock Item Added!");
                }
                else
                {
                    stockItem = insertData();

                    stockService.UpdateStock(stockItem);

                    MessageBox.Show("Stock Item Updated!");
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
            txtAddStockID.Text = stockItem.StockID.ToString();
            txtAddStockName.Text = stockItem.StockName.ToString();
            txtAddStockQuantity.Text = stockItem.Quantity.ToString();
        }

        private Stock insertData()
        {
            Stock stock = new Stock();
            stock.StockID = int.Parse(txtAddStockID.Text);
            stock.StockName = txtAddStockName.Text;
            stock.Quantity = int.Parse(txtAddStockQuantity.Text);

            return stock;
        }
    }
}
