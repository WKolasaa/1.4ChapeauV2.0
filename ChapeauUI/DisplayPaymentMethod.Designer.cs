namespace ChapeauUI
{
    partial class DisplayPaymentMethod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblSplitQuestion = new Label();
            rbtnYes = new RadioButton();
            rbtnNo = new RadioButton();
            groupBoxSplitOption = new GroupBox();
            lblAmountPaidByCustomers = new Label();
            lblChange = new Label();
            btnPAY = new Button();
            lblTotalAmountPaid = new Label();
            numericUpDownNumberOfPeople = new NumericUpDown();
            btnSetNumber = new Button();
            pnlPersonControls = new Panel();
            lblTotalChange = new Label();
            btnNextPerson = new Button();
            lblTipHeader = new Label();
            label4 = new Label();
            txtTipAmount = new TextBox();
            lblFeddbackHeader = new Label();
            lblTipQuestion = new Label();
            txtFeedback = new TextBox();
            lblThankfulMessage = new Label();
            btnAddTip = new Button();
            lblInsufficientPaymnt = new Label();
            btnSubmitAll = new Button();
            groupBoxSplitOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfPeople).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 109);
            label2.Name = "label2";
            label2.Size = new Size(320, 23);
            label2.TabIndex = 1;
            label2.Text = "Collective Payment or Group Transaction";
            // 
            // lblSplitQuestion
            // 
            lblSplitQuestion.AutoSize = true;
            lblSplitQuestion.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblSplitQuestion.Location = new Point(12, 195);
            lblSplitQuestion.Name = "lblSplitQuestion";
            lblSplitQuestion.Size = new Size(194, 23);
            lblSplitQuestion.TabIndex = 2;
            lblSplitQuestion.Text = "Number of Contributors";
            // 
            // rbtnYes
            // 
            rbtnYes.AutoSize = true;
            rbtnYes.Location = new Point(6, 36);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(50, 23);
            rbtnYes.TabIndex = 3;
            rbtnYes.Text = "Yes";
            rbtnYes.UseVisualStyleBackColor = true;
            rbtnYes.CheckedChanged += rbtnYes_CheckedChanged;
            // 
            // rbtnNo
            // 
            rbtnNo.AutoSize = true;
            rbtnNo.Location = new Point(112, 36);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(48, 23);
            rbtnNo.TabIndex = 4;
            rbtnNo.Text = "No";
            rbtnNo.UseVisualStyleBackColor = true;
            rbtnNo.CheckedChanged += rbtnNo_CheckedChanged;
            // 
            // groupBoxSplitOption
            // 
            groupBoxSplitOption.Controls.Add(rbtnNo);
            groupBoxSplitOption.Controls.Add(rbtnYes);
            groupBoxSplitOption.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxSplitOption.Location = new Point(711, 71);
            groupBoxSplitOption.Name = "groupBoxSplitOption";
            groupBoxSplitOption.Size = new Size(188, 78);
            groupBoxSplitOption.TabIndex = 8;
            groupBoxSplitOption.TabStop = false;
            // 
            // lblAmountPaidByCustomers
            // 
            lblAmountPaidByCustomers.AutoSize = true;
            lblAmountPaidByCustomers.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountPaidByCustomers.Location = new Point(470, 827);
            lblAmountPaidByCustomers.Name = "lblAmountPaidByCustomers";
            lblAmountPaidByCustomers.Size = new Size(151, 32);
            lblAmountPaidByCustomers.TabIndex = 12;
            lblAmountPaidByCustomers.Text = "Amount Paid";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.Location = new Point(470, 913);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(107, 32);
            lblChange.TabIndex = 15;
            lblChange.Text = "CHANGE";
            // 
            // btnPAY
            // 
            btnPAY.BackColor = Color.Orange;
            btnPAY.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPAY.Location = new Point(361, 1033);
            btnPAY.Name = "btnPAY";
            btnPAY.Size = new Size(258, 69);
            btnPAY.TabIndex = 20;
            btnPAY.Text = "PAY";
            btnPAY.UseVisualStyleBackColor = false;
            btnPAY.Click += btnPay_Click;
            // 
            // lblTotalAmountPaid
            // 
            lblTotalAmountPaid.AutoSize = true;
            lblTotalAmountPaid.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmountPaid.Location = new Point(793, 827);
            lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            lblTotalAmountPaid.Size = new Size(0, 32);
            lblTotalAmountPaid.TabIndex = 23;
            // 
            // numericUpDownNumberOfPeople
            // 
            numericUpDownNumberOfPeople.Location = new Point(765, 193);
            numericUpDownNumberOfPeople.Name = "numericUpDownNumberOfPeople";
            numericUpDownNumberOfPeople.Size = new Size(130, 25);
            numericUpDownNumberOfPeople.TabIndex = 29;
            // 
            // btnSetNumber
            // 
            btnSetNumber.BackColor = Color.LightGreen;
            btnSetNumber.Location = new Point(794, 234);
            btnSetNumber.Name = "btnSetNumber";
            btnSetNumber.Size = new Size(101, 43);
            btnSetNumber.TabIndex = 30;
            btnSetNumber.Text = "SET";
            btnSetNumber.UseVisualStyleBackColor = false;
            btnSetNumber.Click += btnSetNumber_Click;
            // 
            // pnlPersonControls
            // 
            pnlPersonControls.AutoSize = true;
            pnlPersonControls.Location = new Point(99, 297);
            pnlPersonControls.Name = "pnlPersonControls";
            pnlPersonControls.Size = new Size(606, 53);
            pnlPersonControls.TabIndex = 31;
            // 
            // lblTotalChange
            // 
            lblTotalChange.AutoSize = true;
            lblTotalChange.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalChange.Location = new Point(793, 913);
            lblTotalChange.Name = "lblTotalChange";
            lblTotalChange.Size = new Size(0, 32);
            lblTotalChange.TabIndex = 17;
            // 
            // btnNextPerson
            // 
            btnNextPerson.BackColor = Color.LightGreen;
            btnNextPerson.Location = new Point(606, 356);
            btnNextPerson.Name = "btnNextPerson";
            btnNextPerson.Size = new Size(100, 43);
            btnNextPerson.TabIndex = 33;
            btnNextPerson.Text = "NEXT";
            btnNextPerson.UseVisualStyleBackColor = false;
            btnNextPerson.Click += btnNextPerson_Click_1;
            // 
            // lblTipHeader
            // 
            lblTipHeader.AutoSize = true;
            lblTipHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipHeader.Location = new Point(12, 410);
            lblTipHeader.Name = "lblTipHeader";
            lblTipHeader.Size = new Size(72, 41);
            lblTipHeader.TabIndex = 34;
            lblTipHeader.Text = "TIP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 501);
            label4.Name = "label4";
            label4.Size = new Size(252, 28);
            label4.TabIndex = 35;
            label4.Text = "Would you like to add Tip ?";
            // 
            // txtTipAmount
            // 
            txtTipAmount.BackColor = SystemColors.Control;
            txtTipAmount.ForeColor = SystemColors.InactiveCaptionText;
            txtTipAmount.Location = new Point(756, 510);
            txtTipAmount.Name = "txtTipAmount";
            txtTipAmount.Size = new Size(139, 25);
            txtTipAmount.TabIndex = 36;
            // 
            // lblFeddbackHeader
            // 
            lblFeddbackHeader.AutoSize = true;
            lblFeddbackHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeddbackHeader.Location = new Point(11, 620);
            lblFeddbackHeader.Name = "lblFeddbackHeader";
            lblFeddbackHeader.Size = new Size(174, 41);
            lblFeddbackHeader.TabIndex = 37;
            lblFeddbackHeader.Text = "FEEDBACK:";
            // 
            // lblTipQuestion
            // 
            lblTipQuestion.AutoSize = true;
            lblTipQuestion.Location = new Point(11, 705);
            lblTipQuestion.Name = "lblTipQuestion";
            lblTipQuestion.Size = new Size(250, 19);
            lblTipQuestion.TabIndex = 39;
            lblTipQuestion.Text = "Do you have any comment or feedback";
            // 
            // txtFeedback
            // 
            txtFeedback.BackColor = SystemColors.Control;
            txtFeedback.Location = new Point(734, 700);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(161, 25);
            txtFeedback.TabIndex = 40;
            // 
            // lblThankfulMessage
            // 
            lblThankfulMessage.AutoSize = true;
            lblThankfulMessage.Location = new Point(43, 570);
            lblThankfulMessage.Name = "lblThankfulMessage";
            lblThankfulMessage.Size = new Size(0, 19);
            lblThankfulMessage.TabIndex = 41;
            // 
            // btnAddTip
            // 
            btnAddTip.BackColor = Color.LightGreen;
            btnAddTip.Location = new Point(813, 564);
            btnAddTip.Name = "btnAddTip";
            btnAddTip.Size = new Size(82, 43);
            btnAddTip.TabIndex = 38;
            btnAddTip.Text = "ADD";
            btnAddTip.UseVisualStyleBackColor = false;
            btnAddTip.Click += btnAddTip_Click;
            // 
            // lblInsufficientPaymnt
            // 
            lblInsufficientPaymnt.AutoSize = true;
            lblInsufficientPaymnt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsufficientPaymnt.Location = new Point(145, 892);
            lblInsufficientPaymnt.Name = "lblInsufficientPaymnt";
            lblInsufficientPaymnt.Size = new Size(0, 28);
            lblInsufficientPaymnt.TabIndex = 42;
            // 
            // btnSubmitAll
            // 
            btnSubmitAll.BackColor = Color.LightGreen;
            btnSubmitAll.Location = new Point(798, 741);
            btnSubmitAll.Name = "btnSubmitAll";
            btnSubmitAll.Size = new Size(97, 43);
            btnSubmitAll.TabIndex = 43;
            btnSubmitAll.Text = "SUBMIT";
            btnSubmitAll.UseVisualStyleBackColor = false;
            btnSubmitAll.Click += btnSubmitAll_Click;
            // 
            // DisplayPaymentMethod
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(985, 1055);
            Controls.Add(btnSubmitAll);
            Controls.Add(lblInsufficientPaymnt);
            Controls.Add(lblThankfulMessage);
            Controls.Add(txtFeedback);
            Controls.Add(lblTipQuestion);
            Controls.Add(btnAddTip);
            Controls.Add(lblFeddbackHeader);
            Controls.Add(txtTipAmount);
            Controls.Add(label4);
            Controls.Add(lblTipHeader);
            Controls.Add(btnNextPerson);
            Controls.Add(pnlPersonControls);
            Controls.Add(btnSetNumber);
            Controls.Add(numericUpDownNumberOfPeople);
            Controls.Add(lblTotalAmountPaid);
            Controls.Add(btnPAY);
            Controls.Add(lblTotalChange);
            Controls.Add(lblChange);
            Controls.Add(lblAmountPaidByCustomers);
            Controls.Add(groupBoxSplitOption);
            Controls.Add(lblSplitQuestion);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayPaymentMethod";
            Tag = "-";
            Text = "DisplayPaymentMethod";
            groupBoxSplitOption.ResumeLayout(false);
            groupBoxSplitOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSplitQuestion;
        private RadioButton rbtnYes;
        private RadioButton rbtnNo;
        private GroupBox groupBoxSplitOption;
        private Label lblAmountPaidByCustomers;
        private Label lblChange;
        private Button btnPAY;
        private Label lblTotalAmountPaid;
        private NumericUpDown numericUpDownNumberOfPeople;
        private Button btnSetNumber;
        private Panel pnlPersonControls;
        private Label lblTotalChange;
        private Button btnNextPerson;
        private Label lblTipHeader;
        private Label label4;
        private TextBox txtTipAmount;
        private Label lblFeddbackHeader;
        private Label lblTipQuestion;
        private TextBox txtFeedback;
        private Label lblThankfulMessage;
        private Button btnAddTip;
        private Label lblInsufficientPaymnt;
        private Button btnSubmitAll;
    }
}