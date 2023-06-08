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
        private Payment payment;

        private const decimal HighVAT = 0.21m;//for the alcoholic
       private const decimal LowVAT = 0.06m;//for the nonAlcoholic and Food
        public DisplayBill()
        {
            InitializeComponent();
            this.CenterToScreen();
            DisplaypaymentDetails();
            payment = new Payment();
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
            ListViewBill.Columns.Add("Quantity", 200);
            ListViewBill.Columns.Add("TNum", 100);
            ListViewBill.Columns.Add("Item", 200);
            ListViewBill.Columns.Add("Comment", 200);
            ListViewBill.Columns.Add("Price", 200);

            foreach (Payment payment in payments)
            {
                ListViewItem listView = new ListViewItem(payment.Quantity.ToString());
                listView.SubItems.Add(payment.tableNumber.ToString());
                listView.SubItems.Add(payment.itemName);
                listView.SubItems.Add(payment.Comment);
                listView.SubItems.Add(payment.ItemPrice.ToString());

                listView.Tag = payment;
                ListViewBill.Items.Add(listView);
            }
            ListViewBill.Columns[0].Width = 100;
            ListViewBill.Columns[1].Width = 100;
            ListViewBill.Columns[2].Width = 200;
            ListViewBill.Columns[3].Width = 200;
            ListViewBill.Columns[4].Width = 100;


            ListViewBill.View = View.Details;
        }

        private void DisplayBill_Load(object sender, EventArgs e)
        {
            List<Payment> payments = GetBill();
            DisplayPayment(payments);
        }
        private void DisplaypaymentDetails()
        {
             decimal TotalPriceExcludeVat = TotalPriceWithoutVAT(2);
            txtTotalPriceWithoutVat.Text = TotalPriceExcludeVat.ToString();

            decimal TotalVAT = TotalVat();
            lblTotalVAT.Text = $"{TotalVAT:0.00}";

            decimal totalAmountIncVAT = TotalAmountIncVAT();
            lblResultPriceWithVAT.Text = totalAmountIncVAT.ToString("0.00");
        }
        

        private decimal TotalPriceWithoutVAT(int table)
        {
           // payment.tableNumber = table;//edit it when the others finish their part
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

       

        private void lblTotalVAT_Click(object sender, EventArgs e)
        {
          //  decimal TotalVAT=TotalVat();
            //lblTotalVAT.Text = $"{TotalVAT:0.00}";
        }
        internal decimal TotalVat()//cause in need this method inside the DisplayPaymentMethod and i did it internal Cause the same forms inherits from the same thing
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

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            DisplayPaymentMethod paymentMethod = new DisplayPaymentMethod(payment);// by this way i can access the same instance in diff form
            paymentMethod.Show();
            DisplayBill displayBill = new DisplayBill();
            displayBill.Hide();
        }

        internal decimal TotalAmountIncVAT()
        { 
         return TotalVat() + TotalPriceWithoutVAT(2);
        }

       
    }
}
