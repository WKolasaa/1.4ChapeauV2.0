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
       
        public DisplayBill(int tableNumber)
        {
            payment = new Payment();
            InitializeComponent();
            this.CenterToScreen();

            payment.TableNumber = tableNumber;

            lblTableNumber.Text =$"TABLE {payment.TableNumber}";

            DisplaypaymentDetails();

        }

        private List<OrderItem> GetItemByTableNumber(int tableNumber)
        {
            PaymentService paymentService = new PaymentService();
            List<OrderItem> items = paymentService.GetItemsByTableNumber(payment.TableNumber);
            return items;
        }

        private List<OrderItem> GetBill() 
        { 
            List<OrderItem> itemsInsideBill = GetItemByTableNumber(payment.TableNumber);
            return itemsInsideBill;
        }

        private void DisplayBillItems(List<OrderItem> orderItems)
        {
            ListViewBill.Clear();
            ListViewBill.Columns.Add("Quantity",170);
            ListViewBill.Columns.Add("Item",200);
            ListViewBill.Columns.Add("Comment",200);
            ListViewBill.Columns.Add("Price",130);
            ListViewBill.Columns.Add("VatAmount",200);


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

            decimal TotalVAT = TotalVat();
            lblTotalVAT.Text =TotalVAT.ToString("€ 0.00");

            payment.TotalAmount = TotalAmountIncludeVAT();
            lblResultPriceWithVAT.Text = payment.TotalAmount.ToString("€ 0.00");
        }

        private decimal TotalPriceWithoutVAT()
        {
            List<OrderItem> totalPriceItems = GetItemByTableNumber(payment.TableNumber);
            decimal totalAmount = 0;

            foreach ( OrderItem item in totalPriceItems)
            {
                decimal totalItemPrice = item.PricePerItem * item.Quantity;
                totalAmount += totalItemPrice;
            }
            return totalAmount;
        }

        private decimal TotalVat()
        {
         
            List<OrderItem> items = GetItemByTableNumber(payment.TableNumber);
            decimal totalVat = 0;
            foreach (OrderItem item in items)
            {
                decimal vatPerItem = VATPerItem(item);
                totalVat += vatPerItem;
            }
            return totalVat;
        }

        
        private decimal VATPerItem(OrderItem item)
        {
            PaymentService paymentService = new PaymentService();
             bool isAlcoholic =paymentService.GetVATStatus(item);
            decimal vatRate;

            if (isAlcoholic)
            {
                vatRate = HighVAT;
            }
            else
            {
                vatRate = LowVAT;
            }
            // decimal vatRate = isAlcoholic ? HighVAT : LowVAT;


            decimal vatPerItem = item.PricePerItem * vatRate * item.Quantity;


            return vatPerItem;
        }

        private decimal TotalAmountIncludeVAT()
        { 
         return TotalVat() + TotalPriceWithoutVAT();
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            DisplayPaymentMethod paymentMethod = new DisplayPaymentMethod(payment);
            paymentMethod.Show();
            this.Close();
        }
    }
}
