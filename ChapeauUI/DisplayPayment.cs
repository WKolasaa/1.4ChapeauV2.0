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
            InitializeComponent();
            this.CenterToScreen();
            this.payment = payment;

            // Call the method to retrieve the payment history from the database
            List<Payment> paymentHistory = GetPaymentHistory();
            // Display the payment history in the ListView
            DisplayPaymentHistory(paymentHistory);
        }
      
            private List<Payment> GetPaymentHistory()
            {
             PaymentService paymentService = new PaymentService();
             paymentService.StorePaymentHistory(payment);// insert
            // Retrieve the payment history from the service layer
            List<Payment> paymentHistory = paymentService.GetLastPaymentHistory();
            return paymentHistory;
            }

        
          private void DisplayPaymentHistory(List<Payment> payments)
          {
            listViewPaymentHistory.Clear();
            // set column name
            listViewPaymentHistory.Columns.Add("ID",70);
            listViewPaymentHistory.Columns.Add("TotalAmount",175);
            listViewPaymentHistory.Columns.Add("Tip",100);
            listViewPaymentHistory.Columns.Add("Feedback",200);
            listViewPaymentHistory.Columns.Add("TableNumber",200);
            listViewPaymentHistory.Columns.Add("PaymentMethods",200);

            foreach (Payment payment in payments)
            {
                ListViewItem listView = new ListViewItem(payment.PaymentHistoryID.ToString()); 
                listView.SubItems.Add(payment.TotalAmount.ToString("0.00"));
                listView.SubItems.Add(payment.Tips.ToString());
                listView.SubItems.Add(payment.Feedback);
                listView.SubItems.Add(payment.TableNumber.ToString());

                string paymentMethodsString = string.Join(", ", payment.PaymentMethods);
                listView.SubItems.Add(paymentMethodsString);

                listView.Tag = payment;
                listViewPaymentHistory.Items.Add(listView);
            }

            // Set column widths and other properties of the ListView
            listViewPaymentHistory.Columns[0].Width = 70;
            listViewPaymentHistory.Columns[1].Width = 175;
            listViewPaymentHistory.Columns[2].Width = 100;
            listViewPaymentHistory.Columns[3].Width = 200;
            listViewPaymentHistory.Columns[4].Width = 200;
            listViewPaymentHistory.Columns[5].Width = 200;
            listViewPaymentHistory.View = View.Details;
          }


        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            int paymentHistoryID = int.Parse(txtPaymentHistoryID.Text);
            PaymentService service = new PaymentService();
            List<Payment> paymentHistory = service.GetPaymentHistoryByID(paymentHistoryID);
            DisplayPaymentHistory(paymentHistory);
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
    
            Employee employee = new Employee();
            TableService tableService = new TableService();
             tableService.FreeTable(payment.TableNumber,TableStatus.Free);
            PaymentService service = new PaymentService();
            service.DeleteBill(payment.TableNumber);// check
           TableOverview tablesOverView = new TableOverview(employee);// problem!?
            tablesOverView.Show();
        }
    }
}
