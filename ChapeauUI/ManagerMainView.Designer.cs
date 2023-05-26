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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            lbUser = new Label();
            btLogout = new Button();
            menuStrip1.SuspendLayout();
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
            btStockEmployees.Click += btStockEmployees_Click;
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
            btMenuEmployees.Click += btMenuEmployees_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, employeesToolStripMenuItem, stockToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(101, 25);
            mainMenuToolStripMenuItem.Text = "Main Menu";
            mainMenuToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(97, 25);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(59, 25);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(62, 25);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUser.Location = new Point(614, 99);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(52, 21);
            lbUser.TabIndex = 4;
            lbUser.Text = "label1";
            // 
            // btLogout
            // 
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btLogout.Location = new Point(615, 139);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(114, 32);
            btLogout.TabIndex = 5;
            btLogout.Text = "Log out";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // ManagerMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLogout);
            Controls.Add(lbUser);
            Controls.Add(btMenuEmployees);
            Controls.Add(btStockEmployees);
            Controls.Add(btManagerEmployees);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ManagerMainView";
            Text = "ManagerMainView";
            Load += ManagerMainView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btManagerEmployees;
        private Button btStockEmployees;
        private Button btMenuEmployees;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label lbUser;
        private Button btLogout;
    }
}