namespace ChapeauUI
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            btMenuUpdate = new Button();
            btMenuRemove = new Button();
            btMenuAdd = new Button();
            lvMenu = new ListView();
            columnHeader1 = new ColumnHeader();
            Name = new ColumnHeader();
            Price = new ColumnHeader();
            VatCategory = new ColumnHeader();
            Category = new ColumnHeader();
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
            // btMenuUpdate
            // 
            btMenuUpdate.BackColor = Color.FromArgb(255, 179, 71);
            btMenuUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuUpdate.Location = new Point(322, 384);
            btMenuUpdate.Name = "btMenuUpdate";
            btMenuUpdate.Size = new Size(134, 52);
            btMenuUpdate.TabIndex = 7;
            btMenuUpdate.Text = "Adjust";
            btMenuUpdate.UseVisualStyleBackColor = false;
            btMenuUpdate.Click += btMenuUpdate_Click;
            // 
            // btMenuRemove
            // 
            btMenuRemove.BackColor = Color.FromArgb(245, 108, 117);
            btMenuRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuRemove.Location = new Point(619, 384);
            btMenuRemove.Name = "btMenuRemove";
            btMenuRemove.Size = new Size(134, 52);
            btMenuRemove.TabIndex = 6;
            btMenuRemove.Text = "Remove";
            btMenuRemove.UseVisualStyleBackColor = false;
            btMenuRemove.Click += btMenuRemove_Click;
            // 
            // btMenuAdd
            // 
            btMenuAdd.BackColor = Color.FromArgb(138, 210, 176);
            btMenuAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuAdd.Location = new Point(47, 384);
            btMenuAdd.Name = "btMenuAdd";
            btMenuAdd.Size = new Size(134, 52);
            btMenuAdd.TabIndex = 5;
            btMenuAdd.Text = "Add";
            btMenuAdd.UseVisualStyleBackColor = false;
            btMenuAdd.Click += btMenuAdd_Click;
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, Name, Price, VatCategory, Category });
            lvMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvMenu.FullRowSelect = true;
            lvMenu.GridLines = true;
            lvMenu.Location = new Point(47, 107);
            lvMenu.MultiSelect = false;
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(706, 239);
            lvMenu.TabIndex = 4;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.Details;
            lvMenu.SelectedIndexChanged += lvMenu_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 400;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 80;
            // 
            // VatCategory
            // 
            VatCategory.Text = "VAT";
            // 
            // Category
            // 
            Category.Text = "Type";
            Category.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, employeesToolStripMenuItem, stockToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 8;
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
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 14;
            label1.Text = "MENU";
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(btMenuUpdate);
            Controls.Add(btMenuRemove);
            Controls.Add(btMenuAdd);
            Controls.Add(lvMenu);
            Controls.Add(label1);
            Text = "ManagerMenu";
            Load += ManagerMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMenuUpdate;
        private Button btMenuRemove;
        private Button btMenuAdd;
        private ListView lvMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private ColumnHeader columnHeader1;
        private ColumnHeader VatCategory;
        private ColumnHeader Category;
        private PictureBox pictureBox1;
        private Label label1;
    }
}