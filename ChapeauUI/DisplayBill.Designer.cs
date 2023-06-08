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
            this.txtTotalPriceWithoutVat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.lblPriceWithVAT = new System.Windows.Forms.Label();
            this.lblResultPriceWithVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewBill
            // 
            this.ListViewBill.Location = new System.Drawing.Point(50, 67);
            this.ListViewBill.Name = "ListViewBill";
            this.ListViewBill.Size = new System.Drawing.Size(782, 520);
            this.ListViewBill.TabIndex = 0;
            this.ListViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // txtTotalPriceWithoutVat
            // 
            this.txtTotalPriceWithoutVat.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPriceWithoutVat.Location = new System.Drawing.Point(631, 616);
            this.txtTotalPriceWithoutVat.Name = "txtTotalPriceWithoutVat";
            this.txtTotalPriceWithoutVat.Size = new System.Drawing.Size(201, 57);
            this.txtTotalPriceWithoutVat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "BILL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT:";
            // 
            // lblTotalVAT
            // 
            this.lblTotalVAT.AutoSize = true;
            this.lblTotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVAT.Location = new System.Drawing.Point(797, 733);
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.lblTotalVAT.Size = new System.Drawing.Size(35, 37);
            this.lblTotalVAT.TabIndex = 13;
            this.lblTotalVAT.Text = "..";
            this.lblTotalVAT.Click += new System.EventHandler(this.lblTotalVAT_Click);
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToPayment.Location = new System.Drawing.Point(185, 978);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(508, 87);
            this.btnProceedToPayment.TabIndex = 14;
            this.btnProceedToPayment.Text = "Proceed To Payment";
            this.btnProceedToPayment.UseVisualStyleBackColor = true;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // lblPriceWithVAT
            // 
            this.lblPriceWithVAT.AutoSize = true;
            this.lblPriceWithVAT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceWithVAT.Location = new System.Drawing.Point(36, 842);
            this.lblPriceWithVAT.Name = "lblPriceWithVAT";
            this.lblPriceWithVAT.Size = new System.Drawing.Size(303, 40);
            this.lblPriceWithVAT.TabIndex = 15;
            this.lblPriceWithVAT.Text = "Total Price Include VAT";
            // 
            // lblResultPriceWithVAT
            // 
            this.lblResultPriceWithVAT.AutoSize = true;
            this.lblResultPriceWithVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultPriceWithVAT.Location = new System.Drawing.Point(797, 845);
            this.lblResultPriceWithVAT.Name = "lblResultPriceWithVAT";
            this.lblResultPriceWithVAT.Size = new System.Drawing.Size(35, 37);
            this.lblResultPriceWithVAT.TabIndex = 16;
            this.lblResultPriceWithVAT.Text = "..";
            // 
            // DisplayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 1094);
            this.Controls.Add(this.lblResultPriceWithVAT);
            this.Controls.Add(this.lblPriceWithVAT);
            this.Controls.Add(this.btnProceedToPayment);
            this.Controls.Add(this.lblTotalVAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalPriceWithoutVat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewBill);
            this.Name = "DisplayBill";
            this.Text = "DisplayBill";
            this.Load += new System.EventHandler(this.DisplayBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView ListViewBill;
        private Label label1;
        private TextBox txtTotalPriceWithoutVat;
        private Label label2;
        private Label label5;
        private Label lblTotalVAT;
        private Button btnProceedToPayment;
        private Label lblPriceWithVAT;
        private Label lblResultPriceWithVAT;
    }
}