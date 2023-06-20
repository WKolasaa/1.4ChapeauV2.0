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
            this.ListViewBill = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.lblPriceWithVAT = new System.Windows.Forms.Label();
            this.lblResultPriceWithVAT = new System.Windows.Forms.Label();
            this.lblAmountExcludeVAT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewBill
            // 
            this.ListViewBill.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListViewBill.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListViewBill.Location = new System.Drawing.Point(33, 163);
            this.ListViewBill.Name = "ListViewBill";
            this.ListViewBill.Size = new System.Drawing.Size(923, 520);
            this.ListViewBill.TabIndex = 0;
            this.ListViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 826);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 59);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT:";
            // 
            // lblTotalVAT
            // 
            this.lblTotalVAT.AutoSize = true;
            this.lblTotalVAT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVAT.Location = new System.Drawing.Point(786, 844);
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.lblTotalVAT.Size = new System.Drawing.Size(0, 37);
            this.lblTotalVAT.TabIndex = 13;
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProceedToPayment.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToPayment.Location = new System.Drawing.Point(220, 1025);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(508, 87);
            this.btnProceedToPayment.TabIndex = 14;
            this.btnProceedToPayment.Text = "Proceed To Payment";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // lblPriceWithVAT
            // 
            this.lblPriceWithVAT.AutoSize = true;
            this.lblPriceWithVAT.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceWithVAT.Location = new System.Drawing.Point(33, 913);
            this.lblPriceWithVAT.Name = "lblPriceWithVAT";
            this.lblPriceWithVAT.Size = new System.Drawing.Size(277, 59);
            this.lblPriceWithVAT.TabIndex = 15;
            this.lblPriceWithVAT.Text = "Bill Amount:";
            // 
            // lblResultPriceWithVAT
            // 
            this.lblResultPriceWithVAT.AutoSize = true;
            this.lblResultPriceWithVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultPriceWithVAT.Location = new System.Drawing.Point(786, 931);
            this.lblResultPriceWithVAT.Name = "lblResultPriceWithVAT";
            this.lblResultPriceWithVAT.Size = new System.Drawing.Size(0, 37);
            this.lblResultPriceWithVAT.TabIndex = 16;
            // 
            // lblAmountExcludeVAT
            // 
            this.lblAmountExcludeVAT.AutoSize = true;
            this.lblAmountExcludeVAT.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountExcludeVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountExcludeVAT.Location = new System.Drawing.Point(786, 737);
            this.lblAmountExcludeVAT.Name = "lblAmountExcludeVAT";
            this.lblAmountExcludeVAT.Size = new System.Drawing.Size(0, 37);
            this.lblAmountExcludeVAT.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 972);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "*Include VAT";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(33, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(923, 10);
            this.label4.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(33, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(923, 109);
            this.label6.TabIndex = 20;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.Location = new System.Drawing.Point(33, 92);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(234, 64);
            this.lblTableNumber.TabIndex = 21;
            // 
            // DisplayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(985, 1142);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmountExcludeVAT);
            this.Controls.Add(this.lblResultPriceWithVAT);
            this.Controls.Add(this.lblPriceWithVAT);
            this.Controls.Add(this.btnProceedToPayment);
            this.Controls.Add(this.lblTotalVAT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewBill);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DisplayBill";
            this.Text = "DisplayBill";
            this.Load += new System.EventHandler(this.DisplayBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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