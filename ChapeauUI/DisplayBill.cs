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
       private const decimal HighVAT = 0.21m;//for the alcoholic
       private const decimal LowVAT = 0.06m;//for the nonAlcoholic and Food
        public DisplayBill()
        {
            InitializeComponent();
            this.CenterToScreen();

        }


        private List<Payment> GetBill()
        { 
        PaymentService paymentService =new PaymentService();
            List<Payment> payments = paymentService.GetItemsByTableNumber(2);
            return payments;
        }

        private void DisplayPayment(List<Payment> payments)
        {
            ListViewBill.Clear();
            ListViewBill.Columns.Add("Quantity", 100);
            ListViewBill.Columns.Add("Item", 200);
            ListViewBill.Columns.Add("Comment", 200);
            ListViewBill.Columns.Add("Price", 150);

            foreach (Payment payment in payments)
            {
                ListViewItem listView = new ListViewItem(payment.Quantity.ToString());
                listView.SubItems.Add(payment.itemName);
                listView.SubItems.Add(payment.Comment);
                listView.SubItems.Add(payment.ItemPrice.ToString());

                listView.Tag = payment;
                ListViewBill.Items.Add(listView);
            }
            ListViewBill.Columns[0].Width = 100;
            ListViewBill.Columns[1].Width = 200;
            ListViewBill.Columns[2].Width = 200;
            ListViewBill.Columns[3].Width = 100;

            ListViewBill.View = View.Details;
        }

        private void DisplayBill_Load(object sender, EventArgs e)
        {
            List<Payment> payments = GetBill();
            DisplayPayment(payments);
        }

        private void txtTotalPriceWithoutVat_TextChanged(object sender, EventArgs e)
        {
            decimal TotalPriceExcludeVat = TotalPriceWithoutVAT(2);
            txtTotalPriceWithoutVat.Text = TotalPriceExcludeVat.ToString();
        }

        private decimal TotalPriceWithoutVAT(int table)
        {
            PaymentService paymentService = new PaymentService();
             List<Payment> price = paymentService.GetItemsByTableNumber(table); // Retrieve items for the specific table

            decimal totalAmount = 0;

            foreach (Payment payment in price)
            {
                decimal itemTotal = payment.ItemPrice * payment.Quantity;
                totalAmount += itemTotal;
            }
            return totalAmount;
        }

        private void lblPriceExcVAT_Click(object sender, EventArgs e)
        {
            decimal TotalPriceExcludeVat = TotalPriceWithoutVAT(2);
            lblPriceExcVAT.Text = TotalPriceExcludeVat.ToString();
        }

        private void lblTotalVAT_Click(object sender, EventArgs e)
        {
            decimal TotalVAT=TotalVat();
            lblTotalVAT.Text = $"{TotalVAT:0.00}";
        }
        private decimal TotalVat()
        {
            PaymentService paymentService = new PaymentService();
            List<Payment> items = paymentService.GetAllItem(); // Retrieve all items from the DAL
            decimal totalVat = 0;

            foreach (Payment item in items)
            {
                decimal vatPerItem = VATPerItem(item);
                totalVat += vatPerItem;
            }

            return totalVat;
        }
        private decimal VATPerItem(Payment item)
        {
            PaymentService paymentService = new PaymentService();
             bool isAlcoholic =paymentService.GetVATStatus(item);

            decimal vatRate = isAlcoholic ? HighVAT : LowVAT;
            decimal vatPerItem =item.ItemPrice * vatRate*item.Quantity;

            return vatPerItem;
        }
        Payment payment = new Payment();
        private void btnVisa_Click(object sender, EventArgs e)
        {
            btnVisa.BackColor = Color.Green;
            btnDebit.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            payment.PaymentMethod=PaymentMethod.Visa;

        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            btnDebit.BackColor = Color.Green;
            btnVisa.BackColor = Color.White;
            btnCash.BackColor = Color.White;
            payment.PaymentMethod = PaymentMethod.Pin;


        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnVisa.BackColor = Color.White;
            btnDebit.BackColor = Color.White;
            btnCash.BackColor = Color.Green;
            payment.PaymentMethod = PaymentMethod.Cash;


        }
    }
}
