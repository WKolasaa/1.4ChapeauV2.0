using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace ChapeauUI
{
    public partial class DisplayPaymentMethod : Form
    {
        private Payment payment;
        private List<ComboBox> paymentMethodList; // List to store the selected payment methods
        private List<TextBox> amountTextBoxList; // List to store the entered amounts
        private int currentPersonIndex = 0; // Index of the current person
        private int numberOfPeople = 0;
        private decimal tip = 0;

        public DisplayPaymentMethod(Payment payment)
        {
            this.payment = payment;
            payment.PaymentMethods = new List<PaymentMethod>();

            payment.Datetime=DateTime.Today;// manager part "income"

            InitializeComponent();
            this.CenterToScreen();

            rbtnNo.Checked = false;
            rbtnYes.Checked = false;

            lblSplitQuestion.Hide();
            btnSubmitAll.Hide();
            numericUpDownNumberOfPeople.Minimum = 2;// set the minimum
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
            if (CollectivePayment())
            {
                lblSplitQuestion.Show();
                btnSubmitAll.Show();
                btnSetNumber.Show();
                numericUpDownNumberOfPeople.Show();
            }
        }
        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!CollectivePayment())
            {
                lblSplitQuestion.Hide();
                btnSubmitAll.Show();
                numericUpDownNumberOfPeople.Visible = false;
                numberOfPeople = 1;
                btnSetNumber.Hide();
                btnNextPerson.Hide();
                pnlPersonControls.Controls.Clear();
                ShowPersonControls(currentPersonIndex);//test
            }
        }
        private bool CollectivePayment()
        {
            return rbtnYes.Checked;
        }


        private void btnSetNumber_Click(object sender, EventArgs e)//responsible for initializing and setting up the controls based on the number of people
        {
            numberOfPeople = (int)numericUpDownNumberOfPeople.Value;
            if (CollectivePayment())
            {
                btnNextPerson.Show();
            }

            pnlPersonControls.Controls.Clear();
            paymentMethodList = new List<ComboBox>();
            amountTextBoxList = new List<TextBox>();// for calculating the total price


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
                comboBox.Size = new Size(100, 20);

                // Create a TextBox for entering the payment amount
                TextBox textBox = new TextBox();
                textBox.Name = "textBoxAmount" + i;
                textBox.Location = new Point(controlX + comboBox.Width + horizontalSpace + 25, (i - 1) * verticalGap);
                textBox.Size = new Size(140, 80);
            }
            // Display the first person's controls
            ShowPersonControls(currentPersonIndex);
            btnSetNumber.BackColor = Color.Orange;
        }



        private void ShowPersonControls(int currentPerson)//handles the actual display
        {

            // Clear the panel before displaying the controls
            pnlPersonControls.Controls.Clear();

            int labelX = 30; // Represents the X coordinate for the labels
            int controlX = labelX + 100; // Represents the X coordinate for the combo boxes and text boxes

            Label label = new Label();
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.Size = new Size(200, 60);
            label.Location = new Point(labelX, 0);
            pnlPersonControls.Controls.Add(label);

            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(controlX + 100, 0);
            comboBox.Items.Add(PaymentMethod.Cash);
            comboBox.Items.Add(PaymentMethod.Visa);
            comboBox.Items.Add(PaymentMethod.Debit);
            comboBox.BackColor = Color.FloralWhite;
            pnlPersonControls.Controls.Add(comboBox);// to show the combobox inside the panel
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;//will be called when the selected index of the ComboBox changes.

            TextBox textBox = new TextBox();
            textBox.Location = new Point(controlX + comboBox.Width + 240, 0);
            textBox.BackColor = Color.FloralWhite;
            textBox.Size = new Size(120, 50);
            pnlPersonControls.Controls.Add(textBox);

            if (CollectivePayment())
            {
                label.Text = "Payer Select" + (currentPerson + 1);
                // Add the ComboBox to the paymentMethodList for tracking the payment method of the current person
                paymentMethodList.Add(comboBox);

                // Add the Textbox to the amountTextBoxList for tracking the amountPaid of the current person
                amountTextBoxList.Add(textBox);
            }
            else
            {
                label.Text = "Payer ";
                paymentMethodList = new List<ComboBox> { comboBox };
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
            if (currentPersonIndex < numberOfPeople - 1)
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



        private decimal CalculateTotalAmountPaid()
        {
            decimal totalAmountPaid = 0;

            if (!CollectivePayment()) // if split or not
            {
                TextBox textBox = amountTextBoxList[0];
                if (decimal.TryParse(textBox.Text, out decimal amount)) // checks if the customer has entered a valid decimal number in the TextBox
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
                        totalAmountPaid += amount;
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount entered.");
                        return 0;
                    }
                }
            }

            return totalAmountPaid;
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            try
            {
                tip = decimal.Parse(txtTipAmount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.Please enter a valid number", "Invalid Input", MessageBoxButtons.OK);
            }

            if (GiveTip(tip))
            {
                payment.Tips = tip;

                lblThankfulMessage.Text = "TIP HAS BEEN ADDED!";
                lblThankfulMessage.ForeColor = Color.Green;
                btnAddTip.BackColor = Color.Orange;
            }
            else
            {
                payment.Tips = 0;
            }
        }
        private bool GiveTip(decimal tip)
        {
            return tip > 0;
        }

        private void btnSubmitAll_Click(object sender, EventArgs e)
        {
            payment.Feedback = txtFeedback.Text;
            decimal totalAmountPaid = CalculateTotalAmountPaid();
            decimal totalCheck = payment.TotalAmount;
            totalAmountPaid += tip;
            decimal change = totalAmountPaid - totalCheck;

            if (change >= 0)
            {
                lblTotalAmountPaid.Text = totalAmountPaid.ToString("€ 0.00");
                lblTotalChange.Text = change.ToString("€ 0.00");
                btnSubmitAll.BackColor = Color.Orange;   
            }
            else
            {
                MessageBox.Show("Insufficient amount paid.");

                payment.Tips = 0;
                this.Close();
                DisplayBill displayBill = new DisplayBill(payment.TableNumber);
                displayBill.Show();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)//btnPAY
        {
            DisplayPayment displayPayment = new DisplayPayment(payment);
            displayPayment.Show();
            btnPAY.Enabled = false;
            this.Close();
        }
    }
}





