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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            btStockUpdate = new Button();
            btStockRemove = new Button();
            btStockAdd = new Button();
            lvStock = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            // btStockUpdate
            // 
            btStockUpdate.BackColor = Color.FromArgb(255, 179, 71);
            btStockUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStockUpdate.Location = new Point(324, 365);
            btStockUpdate.Name = "btStockUpdate";
            btStockUpdate.Size = new Size(134, 52);
            btStockUpdate.TabIndex = 8;
            btStockUpdate.Text = "Update";
            btStockUpdate.UseVisualStyleBackColor = false;
            btStockUpdate.Click += btStockUpdate_Click;
            // 
            // btStockRemove
            // 
            btStockRemove.BackColor = Color.FromArgb(245, 108, 117);
            btStockRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStockRemove.Location = new Point(621, 365);
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
            btStockAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStockAdd.Location = new Point(49, 365);
            btStockAdd.Name = "btStockAdd";
            btStockAdd.Size = new Size(134, 52);
            btStockAdd.TabIndex = 6;
            btStockAdd.Text = "Add";
            btStockAdd.UseVisualStyleBackColor = false;
            btStockAdd.Click += btStockAdd_Click;
            // 
            // lvStock
            // 
            lvStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvStock.FullRowSelect = true;
            lvStock.GridLines = true;
            lvStock.Location = new Point(49, 66);
            lvStock.MultiSelect = false;
            lvStock.Name = "lvStock";
            lvStock.Size = new Size(706, 239);
            lvStock.TabIndex = 5;
            lvStock.UseCompatibleStateImageBehavior = false;
            lvStock.SelectedIndexChanged += lvStock_SelectedIndexChanged;
            // 
            // ManagerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(btStockUpdate);
            Controls.Add(btStockRemove);
            Controls.Add(btStockAdd);
            Controls.Add(lvStock);
            Name = "ManagerStock";
            Text = "ManagerStock";
            Load += ManagerStock_Load;
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
    }
}