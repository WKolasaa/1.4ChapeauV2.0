using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class DisplayBill : Form
    {
       private int tableNumber;
        public DisplayBill(int tableNumber)
        {
            this.tableNumber = tableNumber; 
            InitializeComponent();
            this.CenterToScreen();
        }

        private List<OrderItem> GetBill()
        {
            PaymentService paymentService = new PaymentService();
            List<OrderItem> itemsInsideBill = paymentService.GetItemsByTableNumber(tableNumber);
            return itemsInsideBill;
        }

        private void DisplayBillItems(List<OrderItem> orderItems)
        {
            ListViewBill.Clear();
            ListViewBill.Columns.Add("Quantity", 170);
            ListViewBill.Columns.Add("Item", 200);
            ListViewBill.Columns.Add("Comment", 200);
            ListViewBill.Columns.Add("Price", 130);
            ListViewBill.Columns.Add("VatAmount", 200);

            foreach (OrderItem item in orderItems)
            {
                ListViewItem listView = new ListViewItem(item.Quantity.ToString());
                listView.SubItems.Add(item.ItemName);
                listView.SubItems.Add(item.Comment);
                decimal totalPrice = item.PricePerItem * item.Quantity;
                listView.SubItems.Add(totalPrice.ToString());
                decimal vatAmount = VATPerItem(item);
                listView.SubItems.Add(vatAmount.ToString("0.00"));

                listView.Tag = item;
                ListViewBill.Items.Add(listView);
            }
            ListViewBill.Columns[0].Width = 170;
            ListViewBill.Columns[1].Width = 200;
            ListViewBill.Columns[2].Width = 200;
            ListViewBill.Columns[3].Width = 130;
            ListViewBill.Columns[4].Width = 200;

            ListViewBill.View = View.Details;
        }

        private void DisplayBill_Load(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = GetBill();
            DisplayBillItems(orderItems);
            DisplaypaymentDetails();
        }
        private void DisplaypaymentDetails()
        {
            lblTableNumber.Text = $"TABLE {tableNumber}";
            PaymentService paymentService = new PaymentService();

            decimal TotalPriceExcludeVat = paymentService.CalculateTotalPriceWithoutVAT(tableNumber);
            lblAmountExcludeVAT.Text = TotalPriceExcludeVat.ToString("€ 0.00");

            decimal TotalVAT = paymentService.TotalVat(tableNumber);
            lblTotalVAT.Text = TotalVAT.ToString("€ 0.00");

            decimal totalAmount = TotalPriceExcludeVat + TotalVAT;
            lblResultPriceWithVAT.Text = totalAmount.ToString("€ 0.00");
        }

        private decimal VATPerItem(OrderItem item)
        {
            PaymentService paymentService = new PaymentService();
            decimal vatPerItem = paymentService.VATPerItem(item);
            return vatPerItem;
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayPaymentMethod paymentMethod = new DisplayPaymentMethod(tableNumber);
            paymentMethod.ShowDialog();
            this.Close();
        }
    }
}
