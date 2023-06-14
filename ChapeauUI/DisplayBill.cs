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
       // private Payment payment;
        private const decimal HighVAT = 0.21m;//for the alcoholic
        private const decimal LowVAT = 0.06m;//for the nonAlcoholic and Food

        private OrderItem OrderItem;
        public DisplayBill()
        {
            InitializeComponent();
            this.CenterToScreen();
            DisplaypaymentDetails();
            OrderItem = new OrderItem();
        }


        private List<OrderItem> GetBill() // 
        { 
        PaymentService paymentService =new PaymentService();
            List<OrderItem> itemsInsideBill = paymentService.GetItemsByTableNumber(4);// i should call the method in the service layer of the salman part
            return itemsInsideBill;
        }

        private void DisplayBillItems(List<OrderItem> orderItems)
        {
            ListViewBill.Clear();
            ListViewBill.Columns.Add("Quantity", 200);
            ListViewBill.Columns.Add("TNum", 100);
            ListViewBill.Columns.Add("Item", 200);
            ListViewBill.Columns.Add("Comment", 200);
            ListViewBill.Columns.Add("Price", 200);

            foreach (OrderItem order in orderItems)
            {
                ListViewItem listView = new ListViewItem(order.Quantity.ToString());
                listView.SubItems.Add(order.TableNumber.ToString());
                listView.SubItems.Add(order.ItemName);
                listView.SubItems.Add(order.Comment);
                listView.SubItems.Add(order.PricePerItem.ToString());

                listView.Tag = order;
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
            List<OrderItem> orderItems = GetBill();
            DisplayBillItems(orderItems);
        }
        private void DisplaypaymentDetails()
        {
             decimal TotalPriceExcludeVat = TotalPriceWithoutVAT(4);// here should i call the method from the Salman part
            txtTotalPriceWithoutVat.Text = TotalPriceExcludeVat.ToString();

            decimal TotalVAT = TotalVat();
            lblTotalVAT.Text = $"{TotalVAT:0.00}";

            decimal totalAmountIncVAT = TotalAmountIncludeVAT();
            lblResultPriceWithVAT.Text = totalAmountIncVAT.ToString("0.00");
        }
        

        private decimal TotalPriceWithoutVAT(int table)
        {
           // payment.tableNumber = table;//edit it when the others finish their part
            PaymentService paymentService = new PaymentService();
             List<OrderItem> totalPriceItems = paymentService.GetItemsByTableNumber(table); // Retrieve items for the specific table

            decimal totalAmount = 0;

            foreach ( OrderItem item in totalPriceItems)
            {
                decimal totalItemPrice = item.PricePerItem * item.Quantity;
                totalAmount += totalItemPrice;
            }
            return totalAmount;
        }
   

       
        internal decimal TotalVat()//  this method is called inside the DisplayPaymentMethod so is internal
        { 
            PaymentService paymentService = new PaymentService();
            List<OrderItem> items = paymentService.GetItemsByTableNumber(4); // Retrieve all items from the DAL

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

            decimal vatRate = isAlcoholic ? HighVAT : LowVAT;
            decimal vatPerItem =item.PricePerItem * vatRate*item.Quantity;

            return vatPerItem;
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            DisplayPaymentMethod paymentMethod = new DisplayPaymentMethod(OrderItem);// by this way i can access the same instance in diff form
            paymentMethod.Show();
        }

        internal decimal TotalAmountIncludeVAT()
        { 
         return TotalVat() + TotalPriceWithoutVAT(4);
        }

       
    }
}
