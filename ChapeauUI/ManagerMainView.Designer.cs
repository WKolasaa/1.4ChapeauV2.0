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
            btMenuEmployees = new Button();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            lbUser = new Label();
            btLogout = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cbIncome = new ComboBox();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            pnCustom = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnCustom.SuspendLayout();
            SuspendLayout();
            // 
            // btManagerEmployees
            // 
            btManagerEmployees.BackColor = Color.FromArgb(138, 210, 176);
            btManagerEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btManagerEmployees.Location = new Point(315, 191);
            btManagerEmployees.Name = "btManagerEmployees";
            btManagerEmployees.Size = new Size(161, 52);
            btManagerEmployees.TabIndex = 0;
            btManagerEmployees.Text = "Employees";
            btManagerEmployees.UseVisualStyleBackColor = false;
            btManagerEmployees.Click += btManagerEmployees_Click;
            // 
            // btMenuEmployees
            // 
            btMenuEmployees.BackColor = Color.FromArgb(138, 210, 176);
            btMenuEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuEmployees.Location = new Point(315, 310);
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
            menuStrip1.ImageScalingSize = new Size(20, 20);
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
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(12, 25);
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
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.Location = new Point(604, 48);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(57, 21);
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
            pictureBox1.Location = new Point(290, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 73);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 15;
            label1.Text = "Today's income: ";
            // 
            // cbIncome
            // 
            cbIncome.FormattingEnabled = true;
            cbIncome.Location = new Point(3, 106);
            cbIncome.Margin = new Padding(3, 2, 3, 2);
            cbIncome.Name = "cbIncome";
            cbIncome.Size = new Size(204, 23);
            cbIncome.TabIndex = 17;
            cbIncome.SelectedIndexChanged += cbIncome_SelectedIndexChanged;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(2, 24);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(200, 23);
            dtStart.TabIndex = 18;
            dtStart.ValueChanged += dtStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(4, 84);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(200, 23);
            dtEnd.TabIndex = 19;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(2, 2);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 20;
            label2.Text = "Start date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 21;
            label3.Text = "End date:";
            // 
            // pnCustom
            // 
            pnCustom.Controls.Add(label2);
            pnCustom.Controls.Add(dtEnd);
            pnCustom.Controls.Add(label3);
            pnCustom.Controls.Add(dtStart);
            pnCustom.Location = new Point(3, 143);
            pnCustom.Name = "pnCustom";
            pnCustom.Size = new Size(237, 119);
            pnCustom.TabIndex = 22;
            // 
            // ManagerMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnCustom);
            Controls.Add(cbIncome);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btLogout);
            Controls.Add(lbUser);
            Controls.Add(btMenuEmployees);
            Controls.Add(btManagerEmployees);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ManagerMainView";
            Text = "ManagerMainView";
            Load += ManagerMainView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnCustom.ResumeLayout(false);
            pnCustom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btManagerEmployees;
        private Button btMenuEmployees;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label lbUser;
        private Button btLogout;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cbIncome;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Label label2;
        private Label label3;
        private Panel pnCustom;
    }
}