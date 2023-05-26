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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            pnlDashboard = new Panel();
            pnlOrderView = new Panel();
            menuStrip1 = new MenuStrip();
            listViewMenuItems = new ListView();
            pnlDashboard.SuspendLayout();
            pnlOrderView.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlOrderView);
            pnlDashboard.Location = new Point(12, 53);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(575, 648);
            pnlDashboard.TabIndex = 0;
            // 
            // pnlOrderView
            // 
            pnlOrderView.Controls.Add(listViewMenuItems);
            pnlOrderView.Location = new Point(0, 3);
            pnlOrderView.Name = "pnlOrderView";
            pnlOrderView.Size = new Size(563, 645);
            pnlOrderView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(587, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // listViewMenuItems
            // 
            listViewMenuItems.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listViewMenuItems.Location = new Point(16, 14);
            listViewMenuItems.Name = "listViewMenuItems";
            listViewMenuItems.Size = new Size(533, 610);
            listViewMenuItems.TabIndex = 0;
            listViewMenuItems.UseCompatibleStateImageBehavior = false;
            listViewMenuItems.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 713);
            Controls.Add(pnlDashboard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            pnlDashboard.ResumeLayout(false);
            pnlOrderView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDashboard;
        private MenuStrip menuStrip1;
        private Panel pnlOrderView;
        private ListView listViewMenuItems;
    }
}