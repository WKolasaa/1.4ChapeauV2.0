namespace ChapeauUI
{
    partial class ManagerStockUpdate
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
            btAddStock = new Button();
            txtUpdateStockQuantity = new TextBox();
            txtUpdateStockName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUpdateStockID = new TextBox();
            label1 = new Label();
            btCancel = new Button();
            SuspendLayout();
            // 
            // btAddStock
            // 
            btAddStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAddStock.Location = new Point(79, 296);
            btAddStock.Name = "btAddStock";
            btAddStock.Size = new Size(181, 29);
            btAddStock.TabIndex = 27;
            btAddStock.Text = "Update Stock Item";
            btAddStock.UseVisualStyleBackColor = true;
            btAddStock.Click += btAddStock_Click;
            // 
            // txtUpdateStockQuantity
            // 
            txtUpdateStockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdateStockQuantity.Location = new Point(279, 199);
            txtUpdateStockQuantity.Name = "txtUpdateStockQuantity";
            txtUpdateStockQuantity.Size = new Size(212, 29);
            txtUpdateStockQuantity.TabIndex = 26;
            // 
            // txtUpdateStockName
            // 
            txtUpdateStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdateStockName.Location = new Point(279, 126);
            txtUpdateStockName.Name = "txtUpdateStockName";
            txtUpdateStockName.Size = new Size(212, 29);
            txtUpdateStockName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 207);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 24;
            label3.Text = "Stock Item Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 134);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 23;
            label2.Text = "Stock Item Name:";
            // 
            // txtUpdateStockID
            // 
            txtUpdateStockID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdateStockID.Location = new Point(279, 64);
            txtUpdateStockID.Name = "txtUpdateStockID";
            txtUpdateStockID.Size = new Size(212, 29);
            txtUpdateStockID.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 72);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 21;
            label1.Text = "Stock Item ID:";
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(325, 296);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(166, 29);
            btCancel.TabIndex = 28;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // ManagerStockUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(btCancel);
            Controls.Add(btAddStock);
            Controls.Add(txtUpdateStockQuantity);
            Controls.Add(txtUpdateStockName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUpdateStockID);
            Controls.Add(label1);
            Name = "ManagerStockUpdate";
            Text = "ManagerStockUpdate";
            Load += ManagerStockUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddStock;
        private TextBox txtUpdateStockQuantity;
        private TextBox txtUpdateStockName;
        private Label label3;
        private Label label2;
        private TextBox txtUpdateStockID;
        private Label label1;
        private Button btCancel;
    }
}