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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaymentHistoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT HAS BEEN COMPLETED";
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(224, 648);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(234, 46);
            this.btnTableView.TabIndex = 1;
            this.btnTableView.Text = "Table View";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(680, 451);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(94, 46);
            this.btnPaymentHistory.TabIndex = 2;
            this.btnPaymentHistory.Text = "SET ID";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // listViewPaymentHistory
            // 
            this.listViewPaymentHistory.Location = new System.Drawing.Point(3, 89);
            this.listViewPaymentHistory.Name = "listViewPaymentHistory";
            this.listViewPaymentHistory.Size = new System.Drawing.Size(804, 142);
            this.listViewPaymentHistory.TabIndex = 3;
            this.listViewPaymentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Display payementHistory by ID";
            // 
            // txtPaymentHistoryID
            // 
            this.txtPaymentHistoryID.Location = new System.Drawing.Point(647, 406);
            this.txtPaymentHistoryID.Name = "txtPaymentHistoryID";
            this.txtPaymentHistoryID.Size = new System.Drawing.Size(127, 39);
            this.txtPaymentHistoryID.TabIndex = 5;
            // 
            // DisplayPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 952);
            this.Controls.Add(this.txtPaymentHistoryID);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private TextBox txtPaymentHistoryID;
    }
}