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
            this.groupBoxPaymentMethods = new System.Windows.Forms.GroupBox();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            this.dataGridViewSplitBill = new System.Windows.Forms.DataGridView();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblAmountPaidByCustomers = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotalChange = new System.Windows.Forms.Label();
            this.lblPaymentMethodNoSplit = new System.Windows.Forms.Label();
            this.btnPAY = new System.Windows.Forms.Button();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.lblTotalAmountPaid = new System.Windows.Forms.Label();
            this.groupBoxSplitOption.SuspendLayout();
            this.groupBoxPaymentMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSplitBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do you want to split the bill ?";
            // 
            // lblSplitQuestion
            // 
            this.lblSplitQuestion.AutoSize = true;
            this.lblSplitQuestion.Location = new System.Drawing.Point(12, 225);
            this.lblSplitQuestion.Name = "lblSplitQuestion";
            this.lblSplitQuestion.Size = new System.Drawing.Size(451, 32);
            this.lblSplitQuestion.TabIndex = 2;
            this.lblSplitQuestion.Text = "How many people you want to split with:";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(6, 55);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(79, 36);
            this.rbtnYes.TabIndex = 3;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(127, 55);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(77, 36);
            this.rbtnNo.TabIndex = 4;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // groupBoxSplitOption
            // 
            this.groupBoxSplitOption.Controls.Add(this.rbtnNo);
            this.groupBoxSplitOption.Controls.Add(this.rbtnYes);
            this.groupBoxSplitOption.Location = new System.Drawing.Point(679, 65);
            this.groupBoxSplitOption.Name = "groupBoxSplitOption";
            this.groupBoxSplitOption.Size = new System.Drawing.Size(204, 127);
            this.groupBoxSplitOption.TabIndex = 8;
            this.groupBoxSplitOption.TabStop = false;
            // 
            // groupBoxPaymentMethods
            // 
            this.groupBoxPaymentMethods.Controls.Add(this.btnDebit);
            this.groupBoxPaymentMethods.Controls.Add(this.btnCash);
            this.groupBoxPaymentMethods.Controls.Add(this.btnVisa);
            this.groupBoxPaymentMethods.Location = new System.Drawing.Point(138, 625);
            this.groupBoxPaymentMethods.Name = "groupBoxPaymentMethods";
            this.groupBoxPaymentMethods.Size = new System.Drawing.Size(650, 79);
            this.groupBoxPaymentMethods.TabIndex = 11;
            this.groupBoxPaymentMethods.TabStop = false;
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(238, 27);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(150, 46);
            this.btnDebit.TabIndex = 12;
            this.btnDebit.Text = "DEBIT";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(494, 27);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(150, 46);
            this.btnCash.TabIndex = 13;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(16, 27);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(150, 46);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // dataGridViewSplitBill
            // 
            this.dataGridViewSplitBill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSplitBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSplitBill.Location = new System.Drawing.Point(138, 298);
            this.dataGridViewSplitBill.Name = "dataGridViewSplitBill";
            this.dataGridViewSplitBill.RowHeadersWidth = 82;
            this.dataGridViewSplitBill.RowTemplate.Height = 41;
            this.dataGridViewSplitBill.Size = new System.Drawing.Size(700, 280);
            this.dataGridViewSplitBill.TabIndex = 22;
            this.dataGridViewSplitBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSplitBill_CellContentClick);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(688, 584);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(150, 46);
            this.btnSet.TabIndex = 24;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblAmountPaidByCustomers
            // 
            this.lblAmountPaidByCustomers.AutoSize = true;
            this.lblAmountPaidByCustomers.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountPaidByCustomers.Location = new System.Drawing.Point(394, 763);
            this.lblAmountPaidByCustomers.Name = "lblAmountPaidByCustomers";
            this.lblAmountPaidByCustomers.Size = new System.Drawing.Size(235, 50);
            this.lblAmountPaidByCustomers.TabIndex = 12;
            this.lblAmountPaidByCustomers.Text = "Amount Paid";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(394, 882);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(167, 50);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "CHANGE";
            // 
            // lblTotalChange
            // 
            this.lblTotalChange.AutoSize = true;
            this.lblTotalChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalChange.Location = new System.Drawing.Point(792, 886);
            this.lblTotalChange.Name = "lblTotalChange";
            this.lblTotalChange.Size = new System.Drawing.Size(41, 45);
            this.lblTotalChange.TabIndex = 17;
            this.lblTotalChange.Text = "...";
            // 
            // lblPaymentMethodNoSplit
            // 
            this.lblPaymentMethodNoSplit.AutoSize = true;
            this.lblPaymentMethodNoSplit.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentMethodNoSplit.Location = new System.Drawing.Point(12, 378);
            this.lblPaymentMethodNoSplit.Name = "lblPaymentMethodNoSplit";
            this.lblPaymentMethodNoSplit.Size = new System.Drawing.Size(409, 59);
            this.lblPaymentMethodNoSplit.TabIndex = 19;
            this.lblPaymentMethodNoSplit.Text = "PAYMENT METHOD:";
            // 
            // btnPAY
            // 
            this.btnPAY.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPAY.Location = new System.Drawing.Point(307, 995);
            this.btnPAY.Name = "btnPAY";
            this.btnPAY.Size = new System.Drawing.Size(280, 56);
            this.btnPAY.TabIndex = 20;
            this.btnPAY.Text = "PAY";
            this.btnPAY.UseVisualStyleBackColor = true;
            this.btnPAY.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(747, 218);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(136, 39);
            this.txtNumberOfPeople.TabIndex = 21;
            this.txtNumberOfPeople.TextChanged += new System.EventHandler(this.txtNumberOfPeople_TextChanged_1);
            // 
            // lblTotalAmountPaid
            // 
            this.lblTotalAmountPaid.AutoSize = true;
            this.lblTotalAmountPaid.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmountPaid.Location = new System.Drawing.Point(792, 746);
            this.lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            this.lblTotalAmountPaid.Size = new System.Drawing.Size(46, 50);
            this.lblTotalAmountPaid.TabIndex = 23;
            this.lblTotalAmountPaid.Text = "...";
            // 
            // DisplayPaymentMethod
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(920, 1078);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblTotalAmountPaid);
            this.Controls.Add(this.dataGridViewSplitBill);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.btnPAY);
            this.Controls.Add(this.lblPaymentMethodNoSplit);
            this.Controls.Add(this.lblTotalChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblAmountPaidByCustomers);
            this.Controls.Add(this.groupBoxPaymentMethods);
            this.Controls.Add(this.groupBoxSplitOption);
            this.Controls.Add(this.lblSplitQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayPaymentMethod";
            this.Text = "DisplayPaymentMethod";
            this.groupBoxSplitOption.ResumeLayout(false);
            this.groupBoxSplitOption.PerformLayout();
            this.groupBoxPaymentMethods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSplitBill)).EndInit();
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
        private GroupBox groupBoxPaymentMethods;
        private Button btnDebit;
        private Button btnCash;
        private Button btnVisa;
        private Label lblAmountPaidByCustomers;
        private Label lblChange;
        private Label lblTotalChange;
        private Label lblPaymentMethodNoSplit;
        private Button btnPAY;
        private TextBox txtNumberOfPeople;
        private DataGridView dataGridViewSplitBill;
        private Label lblTotalAmountPaid;
        private Button btnSet;
    }
}