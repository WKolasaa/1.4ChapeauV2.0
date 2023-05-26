namespace ChapeauUI
{
    partial class ManagerMainView
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
            btManagerEmployees = new Button();
            btStockEmployees = new Button();
            btMenuEmployees = new Button();
            SuspendLayout();
            // 
            // btManagerEmployees
            // 
            btManagerEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btManagerEmployees.Location = new Point(291, 94);
            btManagerEmployees.Name = "btManagerEmployees";
            btManagerEmployees.Size = new Size(161, 52);
            btManagerEmployees.TabIndex = 0;
            btManagerEmployees.Text = "Employees";
            btManagerEmployees.UseVisualStyleBackColor = true;
            btManagerEmployees.Click += btManagerEmployees_Click;
            // 
            // btStockEmployees
            // 
            btStockEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStockEmployees.Location = new Point(291, 195);
            btStockEmployees.Name = "btStockEmployees";
            btStockEmployees.Size = new Size(161, 52);
            btStockEmployees.TabIndex = 1;
            btStockEmployees.Text = "Stock";
            btStockEmployees.UseVisualStyleBackColor = true;
            // 
            // btMenuEmployees
            // 
            btMenuEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btMenuEmployees.Location = new Point(291, 305);
            btMenuEmployees.Name = "btMenuEmployees";
            btMenuEmployees.Size = new Size(161, 52);
            btMenuEmployees.TabIndex = 2;
            btMenuEmployees.Text = "Menu";
            btMenuEmployees.UseVisualStyleBackColor = true;
            // 
            // ManagerMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMenuEmployees);
            Controls.Add(btStockEmployees);
            Controls.Add(btManagerEmployees);
            Name = "ManagerMainView";
            Text = "ManagerMainView";
            ResumeLayout(false);
        }

        #endregion

        private Button btManagerEmployees;
        private Button btStockEmployees;
        private Button btMenuEmployees;
    }
}