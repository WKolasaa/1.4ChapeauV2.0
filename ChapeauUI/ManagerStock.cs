using System.Collections;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerStock : Form
    {
        ManagerMenuStip strip = new ManagerMenuStip(); 
        Stock temp;

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

        private void DisplayStock(List<Stock> stock) //displaying list of stock objects
        {
            lvStock.Items.Clear();

            foreach (Stock st in stock)
            {
                ListViewItem li = new ListViewItem(st.StockID.ToString());
                li.SubItems.Add(st.StockName);
                li.SubItems.Add(st.Quantity.ToString());

                li.Tag = st;
                lvStock.Items.Add(li);
            }
            lvStock.View = View.Details;
        }

        private void btStockAdd_Click(object sender, EventArgs e)
        {
            ManagerStockAddAndUpdate managerStockAdd = new ManagerStockAddAndUpdate(true, temp);
            managerStockAdd.ShowDialog();
            DisplayStock(GetStock());
        }



        private void btStockUpdate_Click(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count == 0)
                MessageBox.Show("Stock item wasn't selected");
            else
            {
                ManagerStockAddAndUpdate managerStockAdd = new ManagerStockAddAndUpdate(false, temp);
                managerStockAdd.ShowDialog();
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
                    try
                    {
                        stockService.DeleteStock(temp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strip.OpenMenuView(this);
        }
    }
}
