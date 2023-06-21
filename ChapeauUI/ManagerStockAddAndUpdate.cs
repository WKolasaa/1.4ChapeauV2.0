using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerStockAddAndUpdate : Form
    {
        private readonly bool AddForm;
        private Stock stockItem;

        public ManagerStockAddAndUpdate(bool Add, Stock stock)
        {
            InitializeComponent();
            CenterToScreen();
            AddForm = Add;
            stockItem = stock;
            if (!AddForm) //checks if user pressed add or adjust button 
                UpdateForm();
        }

        private void UpdateForm()
        {
            try
            {
                importData();
                btAddStock.Text = "Adjust Stock Item";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddStockName.Text.Length == 0)
                {
                    throw new Exception("Field cannot be empty!");
                }
                if (int.Parse(txtAddStockID.Text) < 0 || int.Parse(txtAddStockQuantity.Text) < 0)
                    throw new Exception("value cannot be lower then 0!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
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

                    MessageBox.Show("Stock Item Adjusted!");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importData() //import data from stock object
        {
            txtAddStockID.Text = stockItem.StockID.ToString();
            txtAddStockName.Text = stockItem.StockName;
            txtAddStockQuantity.Text = stockItem.Quantity.ToString();
        }

        private Stock insertData() //insert data into temporary object
        {
            Stock stock = new Stock();
            stock.StockID = int.Parse(txtAddStockID.Text);
            stock.StockName = txtAddStockName.Text;
            stock.Quantity = int.Parse(txtAddStockQuantity.Text);

            return stock;
        }
    }
}
