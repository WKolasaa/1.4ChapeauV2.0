namespace ChapeauUI
{
    partial class ManagerMenuAdd
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
            SuspendLayout();
            // 
            // txtAddMenuID
            // 
            txtAddMenuID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuID.Location = new Point(255, 57);
            txtAddMenuID.Name = "txtAddMenuID";
            txtAddMenuID.Size = new Size(212, 29);
            txtAddMenuID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 65);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 7;
            label1.Text = "Menu Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 127);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 9;
            label2.Text = "Menu Item Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 200);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 10;
            label3.Text = "Menu Item Price:";
            // 
            // txtAddMenuDesciprion
            // 
            txtAddMenuDesciprion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuDesciprion.Location = new Point(255, 119);
            txtAddMenuDesciprion.Name = "txtAddMenuDesciprion";
            txtAddMenuDesciprion.Size = new Size(212, 29);
            txtAddMenuDesciprion.TabIndex = 11;
            // 
            // txtAddMenuPrice
            // 
            txtAddMenuPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuPrice.Location = new Point(255, 192);
            txtAddMenuPrice.Name = "txtAddMenuPrice";
            txtAddMenuPrice.Size = new Size(212, 29);
            txtAddMenuPrice.TabIndex = 12;
            // 
            // btAddMenu
            // 
            btAddMenu.BackColor = Color.FromArgb(138, 210, 176);
            btAddMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAddMenu.Location = new Point(55, 290);
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
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(301, 290);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(166, 29);
            btCancel.TabIndex = 14;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // ManagerMenuAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(btCancel);
            Controls.Add(btAddMenu);
            Controls.Add(txtAddMenuPrice);
            Controls.Add(txtAddMenuDesciprion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAddMenuID);
            Controls.Add(label1);
            Name = "ManagerMenuAdd";
            Text = "ManagerMenuAdd";
            Load += ManagerMenuAdd_Load;
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
    }
}