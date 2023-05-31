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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.lblThankfulMessage = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.btnSetTip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DO you want to add Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIP:";
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(587, 110);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(173, 39);
            this.txtTipAmount.TabIndex = 2;
            this.txtTipAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblThankfulMessage
            // 
            this.lblThankfulMessage.AutoSize = true;
            this.lblThankfulMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblThankfulMessage.Location = new System.Drawing.Point(192, 263);
            this.lblThankfulMessage.Name = "lblThankfulMessage";
            this.lblThankfulMessage.Size = new System.Drawing.Size(40, 50);
            this.lblThankfulMessage.TabIndex = 3;
            this.lblThankfulMessage.Text = "..";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(209, 504);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(289, 39);
            this.txtFeedback.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "FEEDBACK:";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(391, 565);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(107, 46);
            this.btnSubmitFeedback.TabIndex = 6;
            this.btnSubmitFeedback.Text = "SUBMIT";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // btnSetTip
            // 
            this.btnSetTip.Location = new System.Drawing.Point(638, 175);
            this.btnSetTip.Name = "btnSetTip";
            this.btnSetTip.Size = new System.Drawing.Size(122, 46);
            this.btnSetTip.TabIndex = 7;
            this.btnSetTip.Text = "SetTip";
            this.btnSetTip.UseVisualStyleBackColor = true;
            this.btnSetTip.Click += new System.EventHandler(this.btnSetTip_Click);
            // 
            // DisplayPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 952);
            this.Controls.Add(this.btnSetTip);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblThankfulMessage);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayPayment";
            this.Text = "Display Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTipAmount;
        private Label lblThankfulMessage;
        private TextBox txtFeedback;
        private Label label3;
        private Button btnSubmitFeedback;
        private Button btnSetTip;
    }
}