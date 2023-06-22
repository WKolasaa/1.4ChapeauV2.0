namespace ChapeauUI
{
    partial class ManagerMenuAddAndUpdate
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
            txtAddMenuID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddMenuDesciprion = new TextBox();
            txtAddMenuPrice = new TextBox();
            btAddMenu = new Button();
            btCancel = new Button();
            label4 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            cbCategory = new ComboBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // txtAddMenuID
            // 
            txtAddMenuID.Enabled = false;
            txtAddMenuID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuID.Location = new Point(255, 22);
            txtAddMenuID.Name = "txtAddMenuID";
            txtAddMenuID.Size = new Size(212, 29);
            txtAddMenuID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 7;
            label1.Text = "Menu Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 89);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 9;
            label2.Text = "Menu Item Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 143);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 10;
            label3.Text = "Menu Item Price:";
            // 
            // txtAddMenuDesciprion
            // 
            txtAddMenuDesciprion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuDesciprion.Location = new Point(255, 81);
            txtAddMenuDesciprion.Name = "txtAddMenuDesciprion";
            txtAddMenuDesciprion.Size = new Size(212, 29);
            txtAddMenuDesciprion.TabIndex = 11;
            // 
            // txtAddMenuPrice
            // 
            txtAddMenuPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuPrice.Location = new Point(255, 135);
            txtAddMenuPrice.Name = "txtAddMenuPrice";
            txtAddMenuPrice.Size = new Size(212, 29);
            txtAddMenuPrice.TabIndex = 12;
            // 
            // btAddMenu
            // 
            btAddMenu.BackColor = Color.FromArgb(138, 210, 176);
            btAddMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAddMenu.Location = new Point(55, 352);
            btAddMenu.Name = "btAddMenu";
            btAddMenu.Size = new Size(202, 29);
            btAddMenu.TabIndex = 13;
            btAddMenu.Text = "Add Menu Item";
            btAddMenu.UseVisualStyleBackColor = false;
            btAddMenu.Click += btAddMenu_Click;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.FromArgb(245, 108, 117);
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.Location = new Point(301, 352);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(166, 29);
            btCancel.TabIndex = 14;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 202);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 15;
            label4.Text = "Menu Item Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 299);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 19;
            label6.Text = "Menu Item VAT:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(255, 299);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 25);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "6%";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(402, 299);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 25);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "21%";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(255, 194);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(212, 29);
            cbCategory.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 249);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 23;
            label5.Text = "Menu Item Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(255, 246);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(212, 29);
            txtQuantity.TabIndex = 24;
            // 
            // ManagerMenuAddAndUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(cbCategory);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btCancel);
            Controls.Add(btAddMenu);
            Controls.Add(txtAddMenuPrice);
            Controls.Add(txtAddMenuDesciprion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAddMenuID);
            Controls.Add(label1);
            Name = "ManagerMenuAddAndUpdate";
            Text = "ManagerMenuAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddMenuID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAddMenuDesciprion;
        private TextBox txtAddMenuPrice;
        private Button btAddMenu;
        private Button btCancel;
        private Label label4;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox cbCategory;
        private Label label5;
        private TextBox txtQuantity;
    }
}