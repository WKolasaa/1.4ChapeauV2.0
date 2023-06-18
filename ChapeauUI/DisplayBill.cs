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
        private TableService service = new TableService();
        private Table table;
        int tableNumber;
        public DisplayBill(Table table)
        {
            payment = new Payment();
            this.table = table;
            InitializeComponent();
            this.CenterToScreen();
            tableNumber = table.TableNumber;
            payment.TableNumber = tableNumber;
            lblTableNumber.Text =$"TABLE {tableNumber}";
            DisplaypaymentDetails();

        }

    private List<OrderItem> GetBill() 
        { 
             PaymentService paymentService =new PaymentService();

            List<OrderItem> itemsInsideBill = paymentService.GetItemsByTableNumber(tableNumber);
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


            foreach (OrderItem order in orderItems)
            {
                ListViewItem listView = new ListViewItem(order.Quantity.ToString());
                listView.SubItems.Add(order.ItemName);
                listView.SubItems.Add(order.Comment);
                listView.SubItems.Add(order.PricePerItem.ToString());

                decimal vatAmount = VATPerItem(order);
                listView.SubItems.Add(vatAmount.ToString("0.00"));
               
                listView.Tag = order;
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
             decimal TotalPriceExcludeVat = TotalPriceWithoutVAT(tableNumber);
            lblAmountExcludeVAT.Text = TotalPriceExcludeVat.ToString("€ 0.00");

            decimal TotalVAT = TotalVat();
            lblTotalVAT.Text =TotalVAT.ToString("€ 0.00");

            payment.TotalAmount = TotalAmountIncludeVAT();
            lblResultPriceWithVAT.Text = payment.TotalAmount.ToString("€ 0.00");

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
            List<OrderItem> items = paymentService.GetItemsByTableNumber(tableNumber); // Retrieve all items from the DAL

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

        internal decimal TotalAmountIncludeVAT()
        { 
         return TotalVat() + TotalPriceWithoutVAT(tableNumber);
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            DisplayPaymentMethod paymentMethod = new DisplayPaymentMethod(payment);
            paymentMethod.Show();
        }

        
    }
}
