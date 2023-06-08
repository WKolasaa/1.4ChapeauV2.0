namespace ChapeauUI
{
    partial class DisplayPayment
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
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.listViewPaymentHistory = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Process has been done";
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(30, 348);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(242, 46);
            this.btnTableView.TabIndex = 1;
            this.btnTableView.Text = "Table View";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(492, 348);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(242, 46);
            this.btnPaymentHistory.TabIndex = 2;
            this.btnPaymentHistory.Text = "Payment History";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // listViewPaymentHistory
            // 
            this.listViewPaymentHistory.Location = new System.Drawing.Point(30, 464);
            this.listViewPaymentHistory.Name = "listViewPaymentHistory";
            this.listViewPaymentHistory.Size = new System.Drawing.Size(704, 384);
            this.listViewPaymentHistory.TabIndex = 3;
            this.listViewPaymentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // DisplayPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 952);
            this.Controls.Add(this.listViewPaymentHistory);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.btnTableView);
            this.Controls.Add(this.label1);
            this.Name = "DisplayPayment";
            this.Text = "Payment History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnTableView;
        private Button btnPaymentHistory;
        private ListView listViewPaymentHistory;
    }
}