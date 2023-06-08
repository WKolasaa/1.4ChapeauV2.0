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
    public partial class DisplayPayment : Form
    {
        private Payment payment;

        public DisplayPayment(Payment payment)
        {
            this.payment = payment;
            InitializeComponent();
            this.CenterToScreen();
        }
      

      
            private List<Payment> GetPaymentHistory()
            {
                PaymentService paymentService = new PaymentService();
                List<Payment> paymentHistory = paymentService.GetPaymentHistory();
                return paymentHistory;
            }

        
          private void DisplayPaymentHistory(List<Payment> payments)
          {
            listViewPaymentHistory.Clear();
            listViewPaymentHistory.Columns.Add("TotalAmount", 200);
            listViewPaymentHistory.Columns.Add("Tip", 100);
            listViewPaymentHistory.Columns.Add("Feedback", 200);
            listViewPaymentHistory.Columns.Add("TableNumber", 100);
            listViewPaymentHistory.Columns.Add("PaymentMethod", 150); // Add the PaymentMethod column

            foreach (Payment payment in payments)
            {
                ListViewItem listView = new ListViewItem(payment.TotalAmount.ToString());
                listView.SubItems.Add(payment.Tips.ToString());
                listView.SubItems.Add(payment.FeedBack);
                listView.SubItems.Add(payment.tableNumber.ToString());

                PaymentService service = new PaymentService();
                string paymentMethod =service.GetPaymentMethod(payment.PaymentHistoryID);
                listView.SubItems.Add(paymentMethod);

                listView.Tag = payment;
                listViewPaymentHistory.Items.Add(listView);
            }
            listViewPaymentHistory.Columns[0].Width = 200;
            listViewPaymentHistory.Columns[1].Width = 100;
            listViewPaymentHistory.Columns[2].Width = 200;
            listViewPaymentHistory.Columns[3].Width = 100;


            listViewPaymentHistory.View = View.Details;
          }
         
         
        private void btnTableView_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            // Call the method to retrieve the payment history from the database
            List<Payment> paymentHistory = GetPaymentHistory();

            // Display the payment history in the ListView
            DisplayPaymentHistory(paymentHistory);
        }
    }
}
