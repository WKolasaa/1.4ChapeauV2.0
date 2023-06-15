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
        private List<ComboBox> paymentMethodList; // List to store the selected payment methods
        private List<TextBox> amountTextBoxList; // List to store the entered amounts
        private int currentPersonIndex = 0; // Index of the current person
        private int numberOfPeople = 0;
        Table Table = new Table();
        public DisplayPaymentMethod(Payment payment)
        {
            this.payment = payment;
            payment.PaymentMethods = new List<PaymentMethod>();

            InitializeComponent();
            this.CenterToScreen();


            rbtnNo.Checked = false;
            rbtnYes.Checked = false;

            lblSplitQuestion.Hide();
            btnSubmitAll.Hide();
            numericUpDownNumberOfPeople.Hide();
            btnSetNumber.Hide();
            lblFeddbackHeader.Show();
            lblFeddbackHeader.Show();
            btnSubmitAll.Show();
            txtTipAmount.Show();
            txtFeedback.Show();
            btnNextPerson.Hide();
        }


        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (SplitBill())
            {

                lblSplitQuestion.Show();
                btnSubmitAll.Show();
                btnSetNumber.Show();
                numericUpDownNumberOfPeople.Show();

            }

        }
        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!SplitBill())
            {
                lblSplitQuestion.Hide();
                btnSubmitAll.Show();
                numericUpDownNumberOfPeople.Visible = false;
                numberOfPeople = 1;
                btnSetNumber.Hide();

                pnlPersonControls.Controls.Clear();
                ShowPersonControls(0);
            }
        }

        private bool SplitBill()
        {
            return rbtnYes.Checked;
        }


        private void btnSetNumber_Click(object sender, EventArgs e)
        {
            numberOfPeople = (int)numericUpDownNumberOfPeople.Value;
            if (numberOfPeople > 1)
            {
                btnNextPerson.Show();
            }

            pnlPersonControls.Controls.Clear();
            paymentMethodList = new List<ComboBox>();
            amountTextBoxList = new List<TextBox>();// for calculating the total price
          //  payment.PaymentMethods = new List<PaymentMethod>();


            int labelX = 10; // Represents the X coordinate for the labels
            int controlX = labelX + 100; // Represents the X coordinate for the combo boxes and text boxes

            int verticalGap = 80; // Represents the vertical space between the controls
            int horizontalSpace = 50; // Represents the horizontal space between the controls

            for (int i = 1; i <= numberOfPeople; i++)
            {
                // Create a ComboBox for the payment method selection
                ComboBox comboBox = new ComboBox();
                comboBox.Name = "comboBoxPerson" + i;
                comboBox.Location = new Point(controlX + 30, (i - 1) * verticalGap);
                comboBox.Size = new Size(120, 20);
                comboBox.Items.Add("Cash");
                comboBox.Items.Add("Visa");
                comboBox.Items.Add("Debit");
                pnlPersonControls.Controls.Add(comboBox);

                // Add the ComboBox to the paymentMethodList
                paymentMethodList.Add(comboBox);// !!!!!!!!!!!!!!!!!!!!

                // Create a TextBox for entering the payment amount
                TextBox textBox = new TextBox();
                textBox.Name = "textBoxAmount" + i;
                textBox.Location = new Point(controlX + comboBox.Width + horizontalSpace + 25, (i - 1) * verticalGap);
                textBox.Size = new Size(100, 50);
                pnlPersonControls.Controls.Add(textBox);

            }
            // Display the first person's controls
            ShowPersonControls(0);
        }

        

        private void ShowPersonControls(int index)
        {

            // Clear the panel before displaying the controls
            pnlPersonControls.Controls.Clear();

            int labelX = 30; // Represents the X coordinate for the labels
            int controlX = labelX + 100; // Represents the X coordinate for the combo boxes and text boxes

            int verticalGap = 180; // Represents the vertical space between the controls

            if (SplitBill())
            {
                // Display the label for the person
                Label label = new Label();
                label.Text = "Person " + (index + 1);
                label.Font = new Font(label.Font, FontStyle.Bold);
                label.Size = new Size(120, 60);
                label.Location = new Point(labelX, 0);
                pnlPersonControls.Controls.Add(label);

                // Display the ComboBox for the payment method selection
                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(controlX + 100, 0);
                comboBox.Items.Add(PaymentMethod.Cash);
                comboBox.Items.Add(PaymentMethod.Visa);
                comboBox.Items.Add(PaymentMethod.Debit);
                pnlPersonControls.Controls.Add(comboBox);
                paymentMethodList.Add(comboBox);
                // Attach the event handler to the SelectedIndexChanged event
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                // Display the TextBox for the amount each person will pay
                TextBox textBox = new TextBox();
                textBox.Location = new Point(controlX + comboBox.Width + 240, 0);
                pnlPersonControls.Controls.Add(textBox);
                amountTextBoxList.Add(textBox);
            }
            else
            {
                // Display the label for the amount to pay
                Label label = new Label();
                label.Text = "Amount to Pay ";
                label.Font = new Font(label.Font, FontStyle.Bold);
                label.Size = new Size(200, 80);
                label.Location = new Point(labelX, 0);
                pnlPersonControls.Controls.Add(label);

                // Display the ComboBox for the payment method selection
                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(controlX + 100, 0);
                comboBox.Items.Add(PaymentMethod.Cash);
                comboBox.Items.Add(PaymentMethod.Visa);
                comboBox.Items.Add(PaymentMethod.Debit);
                pnlPersonControls.Controls.Add(comboBox);

                // Add the ComboBox to the paymentMethodList
                paymentMethodList = new List<ComboBox> { comboBox };
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

                // Display the TextBox for the amount to pay
                TextBox textBox = new TextBox();
                textBox.Location = new Point(controlX + comboBox.Width + 240, 0);
                pnlPersonControls.Controls.Add(textBox);

                // Add the TextBox to the amountTextBoxList
                amountTextBoxList = new List<TextBox> { textBox };
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Update the payment method when a different option is selected
            if (comboBox.SelectedIndex >= 0)
            {
                PaymentMethod selectedPaymentMethod = (PaymentMethod)comboBox.SelectedItem;
               payment.PaymentMethods.Add(selectedPaymentMethod);
            }
        }


        private void btnNextPerson_Click_1(object sender, EventArgs e)
        {
            // Check if there are more persons to display
 
            if (currentPersonIndex < numberOfPeople-1)
            {
                paymentMethodList[currentPersonIndex].Visible = false;
                amountTextBoxList[currentPersonIndex].Visible = false;
                currentPersonIndex++;

                ShowPersonControls(currentPersonIndex);
            }
            else
            {
                btnNextPerson.Text = "Done";
                btnNextPerson.BackColor = Color.Orange;
                btnNextPerson.Enabled = false;
            }
        }

        decimal tip = 0;
        private void btnAddTip_Click(object sender, EventArgs e)
        {
              tip = decimal.Parse(txtTipAmount.Text);

            if (GiveTip(tip))
            {
                payment.Tips = tip;

                lblThankfulMessage.Text = "TIP HAS BEEN ADDED!";
                lblThankfulMessage.ForeColor = Color.Green;
            }
            else
            {
                payment.Tips = 0;

                btnAddTip.Enabled = false;
            }
        }
        private bool GiveTip(decimal tip)
        {  
            return tip > 0;
        }
       
        private void btnSubmitAll_Click(object sender, EventArgs e)
        {
            // Calculate the total amount paid
             decimal totalAmountPaid = 0;
            decimal amountPaidPerPerson = 0;

             if (numberOfPeople == 1)// if split or not
             {
                TextBox textBox = amountTextBoxList[0];
                if (decimal.TryParse(textBox.Text, out decimal amount))//checks if the customer has entered a valid decimal number in the TextBox
                {
                    totalAmountPaid = amount;
                }
                else 
                {
                    MessageBox.Show("Invalid amount entered.");
                }
             }
             else
             {
                 foreach (TextBox textBox in amountTextBoxList)
                 {
                    if (decimal.TryParse(textBox.Text, out decimal amount))
                    {
                        amountPaidPerPerson = amount;
                        totalAmountPaid += amountPaidPerPerson;
                    }
                    else
                    {
                        // Display an error message or handle the invalid input
                        MessageBox.Show("Invalid amount entered.");
                        break; // Exit the loop if parsing fails for any textbox
                    }
                 }
             }

             // Add tip if applicable
             if (GiveTip(tip))
             {
                 totalAmountPaid += tip;
             }

             // Perform UI updates
             lblTotalAmountPaid.Text = totalAmountPaid.ToString("0.00");


            //DisplayBill bill = new DisplayBill(Table);
            decimal totalCheck = payment.TotalAmount;
            payment.Feedback = txtFeedback.Text;
             decimal change = totalAmountPaid - totalCheck;
             if (change >= 0)
             {
                 lblTotalChange.Text = change.ToString("0.00");
             }
             else
             {
                 lblTotalChange.Hide();
                 lblChange.Hide();
                 lblInsufficientPaymnt.Text = "The total amount is not enough for the bill!";
             }
             // Re-enable UI updates
            // pnlPersonControls.ResumeLayout();
        }
        private void button1_Click(object sender, EventArgs e)//btnPAY
        {
            DisplayPayment displayPayment = new DisplayPayment(payment);
            displayPayment.Show();
            //btnPAY.Enabled = false;
        }

       
    }
}

    



