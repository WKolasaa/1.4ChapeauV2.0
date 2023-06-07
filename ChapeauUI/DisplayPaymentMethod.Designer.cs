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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSplitQuestion = new System.Windows.Forms.Label();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.groupBoxSplitOption = new System.Windows.Forms.GroupBox();
            this.lblAmountPaidByCustomers = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnPAY = new System.Windows.Forms.Button();
            this.lblTotalAmountPaid = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.btnSetNumber = new System.Windows.Forms.Button();
            this.pnlPersonControls = new System.Windows.Forms.Panel();
            this.lblTotalChange = new System.Windows.Forms.Label();
            this.btnNextPerson = new System.Windows.Forms.Button();
            this.lblTipHeader = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.lblFeddbackHeader = new System.Windows.Forms.Label();
            this.lblTipQuestion = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblThankfulMessage = new System.Windows.Forms.Label();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.lblInsufficientPaymnt = new System.Windows.Forms.Label();
            this.btnSubmitAll = new System.Windows.Forms.Button();
            this.groupBoxSplitOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do you want to split the bill ?";
            // 
            // lblSplitQuestion
            // 
            this.lblSplitQuestion.AutoSize = true;
            this.lblSplitQuestion.Location = new System.Drawing.Point(11, 198);
            this.lblSplitQuestion.Name = "lblSplitQuestion";
            this.lblSplitQuestion.Size = new System.Drawing.Size(186, 30);
            this.lblSplitQuestion.TabIndex = 2;
            this.lblSplitQuestion.Text = "Number Of People";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(6, 36);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(74, 34);
            this.rbtnYes.TabIndex = 3;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(112, 36);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(72, 34);
            this.rbtnNo.TabIndex = 4;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // groupBoxSplitOption
            // 
            this.groupBoxSplitOption.Controls.Add(this.rbtnNo);
            this.groupBoxSplitOption.Controls.Add(this.rbtnYes);
            this.groupBoxSplitOption.Location = new System.Drawing.Point(620, 55);
            this.groupBoxSplitOption.Name = "groupBoxSplitOption";
            this.groupBoxSplitOption.Size = new System.Drawing.Size(188, 78);
            this.groupBoxSplitOption.TabIndex = 8;
            this.groupBoxSplitOption.TabStop = false;
            // 
            // lblAmountPaidByCustomers
            // 
            this.lblAmountPaidByCustomers.AutoSize = true;
            this.lblAmountPaidByCustomers.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountPaidByCustomers.Location = new System.Drawing.Point(361, 827);
            this.lblAmountPaidByCustomers.Name = "lblAmountPaidByCustomers";
            this.lblAmountPaidByCustomers.Size = new System.Drawing.Size(235, 50);
            this.lblAmountPaidByCustomers.TabIndex = 12;
            this.lblAmountPaidByCustomers.Text = "Amount Paid";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(375, 908);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(167, 50);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "CHANGE";
            // 
            // btnPAY
            // 
            this.btnPAY.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPAY.Location = new System.Drawing.Point(309, 1016);
            this.btnPAY.Name = "btnPAY";
            this.btnPAY.Size = new System.Drawing.Size(258, 52);
            this.btnPAY.TabIndex = 20;
            this.btnPAY.Text = "PAY";
            this.btnPAY.UseVisualStyleBackColor = true;
            this.btnPAY.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalAmountPaid
            // 
            this.lblTotalAmountPaid.AutoSize = true;
            this.lblTotalAmountPaid.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmountPaid.Location = new System.Drawing.Point(739, 827);
            this.lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            this.lblTotalAmountPaid.Size = new System.Drawing.Size(46, 50);
            this.lblTotalAmountPaid.TabIndex = 23;
            this.lblTotalAmountPaid.Text = "...";
            // 
            // numericUpDownNumberOfPeople
            // 
            this.numericUpDownNumberOfPeople.Location = new System.Drawing.Point(662, 191);
            this.numericUpDownNumberOfPeople.Name = "numericUpDownNumberOfPeople";
            this.numericUpDownNumberOfPeople.Size = new System.Drawing.Size(130, 35);
            this.numericUpDownNumberOfPeople.TabIndex = 29;
            // 
            // btnSetNumber
            // 
            this.btnSetNumber.Location = new System.Drawing.Point(691, 233);
            this.btnSetNumber.Name = "btnSetNumber";
            this.btnSetNumber.Size = new System.Drawing.Size(101, 43);
            this.btnSetNumber.TabIndex = 30;
            this.btnSetNumber.Text = "SET";
            this.btnSetNumber.UseVisualStyleBackColor = true;
            this.btnSetNumber.Click += new System.EventHandler(this.btnSetNumber_Click);
            // 
            // pnlPersonControls
            // 
            this.pnlPersonControls.AutoSize = true;
            this.pnlPersonControls.Location = new System.Drawing.Point(99, 297);
            this.pnlPersonControls.Name = "pnlPersonControls";
            this.pnlPersonControls.Size = new System.Drawing.Size(606, 53);
            this.pnlPersonControls.TabIndex = 31;
            // 
            // lblTotalChange
            // 
            this.lblTotalChange.AutoSize = true;
            this.lblTotalChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalChange.Location = new System.Drawing.Point(746, 913);
            this.lblTotalChange.Name = "lblTotalChange";
            this.lblTotalChange.Size = new System.Drawing.Size(0, 45);
            this.lblTotalChange.TabIndex = 17;
            // 
            // btnNextPerson
            // 
            this.btnNextPerson.Location = new System.Drawing.Point(606, 356);
            this.btnNextPerson.Name = "btnNextPerson";
            this.btnNextPerson.Size = new System.Drawing.Size(100, 43);
            this.btnNextPerson.TabIndex = 33;
            this.btnNextPerson.Text = "NEXT";
            this.btnNextPerson.UseVisualStyleBackColor = true;
            this.btnNextPerson.Click += new System.EventHandler(this.btnNextPerson_Click_1);
            // 
            // lblTipHeader
            // 
            this.lblTipHeader.AutoSize = true;
            this.lblTipHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipHeader.Location = new System.Drawing.Point(11, 409);
            this.lblTipHeader.Name = "lblTipHeader";
            this.lblTipHeader.Size = new System.Drawing.Size(113, 65);
            this.lblTipHeader.TabIndex = 34;
            this.lblTipHeader.Text = "TIP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "Would you like to add Tip ?";
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(643, 507);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(139, 35);
            this.txtTipAmount.TabIndex = 36;
            // 
            // lblFeddbackHeader
            // 
            this.lblFeddbackHeader.AutoSize = true;
            this.lblFeddbackHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFeddbackHeader.Location = new System.Drawing.Point(11, 620);
            this.lblFeddbackHeader.Name = "lblFeddbackHeader";
            this.lblFeddbackHeader.Size = new System.Drawing.Size(278, 65);
            this.lblFeddbackHeader.TabIndex = 37;
            this.lblFeddbackHeader.Text = "FEEDBACK:";
            // 
            // lblTipQuestion
            // 
            this.lblTipQuestion.AutoSize = true;
            this.lblTipQuestion.Location = new System.Drawing.Point(11, 705);
            this.lblTipQuestion.Name = "lblTipQuestion";
            this.lblTipQuestion.Size = new System.Drawing.Size(378, 30);
            this.lblTipQuestion.TabIndex = 39;
            this.lblTipQuestion.Text = "Do you have any comment or feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(662, 702);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(161, 35);
            this.txtFeedback.TabIndex = 40;
            // 
            // lblThankfulMessage
            // 
            this.lblThankfulMessage.AutoSize = true;
            this.lblThankfulMessage.Location = new System.Drawing.Point(43, 570);
            this.lblThankfulMessage.Name = "lblThankfulMessage";
            this.lblThankfulMessage.Size = new System.Drawing.Size(0, 30);
            this.lblThankfulMessage.TabIndex = 41;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(700, 563);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(82, 43);
            this.btnAddTip.TabIndex = 38;
            this.btnAddTip.Text = "ADD";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // lblInsufficientPaymnt
            // 
            this.lblInsufficientPaymnt.AutoSize = true;
            this.lblInsufficientPaymnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsufficientPaymnt.Location = new System.Drawing.Point(145, 892);
            this.lblInsufficientPaymnt.Name = "lblInsufficientPaymnt";
            this.lblInsufficientPaymnt.Size = new System.Drawing.Size(0, 45);
            this.lblInsufficientPaymnt.TabIndex = 42;
            // 
            // btnSubmitAll
            // 
            this.btnSubmitAll.Location = new System.Drawing.Point(725, 744);
            this.btnSubmitAll.Name = "btnSubmitAll";
            this.btnSubmitAll.Size = new System.Drawing.Size(97, 43);
            this.btnSubmitAll.TabIndex = 43;
            this.btnSubmitAll.Text = "SUBMIT";
            this.btnSubmitAll.UseVisualStyleBackColor = true;
            this.btnSubmitAll.Click += new System.EventHandler(this.btnSubmitAll_Click);
            // 
            // DisplayPaymentMethod
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(891, 1106);
            this.Controls.Add(this.btnSubmitAll);
            this.Controls.Add(this.lblInsufficientPaymnt);
            this.Controls.Add(this.lblThankfulMessage);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblTipQuestion);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.lblFeddbackHeader);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTipHeader);
            this.Controls.Add(this.btnNextPerson);
            this.Controls.Add(this.pnlPersonControls);
            this.Controls.Add(this.btnSetNumber);
            this.Controls.Add(this.numericUpDownNumberOfPeople);
            this.Controls.Add(this.lblTotalAmountPaid);
            this.Controls.Add(this.btnPAY);
            this.Controls.Add(this.lblTotalChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAmountPaidByCustomers);
            this.Controls.Add(this.groupBoxSplitOption);
            this.Controls.Add(this.lblSplitQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DisplayPaymentMethod";
            this.Tag = "-";
            this.Text = "DisplayPaymentMethod";
            this.groupBoxSplitOption.ResumeLayout(false);
            this.groupBoxSplitOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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