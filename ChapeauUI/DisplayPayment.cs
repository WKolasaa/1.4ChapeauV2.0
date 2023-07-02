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
            DisplayPaymentHistory(payment);
        }

       


        private void DisplayPaymentHistory(Payment payment)
        {
            listViewPaymentHistory.Clear();
            // set column name
            listViewPaymentHistory.Columns.Add("ID", 70);
            listViewPaymentHistory.Columns.Add("TotalAmount", 175);
            listViewPaymentHistory.Columns.Add("Tip", 100);
            listViewPaymentHistory.Columns.Add("Feedback", 200);
            listViewPaymentHistory.Columns.Add("TableNumber", 200);
            listViewPaymentHistory.Columns.Add("PaymentMethods", 200);

            
                ListViewItem listView = new ListViewItem(payment.PaymentHistoryID.ToString());
                listView.SubItems.Add(payment.TotalAmount.ToString("0.00"));
                listView.SubItems.Add(payment.Tip.ToString());
                listView.SubItems.Add(payment.Feedback);
                listView.SubItems.Add(payment.TableNumber.ToString());

                string paymentMethodsString = string.Join(", ", payment.PaymentMethods);
                listView.SubItems.Add(paymentMethodsString);

                listView.Tag = payment;
                listViewPaymentHistory.Items.Add(listView);
            

            // Set column widths and other properties of the ListView
            listViewPaymentHistory.Columns[0].Width = 70;
            listViewPaymentHistory.Columns[1].Width = 175;
            listViewPaymentHistory.Columns[2].Width = 100;
            listViewPaymentHistory.Columns[3].Width = 200;
            listViewPaymentHistory.Columns[4].Width = 200;
            listViewPaymentHistory.Columns[5].Width = 200;
            listViewPaymentHistory.View = View.Details;
        }

        private void btnPaymentHistory_Click_1(object sender, EventArgs e)
        {
            int paymentHistoryID = int.Parse(txtPaymentHistoryID.Text);
            PaymentService service = new PaymentService();
            Payment paymentHistory = service.GetPaymentHistoryByID(paymentHistoryID);
            DisplayPaymentHistory(paymentHistory);
        }

        

        private void btnTableView_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TableOverview tablesOverView = new TableOverview();
            tablesOverView.ShowDialog();
            this.Close();
        }
    }
}
