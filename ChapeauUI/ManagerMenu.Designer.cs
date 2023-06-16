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
            btMenuUpdate = new Button();
            btMenuRemove = new Button();
            btMenuAdd = new Button();
            lvMenu = new ListView();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btMenuUpdate
            // 
            btMenuUpdate.BackColor = Color.FromArgb(255, 179, 71);
            btMenuUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btMenuUpdate.Location = new Point(322, 349);
            btMenuUpdate.Name = "btMenuUpdate";
            btMenuUpdate.Size = new Size(134, 52);
            btMenuUpdate.TabIndex = 7;
            btMenuUpdate.Text = "Update";
            btMenuUpdate.UseVisualStyleBackColor = false;
            btMenuUpdate.Click += btMenuUpdate_Click;
            // 
            // btMenuRemove
            // 
            btMenuRemove.BackColor = Color.FromArgb(245, 108, 117);
            btMenuRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btMenuRemove.Location = new Point(619, 349);
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
            btMenuAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btMenuAdd.Location = new Point(47, 349);
            btMenuAdd.Name = "btMenuAdd";
            btMenuAdd.Size = new Size(134, 52);
            btMenuAdd.TabIndex = 5;
            btMenuAdd.Text = "Add";
            btMenuAdd.UseVisualStyleBackColor = false;
            btMenuAdd.Click += btMenuAdd_Click;
            // 
            // lvMenu
            // 
            lvMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvMenu.FullRowSelect = true;
            lvMenu.GridLines = true;
            lvMenu.Location = new Point(47, 50);
            lvMenu.MultiSelect = false;
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(706, 239);
            lvMenu.TabIndex = 4;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.SelectedIndexChanged += lvMenu_SelectedIndexChanged;
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
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(btMenuUpdate);
            Controls.Add(btMenuRemove);
            Controls.Add(btMenuAdd);
            Controls.Add(lvMenu);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            Load += ManagerMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}