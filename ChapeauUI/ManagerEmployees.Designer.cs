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
            btEmployeesAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesAdd.Location = new Point(49, 332);
            btEmployeesAdd.Name = "btEmployeesAdd";
            btEmployeesAdd.Size = new Size(134, 52);
            btEmployeesAdd.TabIndex = 1;
            btEmployeesAdd.Text = "Add";
            btEmployeesAdd.UseVisualStyleBackColor = true;
            btEmployeesAdd.Click += btEmployeesAdd_Click;
            // 
            // btEmployeesRemove
            // 
            btEmployeesRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesRemove.Location = new Point(621, 332);
            btEmployeesRemove.Name = "btEmployeesRemove";
            btEmployeesRemove.Size = new Size(134, 52);
            btEmployeesRemove.TabIndex = 2;
            btEmployeesRemove.Text = "Remove";
            btEmployeesRemove.UseVisualStyleBackColor = true;
            btEmployeesRemove.Click += btEmployeesRemove_Click;
            // 
            // btEmployeesUpdate
            // 
            btEmployeesUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEmployeesUpdate.Location = new Point(324, 332);
            btEmployeesUpdate.Name = "btEmployeesUpdate";
            btEmployeesUpdate.Size = new Size(134, 52);
            btEmployeesUpdate.TabIndex = 3;
            btEmployeesUpdate.Text = "Update";
            btEmployeesUpdate.UseVisualStyleBackColor = true;
            btEmployeesUpdate.Click += btEmployeesUpdate_Click;
            // 
            // ManagerEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btEmployeesUpdate);
            Controls.Add(btEmployeesRemove);
            Controls.Add(btEmployeesAdd);
            Controls.Add(lvEmployees);
            Name = "ManagerEmployees";
            Text = "ManagerEmployees";
            Load += ManagerEmployees_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvEmployees;
        private Button btEmployeesAdd;
        private Button btEmployeesRemove;
        private Button btEmployeesUpdate;
    }
}