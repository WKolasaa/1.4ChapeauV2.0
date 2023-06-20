namespace ChapeauUI
{
    partial class ManagerEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerEmployees));
            lvEmployees = new ListView();
            ID = new ColumnHeader();
            Name = new ColumnHeader();
            User_Name = new ColumnHeader();
            Role = new ColumnHeader();
            btEmployeesAdd = new Button();
            btEmployeesRemove = new Button();
            btEmployeesUpdate = new Button();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvEmployees
            // 
            lvEmployees.Columns.AddRange(new ColumnHeader[] { ID, Name, User_Name, Role });
            lvEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvEmployees.FullRowSelect = true;
            lvEmployees.GridLines = true;
            lvEmployees.Location = new Point(47, 107);
            lvEmployees.MultiSelect = false;
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(706, 239);
            lvEmployees.TabIndex = 0;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.Details;
            lvEmployees.SelectedIndexChanged += lvEmployees_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 200;
            // 
            // User_Name
            // 
            User_Name.Text = "User Name";
            User_Name.Width = 200;
            // 
            // Role
            // 
            Role.Text = "Role";
            Role.Width = 150;
            // 
            // btEmployeesAdd
            // 
            btEmployeesAdd.BackColor = Color.FromArgb(138, 210, 176);
            btEmployeesAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btEmployeesAdd.Location = new Point(47, 384);
            btEmployeesAdd.Name = "btEmployeesAdd";
            btEmployeesAdd.Size = new Size(134, 52);
            btEmployeesAdd.TabIndex = 1;
            btEmployeesAdd.Text = "Add";
            btEmployeesAdd.UseVisualStyleBackColor = false;
            btEmployeesAdd.Click += btEmployeesAdd_Click;
            // 
            // btEmployeesRemove
            // 
            btEmployeesRemove.BackColor = Color.FromArgb(245, 108, 117);
            btEmployeesRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btEmployeesRemove.Location = new Point(619, 384);
            btEmployeesRemove.Name = "btEmployeesRemove";
            btEmployeesRemove.Size = new Size(134, 52);
            btEmployeesRemove.TabIndex = 2;
            btEmployeesRemove.Text = "Remove";
            btEmployeesRemove.UseVisualStyleBackColor = false;
            btEmployeesRemove.Click += btEmployeesRemove_Click;
            // 
            // btEmployeesUpdate
            // 
            btEmployeesUpdate.BackColor = Color.FromArgb(255, 179, 71);
            btEmployeesUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btEmployeesUpdate.Location = new Point(322, 384);
            btEmployeesUpdate.Name = "btEmployeesUpdate";
            btEmployeesUpdate.Size = new Size(134, 52);
            btEmployeesUpdate.TabIndex = 3;
            btEmployeesUpdate.Text = "Adjust";
            btEmployeesUpdate.UseVisualStyleBackColor = false;
            btEmployeesUpdate.Click += btEmployeesUpdate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, employeesToolStripMenuItem, stockToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 4;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(243, 54);
            label1.TabIndex = 12;
            label1.Text = "EMPLOYEES";
            // 
            // ManagerEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(btEmployeesUpdate);
            Controls.Add(btEmployeesRemove);
            Controls.Add(btEmployeesAdd);
            Controls.Add(lvEmployees);
            Controls.Add(label1);
            Text = "ManagerEmployees";
            Load += ManagerEmployees_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvEmployees;
        private Button btEmployeesAdd;
        private Button btEmployeesRemove;
        private Button btEmployeesUpdate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ColumnHeader ID;
        private ColumnHeader Name;
        private ColumnHeader User_Name;
        private ColumnHeader Role;
        private PictureBox pictureBox1;
        private Label label1;
    }
}