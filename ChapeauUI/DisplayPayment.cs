using ChapeauModel;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //decimal tipAmount;
          /*  if (decimal.TryParse(txtTipAmount.Text, out tipAmount))
            {
                DisplayPaymentMethod displayPayment = new DisplayPaymentMethod();
                decimal change = displayPayment.ChangeResult();
                if (tipAmount <= change)
                {
                    string message = GetThankfulMessage(tipAmount);
                    lblThankfulMessage.Text = message;
                }
                else
                {
                    lblThankfulMessage.Text = "Tip amount cannot exceed the change.";
                }
            }
            else
            {
                lblThankfulMessage.Text = "We appreciate your visit!";
            }*/

        }
        private string GetThankfulMessage(decimal tipAmount)
        {
            if (tipAmount > 0)
            {
                return "Thank you for the generous tip!";
            }
            else
            {
                return "We appreciate your visit!";
            }
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedback.Text;

            if (!string.IsNullOrEmpty(feedback))
            {

                MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtFeedback.Text = string.Empty;
            payment.FeedBack = feedback;
        }

        private void btnSetTip_Click(object sender, EventArgs e)
        {
            decimal tipAmount = decimal.Parse(txtTipAmount.Text);
            string message = GetThankfulMessage(tipAmount);
            lblThankfulMessage.Text = message;
            payment.Tips = tipAmount;
        }
    }
}
