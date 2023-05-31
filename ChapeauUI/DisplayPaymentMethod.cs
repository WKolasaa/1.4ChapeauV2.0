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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ChapeauUI
{
    public partial class DisplayPaymentMethod : Form
    {
        private Payment payment;

        public DisplayPaymentMethod(Payment payment)
        {
            this.payment=payment;
            InitializeComponent();
            this.CenterToScreen();
            btnSet.Click += btnSet_Click;

            rbtnNo.Checked = false;
            rbtnYes.Checked = false;

       
            lblSplitQuestion.Hide();
            txtNumberOfPeople.Hide();
            lblPaymentMethodNoSplit.Hide();
            groupBoxPaymentMethods.Hide();
            dataGridViewSplitBill.Hide();
           btnSet.Hide();
        }


        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
            
                lblSplitQuestion.Show();
                txtNumberOfPeople.Show();
                lblPaymentMethodNoSplit.Hide();
                groupBoxPaymentMethods.Hide();
            }

        }
        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
              
                lblSplitQuestion.Hide();
                txtNumberOfPeople.Hide();
             
                lblPaymentMethodNoSplit.Show();
                groupBoxPaymentMethods.Show();  
            }
        }


        /*private decimal AmountPerPerson(int numberOfPeople)
        {
            DisplayBill bill = new DisplayBill();
             decimal totalAmount = bill.TotalAmountIncVAT();
            decimal amountPerPerson = totalAmount / numberOfPeople;
            return amountPerPerson;
        }*/
        
        private void btnVisa_Click(object sender, EventArgs e)
        {

            if (btnVisa.BackColor == Color.Green)
            {
                    btnVisa.BackColor = SystemColors.Control;
                payment.PaymentMethod = PaymentMethod.Visa;
            }
            else
            {
                    btnVisa.BackColor = Color.Green;
            }
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
                if (btnDebit.BackColor == Color.Green)
                {
                    btnDebit.BackColor = SystemColors.Control;
                payment.PaymentMethod = PaymentMethod.Debit;

                }
              else
              {
                 btnDebit.BackColor = Color.Green;
              }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
                if (btnCash.BackColor == Color.Green)
                {
                    btnCash.BackColor = SystemColors.Control;
                payment.PaymentMethod = PaymentMethod.Cash;

                }
               else
               {
                 btnCash.BackColor = Color.Green;
               }
        }

       
        private void button1_Click(object sender, EventArgs e)//btnPAY
        {
            DisplayPayment displayPayment = new DisplayPayment(payment);
            displayPayment.Show();
        }

        private void txtNumberOfPeople_TextChanged_1(object sender, EventArgs e)
        {
               int numberOfPeople;
            if  (int.TryParse(txtNumberOfPeople.Text, out numberOfPeople))
            {
                   if (numberOfPeople > 0)
                   {
                    dataGridViewSplitBill.Show();
                    btnSet.Show();

                   }

                   dataGridViewSplitBill.Rows.Clear();
                  dataGridViewSplitBill.Columns.Add("PersonNumberColumn", "Person");
                  dataGridViewSplitBill.Columns.Add("AmountPerPersonColumn", "Amount Per Person");
                  dataGridViewSplitBill.Columns.Add("PaymentMethodColumn", "Payment Method");

                for (int i = 1; i <= numberOfPeople; i++)
                {
                    dataGridViewSplitBill.Rows.Add(i.ToString(), "", "");
                }
                dataGridViewSplitBill.AllowUserToAddRows = false;

            }
            else
            {
                // Handle the case where the input is not a valid number
                dataGridViewSplitBill.Rows.Clear();
                dataGridViewSplitBill.Hide();
            }
        }

       

        private void dataGridViewSplitBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                //if (e.ColumnIndex == dataGridViewSplitBill.Columns["AmountPaidColumn"].Index)
                //{
                    // Prompt the customer to enter the amount they want to pay
                    
                //}
                if (e.ColumnIndex == dataGridViewSplitBill.Columns["PaymentMethodColumn"].Index)
                {
                    DataGridViewButtonCell buttonCell = dataGridViewSplitBill.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                    if (buttonCell != null)
                    {
                        string currentMethod = buttonCell.Value.ToString().ToLower();
                        string newMethod = "";

                        switch (currentMethod)
                        {
                            case "visa":
                                newMethod = "Debit";
                            payment.PaymentMethod = PaymentMethod.Debit;
                            break;
                            case "debit":
                                newMethod = "Cash";
                            payment.PaymentMethod = PaymentMethod.Cash;
                            break;
                            case "cash":
                                newMethod = "";
                            payment.PaymentMethod = PaymentMethod.Cash;
                            break;
                            case "":
                                newMethod = "Visa"; // if the customer didn't choose method visa is the default
                            payment.PaymentMethod = PaymentMethod.Visa;
                            break;
                            default:
                                // Handle the case where an unrecognized payment method is encountered
                                MessageBox.Show("Invalid payment method.");
                                break;
                        }

                        buttonCell.Value = newMethod;
                    }
                }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
                decimal totalAmountPaid = 0;

                // Calculate the total amount paid by summing up the amounts in the dataGridViewSplitBill
                foreach (DataGridViewRow row in dataGridViewSplitBill.Rows)
                {
                    if (decimal.TryParse(row.Cells["AmountPerPersonColumn"].Value.ToString(), out decimal rowAmountPaid))
                    {
                        totalAmountPaid += rowAmountPaid;
                    }
                }

                DisplayBill bill = new DisplayBill();
                decimal totalAmount = bill.TotalAmountIncVAT();

                lblTotalAmountPaid.Text = totalAmountPaid.ToString("0.00");
                payment.PaidAmount=totalAmountPaid;
                // Calculate the change result
                decimal changeResult = totalAmountPaid - totalAmount;
                lblTotalChange.Text = changeResult >= 0 ? changeResult.ToString("0.00") : "Insufficient Payment";
        }
    }
}
