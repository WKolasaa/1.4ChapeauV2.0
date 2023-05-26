namespace ChapeauUI
{
    partial class ManagerStockAdd
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
            txtAddStockQuantity = new TextBox();
            txtAddStockName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAddStockID = new TextBox();
            label1 = new Label();
            btCancel = new Button();
            SuspendLayout();
            // 
            // btAddStock
            // 
            btAddStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAddStock.Location = new Point(74, 299);
            btAddStock.Name = "btAddStock";
            btAddStock.Size = new Size(190, 29);
            btAddStock.TabIndex = 20;
            btAddStock.Text = "Add Stock Item";
            btAddStock.UseVisualStyleBackColor = true;
            btAddStock.Click += btAddStock_Click;
            // 
            // txtAddStockQuantity
            // 
            txtAddStockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddStockQuantity.Location = new Point(274, 200);
            txtAddStockQuantity.Name = "txtAddStockQuantity";
            txtAddStockQuantity.Size = new Size(212, 29);
            txtAddStockQuantity.TabIndex = 19;
            // 
            // txtAddStockName
            // 
            txtAddStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddStockName.Location = new Point(274, 127);
            txtAddStockName.Name = "txtAddStockName";
            txtAddStockName.Size = new Size(212, 29);
            txtAddStockName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 208);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 17;
            label3.Text = "Stock Item Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 135);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 16;
            label2.Text = "Stock Item Name:";
            // 
            // txtAddStockID
            // 
            txtAddStockID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddStockID.Location = new Point(274, 65);
            txtAddStockID.Name = "txtAddStockID";
            txtAddStockID.Size = new Size(212, 29);
            txtAddStockID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 14;
            label1.Text = "Stock Item ID:";
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(320, 299);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(166, 29);
            btCancel.TabIndex = 21;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // ManagerStockAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(btCancel);
            Controls.Add(btAddStock);
            Controls.Add(txtAddStockQuantity);
            Controls.Add(txtAddStockName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAddStockID);
            Controls.Add(label1);
            Name = "ManagerStockAdd";
            Text = "ManagerStockAdd";
            Load += ManagerStockAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddStock;
        private TextBox txtAddStockQuantity;
        private TextBox txtAddStockName;
        private Label label3;
        private Label label2;
        private TextBox txtAddStockID;
        private Label label1;
        private Button btCancel;
    }
}