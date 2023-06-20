namespace ChapeauUI
{
    partial class TableOrderView
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrderView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Userlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.listcolumnName = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.BillBtn = new System.Windows.Forms.Button();
            this.AddOrderbtn = new System.Windows.Forms.Button();
            this.ReserveTableBtn = new System.Windows.Forms.Button();
            this.FreeTableBtn = new System.Windows.Forms.Button();
            this.tableNumberlbl = new System.Windows.Forms.Label();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Quantity";
            columnHeader1.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Userlbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.GoBackBtn);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 219);
            this.panel1.TabIndex = 0;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(1263, 94);
            this.Userlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(0, 32);
            this.Userlbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1191, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoBackBtn.Location = new System.Drawing.Point(21, 125);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(156, 72);
            this.GoBackBtn.TabIndex = 1;
            this.GoBackBtn.Text = "Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.Location = new System.Drawing.Point(21, 26);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(156, 72);
            this.LogoutBtn.TabIndex = 0;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listcolumnName,
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.Location = new System.Drawing.Point(23, 277);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(1106, 710);
            this.listViewOrders.TabIndex = 1;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // listcolumnName
            // 
            this.listcolumnName.Text = "Name";
            this.listcolumnName.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comment";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OrderTime";
            this.columnHeader5.Width = 100;
            // 
            // BillBtn
            // 
            this.BillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BillBtn.Location = new System.Drawing.Point(1168, 434);
            this.BillBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(213, 102);
            this.BillBtn.TabIndex = 2;
            this.BillBtn.Text = "Bill";
            this.BillBtn.UseVisualStyleBackColor = true;
            // 
            // AddOrderbtn
            // 
            this.AddOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddOrderbtn.Location = new System.Drawing.Point(1168, 277);
            this.AddOrderbtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddOrderbtn.Name = "AddOrderbtn";
            this.AddOrderbtn.Size = new System.Drawing.Size(213, 102);
            this.AddOrderbtn.TabIndex = 3;
            this.AddOrderbtn.Text = "Add Order";
            this.AddOrderbtn.UseVisualStyleBackColor = true;
            // 
            // ReserveTableBtn
            // 
            this.ReserveTableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReserveTableBtn.Location = new System.Drawing.Point(1168, 587);
            this.ReserveTableBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ReserveTableBtn.Name = "ReserveTableBtn";
            this.ReserveTableBtn.Size = new System.Drawing.Size(213, 102);
            this.ReserveTableBtn.TabIndex = 4;
            this.ReserveTableBtn.Text = "Reserve Table";
            this.ReserveTableBtn.UseVisualStyleBackColor = true;
            // 
            // FreeTableBtn
            // 
            this.FreeTableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FreeTableBtn.Location = new System.Drawing.Point(1168, 722);
            this.FreeTableBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FreeTableBtn.Name = "FreeTableBtn";
            this.FreeTableBtn.Size = new System.Drawing.Size(213, 102);
            this.FreeTableBtn.TabIndex = 5;
            this.FreeTableBtn.Text = "FreeTable";
            this.FreeTableBtn.UseVisualStyleBackColor = true;
            // 
            // tableNumberlbl
            // 
            this.tableNumberlbl.AutoSize = true;
            this.tableNumberlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableNumberlbl.Location = new System.Drawing.Point(518, 226);
            this.tableNumberlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableNumberlbl.Name = "tableNumberlbl";
            this.tableNumberlbl.Size = new System.Drawing.Size(47, 45);
            this.tableNumberlbl.TabIndex = 6;
            this.tableNumberlbl.Text = "...";
            // 
            // TableOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1485, 1083);
            this.Controls.Add(this.tableNumberlbl);
            this.Controls.Add(this.FreeTableBtn);
            this.Controls.Add(this.ReserveTableBtn);
            this.Controls.Add(this.AddOrderbtn);
            this.Controls.Add(this.BillBtn);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TableOrderView";
            this.Text = "TableOrderView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Userlbl;
        private Label label1;
        private PictureBox pictureBox1;
        private Button GoBackBtn;
        private Button LogoutBtn;
        private ListView listViewOrders;
        private Button BillBtn;
        private Button AddOrderbtn;
        private Button ReserveTableBtn;
        private Button FreeTableBtn;
        private ColumnHeader listcolumnName;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label tableNumberlbl;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}