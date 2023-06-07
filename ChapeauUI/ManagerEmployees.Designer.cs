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
            lvEmployees = new ListView();
            btEmployeesAdd = new Button();
            btEmployeesRemove = new Button();
            btEmployeesUpdate = new Button();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvEmployees
            // 
            lvEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvEmployees.FullRowSelect = true;
            lvEmployees.GridLines = true;
            lvEmployees.Location = new Point(49, 33);
            lvEmployees.MultiSelect = false;
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(706, 239);
            lvEmployees.TabIndex = 0;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.SelectedIndexChanged += lvEmployees_SelectedIndexChanged;
            // 
            // btEmployeesAdd
            // 
            btEmployeesAdd.BackColor = Color.FromArgb(138, 210, 176);
            btEmployeesAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesAdd.Location = new Point(49, 332);
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
            btEmployeesRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesRemove.Location = new Point(621, 332);
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
            btEmployeesUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesUpdate.Location = new Point(324, 332);
            btEmployeesUpdate.Name = "btEmployeesUpdate";
            btEmployeesUpdate.Size = new Size(134, 52);
            btEmployeesUpdate.TabIndex = 3;
            btEmployeesUpdate.Text = "Update";
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
            // ManagerEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(btEmployeesUpdate);
            Controls.Add(btEmployeesRemove);
            Controls.Add(btEmployeesAdd);
            Controls.Add(lvEmployees);
            Name = "ManagerEmployees";
            Text = "ManagerEmployees";
            Load += ManagerEmployees_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}