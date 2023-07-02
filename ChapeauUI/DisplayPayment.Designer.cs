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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.listViewPaymentHistory = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaymentHistoryID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(574, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "THE BILL HAS BEEN           SETTLED!";
            // 
            // btnTableView
            // 
            this.btnTableView.BackColor = System.Drawing.Color.Orange;
            this.btnTableView.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTableView.Location = new System.Drawing.Point(574, 747);
            this.btnTableView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(370, 105);
            this.btnTableView.TabIndex = 1;
            this.btnTableView.Text = "Table View";
            this.btnTableView.UseVisualStyleBackColor = false;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click_1);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaymentHistory.Location = new System.Drawing.Point(1402, 617);
            this.btnPaymentHistory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(95, 47);
            this.btnPaymentHistory.TabIndex = 2;
            this.btnPaymentHistory.Text = "SET ID";
            this.btnPaymentHistory.UseVisualStyleBackColor = false;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click_1);
            // 
            // listViewPaymentHistory
            // 
            this.listViewPaymentHistory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewPaymentHistory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listViewPaymentHistory.Location = new System.Drawing.Point(6, 361);
            this.listViewPaymentHistory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listViewPaymentHistory.Name = "listViewPaymentHistory";
            this.listViewPaymentHistory.Size = new System.Drawing.Size(1564, 143);
            this.listViewPaymentHistory.TabIndex = 3;
            this.listViewPaymentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 567);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Display payementHistory by ID";
            // 
            // txtPaymentHistoryID
            // 
            this.txtPaymentHistoryID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPaymentHistoryID.Location = new System.Drawing.Point(1339, 572);
            this.txtPaymentHistoryID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPaymentHistoryID.Name = "txtPaymentHistoryID";
            this.txtPaymentHistoryID.Size = new System.Drawing.Size(156, 39);
            this.txtPaymentHistoryID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 484);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1566, 19);
            this.label4.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1272, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1586, 922);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaymentHistoryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewPaymentHistory);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.btnTableView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "DisplayPayment";
            this.Text = "Payment History";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label4;
        private PictureBox pictureBox1;
    }
}