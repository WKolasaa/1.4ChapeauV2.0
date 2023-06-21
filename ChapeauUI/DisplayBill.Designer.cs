namespace ChapeauUI
{
    partial class DisplayBill
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
            ListViewBill = new ListView();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            lblTotalVAT = new Label();
            btnProceedToPayment = new Button();
            lblPriceWithVAT = new Label();
            lblResultPriceWithVAT = new Label();
            lblAmountExcludeVAT = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            lblTableNumber = new Label();
            SuspendLayout();
            // 
            // ListViewBill
            // 
            ListViewBill.BackColor = SystemColors.InactiveBorder;
            ListViewBill.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            ListViewBill.Location = new Point(18, 76);
            ListViewBill.Margin = new Padding(2, 1, 2, 1);
            ListViewBill.Name = "ListViewBill";
            ListViewBill.Size = new Size(850, 246);
            ListViewBill.TabIndex = 0;
            ListViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 340);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 1;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 3;
            label2.Text = "Bill Summary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 387);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 9;
            label5.Text = "VAT:";
            // 
            // lblTotalVAT
            // 
            lblTotalVAT.AutoSize = true;
            lblTotalVAT.BackColor = SystemColors.ButtonHighlight;
            lblTotalVAT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalVAT.Location = new Point(741, 397);
            lblTotalVAT.Margin = new Padding(2, 0, 2, 0);
            lblTotalVAT.Name = "lblTotalVAT";
            lblTotalVAT.Size = new Size(0, 20);
            lblTotalVAT.TabIndex = 13;
            // 
            // btnProceedToPayment
            // 
            btnProceedToPayment.BackColor = Color.MediumAquamarine;
            btnProceedToPayment.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnProceedToPayment.Location = new Point(301, 474);
            btnProceedToPayment.Margin = new Padding(2, 1, 2, 1);
            btnProceedToPayment.Name = "btnProceedToPayment";
            btnProceedToPayment.Size = new Size(274, 41);
            btnProceedToPayment.TabIndex = 14;
            btnProceedToPayment.Text = "Proceed To Payment";
            btnProceedToPayment.UseVisualStyleBackColor = false;
            btnProceedToPayment.Click += btnProceedToPayment_Click;
            // 
            // lblPriceWithVAT
            // 
            lblPriceWithVAT.AutoSize = true;
            lblPriceWithVAT.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceWithVAT.Location = new Point(26, 428);
            lblPriceWithVAT.Margin = new Padding(2, 0, 2, 0);
            lblPriceWithVAT.Name = "lblPriceWithVAT";
            lblPriceWithVAT.Size = new Size(140, 30);
            lblPriceWithVAT.TabIndex = 15;
            lblPriceWithVAT.Text = "Bill Amount:";
            // 
            // lblResultPriceWithVAT
            // 
            lblResultPriceWithVAT.AutoSize = true;
            lblResultPriceWithVAT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultPriceWithVAT.Location = new Point(741, 437);
            lblResultPriceWithVAT.Margin = new Padding(2, 0, 2, 0);
            lblResultPriceWithVAT.Name = "lblResultPriceWithVAT";
            lblResultPriceWithVAT.Size = new Size(0, 20);
            lblResultPriceWithVAT.TabIndex = 16;
            // 
            // lblAmountExcludeVAT
            // 
            lblAmountExcludeVAT.AutoSize = true;
            lblAmountExcludeVAT.BackColor = SystemColors.Control;
            lblAmountExcludeVAT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountExcludeVAT.Location = new Point(741, 346);
            lblAmountExcludeVAT.Margin = new Padding(2, 0, 2, 0);
            lblAmountExcludeVAT.Name = "lblAmountExcludeVAT";
            lblAmountExcludeVAT.Size = new Size(0, 20);
            lblAmountExcludeVAT.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 456);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 18;
            label3.Text = "*Include VAT";
            // 
            // label4
            // 
            label4.BackColor = Color.Orange;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(18, 321);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(850, 6);
            label4.TabIndex = 19;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(18, 327);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(850, 51);
            label6.TabIndex = 20;
            // 
            // lblTableNumber
            // 
            lblTableNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNumber.Location = new Point(18, 43);
            lblTableNumber.Margin = new Padding(2, 0, 2, 0);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(126, 30);
            lblTableNumber.TabIndex = 21;
            // 
            // DisplayBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(879, 535);
            Controls.Add(lblTableNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblAmountExcludeVAT);
            Controls.Add(lblResultPriceWithVAT);
            Controls.Add(lblPriceWithVAT);
            Controls.Add(btnProceedToPayment);
            Controls.Add(lblTotalVAT);
            Controls.Add(label1);
            Controls.Add(ListViewBill);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "DisplayBill";
            Text = "DisplayBill";
            Load += DisplayBill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewBill;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label lblTotalVAT;
        private Button btnProceedToPayment;
        private Label lblPriceWithVAT;
        private Label lblResultPriceWithVAT;
        private Label lblAmountExcludeVAT;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label lblTableNumber;
    }
}