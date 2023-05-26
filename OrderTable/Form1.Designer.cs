namespace OrderTable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDashboard = new Panel();
            menuStrip1 = new MenuStrip();
            pnlOrder = new Panel();
            pnlDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlOrder);
            pnlDashboard.Location = new Point(12, 53);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(755, 576);
            pnlDashboard.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(779, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pnlOrder
            // 
            pnlOrder.Location = new Point(0, 3);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(752, 573);
            pnlOrder.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 641);
            Controls.Add(pnlDashboard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            pnlDashboard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDashboard;
        private MenuStrip menuStrip1;
        private Panel pnlOrder;
    }
}