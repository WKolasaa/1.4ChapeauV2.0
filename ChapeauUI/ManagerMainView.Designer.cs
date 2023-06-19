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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainView));
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
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btManagerEmployees
            // 
            btManagerEmployees.BackColor = Color.FromArgb(138, 210, 176);
            btManagerEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btManagerEmployees.Location = new Point(299, 169);
            btManagerEmployees.Name = "btManagerEmployees";
            btManagerEmployees.Size = new Size(161, 52);
            btManagerEmployees.TabIndex = 0;
            btManagerEmployees.Text = "Employees";
            btManagerEmployees.UseVisualStyleBackColor = false;
            btManagerEmployees.Click += btManagerEmployees_Click;
            // 
            // btStockEmployees
            // 
            btStockEmployees.BackColor = Color.FromArgb(138, 210, 176);
            btStockEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btStockEmployees.Location = new Point(299, 270);
            btStockEmployees.Name = "btStockEmployees";
            btStockEmployees.Size = new Size(161, 52);
            btStockEmployees.TabIndex = 1;
            btStockEmployees.Text = "Stock";
            btStockEmployees.UseVisualStyleBackColor = false;
            btStockEmployees.Click += btStockEmployees_Click;
            // 
            // btMenuEmployees
            // 
            btMenuEmployees.BackColor = Color.FromArgb(138, 210, 176);
            btMenuEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuEmployees.Location = new Point(299, 380);
            btMenuEmployees.Name = "btMenuEmployees";
            btMenuEmployees.Size = new Size(161, 52);
            btMenuEmployees.TabIndex = 2;
            btMenuEmployees.Text = "Menu";
            btMenuEmployees.UseVisualStyleBackColor = false;
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
            lbUser.Location = new Point(604, 48);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(52, 21);
            lbUser.TabIndex = 4;
            lbUser.Text = "label1";
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.FromArgb(255, 179, 71);
            btLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btLogout.Location = new Point(604, 88);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(114, 32);
            btLogout.TabIndex = 5;
            btLogout.Text = "Log out";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // ManagerMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}