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
            this.btnVisa = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPriceExcVAT = new System.Windows.Forms.Label();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewBill
            // 
            this.ListViewBill.Location = new System.Drawing.Point(94, 85);
            this.ListViewBill.Name = "ListViewBill";
            this.ListViewBill.Size = new System.Drawing.Size(812, 599);
            this.ListViewBill.TabIndex = 0;
            this.ListViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // txtTotalPriceWithoutVat
            // 
            this.txtTotalPriceWithoutVat.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPriceWithoutVat.Location = new System.Drawing.Point(719, 690);
            this.txtTotalPriceWithoutVat.Name = "txtTotalPriceWithoutVat";
            this.txtTotalPriceWithoutVat.Size = new System.Drawing.Size(187, 57);
            this.txtTotalPriceWithoutVat.TabIndex = 2;
            this.txtTotalPriceWithoutVat.TextChanged += new System.EventHandler(this.txtTotalPriceWithoutVat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "BILL";
            // 
            // btnVisa
            // 
            this.btnVisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisa.Location = new System.Drawing.Point(85, 943);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(150, 46);
            this.btnVisa.TabIndex = 4;
            this.btnVisa.Text = "VISA";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDebit.Location = new System.Drawing.Point(416, 943);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(150, 46);
            this.btnDebit.TabIndex = 5;
            this.btnDebit.Text = "DEBIT";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.Location = new System.Drawing.Point(747, 943);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(150, 46);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 847);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "PAYMENT METHOD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 1063);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "ORDER PRICE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(94, 1184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT:";
            // 
            // lblPriceExcVAT
            // 
            this.lblPriceExcVAT.AutoSize = true;
            this.lblPriceExcVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceExcVAT.Location = new System.Drawing.Point(793, 1081);
            this.lblPriceExcVAT.Name = "lblPriceExcVAT";
            this.lblPriceExcVAT.Size = new System.Drawing.Size(35, 37);
            this.lblPriceExcVAT.TabIndex = 12;
            this.lblPriceExcVAT.Text = "..";
            this.lblPriceExcVAT.Click += new System.EventHandler(this.lblPriceExcVAT_Click);
            // 
            // lblTotalVAT
            // 
            this.lblTotalVAT.AutoSize = true;
            this.lblTotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVAT.Location = new System.Drawing.Point(795, 1195);
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.lblTotalVAT.Size = new System.Drawing.Size(35, 37);
            this.lblTotalVAT.TabIndex = 13;
            this.lblTotalVAT.Text = "..";
            this.lblTotalVAT.Click += new System.EventHandler(this.lblTotalVAT_Click);
            // 
            // DisplayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 1373);
            this.Controls.Add(this.lblTotalVAT);
            this.Controls.Add(this.lblPriceExcVAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnVisa);
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
        private Button btnVisa;
        private Button btnDebit;
        private Button btnCash;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblPriceExcVAT;
        private Label lblTotalVAT;
    }
}