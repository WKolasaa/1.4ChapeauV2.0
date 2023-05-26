namespace ChapeauUI
{
    partial class ManagerMenuUpdate
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
            btUpdateMenu = new Button();
            txtAddMenuPrice = new TextBox();
            txtAddMenuDesciprion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAddMenuID = new TextBox();
            label1 = new Label();
            btCancel = new Button();
            SuspendLayout();
            // 
            // btUpdateMenu
            // 
            btUpdateMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btUpdateMenu.Location = new Point(71, 289);
            btUpdateMenu.Name = "btUpdateMenu";
            btUpdateMenu.Size = new Size(185, 29);
            btUpdateMenu.TabIndex = 20;
            btUpdateMenu.Text = "Update Menu Item";
            btUpdateMenu.UseVisualStyleBackColor = true;
            btUpdateMenu.Click += btUpdateMenu_Click_1;
            // 
            // txtAddMenuPrice
            // 
            txtAddMenuPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuPrice.Location = new Point(271, 191);
            txtAddMenuPrice.Name = "txtAddMenuPrice";
            txtAddMenuPrice.Size = new Size(212, 29);
            txtAddMenuPrice.TabIndex = 19;
            // 
            // txtAddMenuDesciprion
            // 
            txtAddMenuDesciprion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuDesciprion.Location = new Point(271, 118);
            txtAddMenuDesciprion.Name = "txtAddMenuDesciprion";
            txtAddMenuDesciprion.Size = new Size(212, 29);
            txtAddMenuDesciprion.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 199);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 17;
            label3.Text = "Menu Item Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 126);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 16;
            label2.Text = "Menu Item Description:";
            // 
            // txtAddMenuID
            // 
            txtAddMenuID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddMenuID.Location = new Point(271, 56);
            txtAddMenuID.Name = "txtAddMenuID";
            txtAddMenuID.Size = new Size(212, 29);
            txtAddMenuID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 64);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 14;
            label1.Text = "Menu Item ID:";
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(317, 289);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(166, 29);
            btCancel.TabIndex = 21;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // ManagerMenuUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(btCancel);
            Controls.Add(btUpdateMenu);
            Controls.Add(txtAddMenuPrice);
            Controls.Add(txtAddMenuDesciprion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAddMenuID);
            Controls.Add(label1);
            Name = "ManagerMenuUpdate";
            Text = "ManagerMenuUpdate";
            Load += ManagerMenuUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdateMenu;
        private TextBox txtAddMenuPrice;
        private TextBox txtAddMenuDesciprion;
        private Label label3;
        private Label label2;
        private TextBox txtAddMenuID;
        private Label label1;
        private Button btCancel;
    }
}