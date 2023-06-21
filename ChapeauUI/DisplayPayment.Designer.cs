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
            label1 = new Label();
            btnTableView = new Button();
            btnPaymentHistory = new Button();
            listViewPaymentHistory = new ListView();
            label2 = new Label();
            txtPaymentHistoryID = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(309, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 58);
            label1.TabIndex = 0;
            label1.Text = "THE BILL HAS BEEN           SETTLED!";
            // 
            // btnTableView
            // 
            btnTableView.BackColor = Color.Orange;
            btnTableView.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTableView.Location = new Point(309, 350);
            btnTableView.Margin = new Padding(2, 1, 2, 1);
            btnTableView.Name = "btnTableView";
            btnTableView.Size = new Size(199, 49);
            btnTableView.TabIndex = 1;
            btnTableView.Text = "Table View";
            btnTableView.UseVisualStyleBackColor = false;
            btnTableView.Click += btnTableView_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = Color.LightGreen;
            btnPaymentHistory.Location = new Point(755, 289);
            btnPaymentHistory.Margin = new Padding(2, 1, 2, 1);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(51, 22);
            btnPaymentHistory.TabIndex = 2;
            btnPaymentHistory.Text = "SET ID";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Click += btnPaymentHistory_Click;
            // 
            // listViewPaymentHistory
            // 
            listViewPaymentHistory.BackColor = SystemColors.InactiveBorder;
            listViewPaymentHistory.ForeColor = SystemColors.InactiveCaptionText;
            listViewPaymentHistory.Location = new Point(3, 169);
            listViewPaymentHistory.Margin = new Padding(2, 1, 2, 1);
            listViewPaymentHistory.Name = "listViewPaymentHistory";
            listViewPaymentHistory.Size = new Size(844, 69);
            listViewPaymentHistory.TabIndex = 3;
            listViewPaymentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 266);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 4;
            label2.Text = "Display payementHistory by ID";
            // 
            // txtPaymentHistoryID
            // 
            txtPaymentHistoryID.BackColor = SystemColors.ControlLight;
            txtPaymentHistoryID.Location = new Point(721, 268);
            txtPaymentHistoryID.Margin = new Padding(2, 1, 2, 1);
            txtPaymentHistoryID.Name = "txtPaymentHistoryID";
            txtPaymentHistoryID.Size = new Size(86, 23);
            txtPaymentHistoryID.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Orange;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(3, 227);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(844, 10);
            label4.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(685, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // DisplayPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(854, 432);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtPaymentHistoryID);
            Controls.Add(label2);
            Controls.Add(listViewPaymentHistory);
            Controls.Add(btnPaymentHistory);
            Controls.Add(btnTableView);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DisplayPayment";
            Text = "Payment History";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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