namespace ChapeauUI
{
    partial class ManagerStock
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
            Label label1;
            PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerStock));
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            btStockUpdate = new Button();
            btStockRemove = new Button();
            btStockAdd = new Button();
            lvStock = new ListView();
            ID = new ColumnHeader();
            Name = new ColumnHeader();
            Quantity = new ColumnHeader();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(148, 54);
            label1.TabIndex = 10;
            label1.Text = "STOCK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, employeesToolStripMenuItem, stockToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 9;
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
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(62, 25);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // btStockUpdate
            // 
            btStockUpdate.BackColor = Color.FromArgb(255, 179, 71);
            btStockUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btStockUpdate.Location = new Point(322, 384);
            btStockUpdate.Name = "btStockUpdate";
            btStockUpdate.Size = new Size(134, 52);
            btStockUpdate.TabIndex = 8;
            btStockUpdate.Text = "Adjust";
            btStockUpdate.UseVisualStyleBackColor = false;
            btStockUpdate.Click += btStockUpdate_Click;
            // 
            // btStockRemove
            // 
            btStockRemove.BackColor = Color.FromArgb(245, 108, 117);
            btStockRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btStockRemove.Location = new Point(619, 384);
            btStockRemove.Name = "btStockRemove";
            btStockRemove.Size = new Size(134, 52);
            btStockRemove.TabIndex = 7;
            btStockRemove.Text = "Remove";
            btStockRemove.UseVisualStyleBackColor = false;
            btStockRemove.Click += btStockRemove_Click;
            // 
            // btStockAdd
            // 
            btStockAdd.BackColor = Color.FromArgb(138, 210, 176);
            btStockAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btStockAdd.Location = new Point(47, 384);
            btStockAdd.Name = "btStockAdd";
            btStockAdd.Size = new Size(134, 52);
            btStockAdd.TabIndex = 6;
            btStockAdd.Text = "Add";
            btStockAdd.UseVisualStyleBackColor = false;
            btStockAdd.Click += btStockAdd_Click;
            // 
            // lvStock
            // 
            lvStock.Columns.AddRange(new ColumnHeader[] { ID, Name, Quantity });
            lvStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvStock.FullRowSelect = true;
            lvStock.GridLines = true;
            lvStock.Location = new Point(47, 107);
            lvStock.MultiSelect = false;
            lvStock.Name = "lvStock";
            lvStock.Size = new Size(706, 239);
            lvStock.TabIndex = 5;
            lvStock.UseCompatibleStateImageBehavior = false;
            lvStock.View = View.Details;
            lvStock.SelectedIndexChanged += lvStock_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 500;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 100;
            // 
            // ManagerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(btStockUpdate);
            Controls.Add(btStockRemove);
            Controls.Add(btStockAdd);
            Controls.Add(lvStock);
            Controls.Add(label1);
            Text = "ManagerStock";
            Load += ManagerStock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Button btStockUpdate;
        private Button btStockRemove;
        private Button btStockAdd;
        private ListView lvStock;
        private ColumnHeader ID;
        private ColumnHeader Name;
        private ColumnHeader Quantity;
        private Label label1;
        private PictureBox pictureBox1;
    }
}