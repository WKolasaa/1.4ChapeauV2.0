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
    public partial class DisplayBill : Form
    {
       private int tableNumber;
        public DisplayBill(int tableNumber)
        {
            //payment = new Payment();
            this.tableNumber = tableNumber; 
            InitializeComponent();
            this.CenterToScreen();
            DisplaypaymentDetails();
        }

        private List<OrderItem> GetItemByTableNumber(int tableNumber)
        {
            PaymentService paymentService = new PaymentService();
            List<OrderItem> items = paymentService.GetItemsByTableNumber(tableNumber);
            return items;
        }

        private List<OrderItem> GetBill()
        {
            List<OrderItem> itemsInsideBill = GetItemByTableNumber(tableNumber);
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
        }
        private void DisplaypaymentDetails()
        {
            decimal TotalPriceExcludeVat = TotalPriceWithoutVAT();
            lblAmountExcludeVAT.Text = TotalPriceExcludeVat.ToString("€ 0.00");
            lblTableNumber.Text = $"TABLE {tableNumber}";
            decimal TotalVAT = TotalVat();
            lblTotalVAT.Text = TotalVAT.ToString("€ 0.00");
            decimal totalAmount = TotalAmountIncludeVAT(tableNumber);
            lblResultPriceWithVAT.Text = totalAmount.ToString("€ 0.00");
        }

        private decimal TotalPriceWithoutVAT()
        {
            PaymentService paymentService = new PaymentService();
            decimal totalAmount = paymentService.CalculateTotalPriceWithoutVAT(tableNumber);
            return totalAmount;
        }

        private decimal TotalVat()
        {
            PaymentService paymentService = new PaymentService();
            decimal totalVAT = paymentService.TotalVat(tableNumber);
            return totalVAT;
        }

        private decimal TotalAmountIncludeVAT(int tableNumber)
        {
            PaymentService paymentService = new PaymentService();
            decimal AmountIncludeVAT = paymentService.TotalAmountIncludeVAT(tableNumber);
            return AmountIncludeVAT;
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
