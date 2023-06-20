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
            ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrderView));
            panel1 = new Panel();
            namelabel = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            GoBackBtn = new Button();
            LogoutBtn = new Button();
            listViewOrders = new ListView();
            listcolumnName = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            BillBtn = new Button();
            AddOrderbtn = new Button();
            ReserveTableBtn = new Button();
            FreeTableBtn = new Button();
            tableNumberlbl = new Label();
            serveBtn = new Button();
            columnHeader1 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Quantity";
            columnHeader1.Width = 100;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(GoBackBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Location = new Point(-1, -2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 136);
            panel1.TabIndex = 0;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.BackColor = Color.FromArgb(255, 179, 71);
            namelabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            namelabel.Location = new Point(781, 41);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(0, 20);
            namelabel.TabIndex = 4;
            namelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 179, 71);
            button1.Enabled = false;
            button1.Location = new Point(762, 25);
            button1.Name = "button1";
            button1.Size = new Size(119, 53);
            button1.TabIndex = 3;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.FromArgb(138, 210, 176);
            GoBackBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackBtn.Location = new Point(13, 78);
            GoBackBtn.Margin = new Padding(3, 4, 3, 4);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(96, 45);
            GoBackBtn.TabIndex = 1;
            GoBackBtn.Text = "Back";
            GoBackBtn.UseVisualStyleBackColor = false;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 179, 71);
            LogoutBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.Location = new Point(13, 16);
            LogoutBtn.Margin = new Padding(3, 4, 3, 4);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(96, 45);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { listcolumnName, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(14, 173);
            listViewOrders.Margin = new Padding(3, 4, 3, 4);
            listViewOrders.MultiSelect = false;
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(682, 445);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged;
            // 
            // listcolumnName
            // 
            listcolumnName.Text = "Name";
            listcolumnName.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Comment";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "OrderTime";
            columnHeader5.Width = 100;
            // 
            // BillBtn
            // 
            BillBtn.BackColor = Color.FromArgb(138, 210, 176);
            BillBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BillBtn.Location = new Point(719, 262);
            BillBtn.Margin = new Padding(3, 4, 3, 4);
            BillBtn.Name = "BillBtn";
            BillBtn.Size = new Size(131, 64);
            BillBtn.TabIndex = 2;
            BillBtn.Text = "Bill";
            BillBtn.UseVisualStyleBackColor = false;
            BillBtn.Click += BillBtn_Click;
            // 
            // AddOrderbtn
            // 
            AddOrderbtn.BackColor = Color.FromArgb(138, 210, 176);
            AddOrderbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrderbtn.Location = new Point(719, 173);
            AddOrderbtn.Margin = new Padding(3, 4, 3, 4);
            AddOrderbtn.Name = "AddOrderbtn";
            AddOrderbtn.Size = new Size(131, 64);
            AddOrderbtn.TabIndex = 3;
            AddOrderbtn.Text = "Add Order";
            AddOrderbtn.UseVisualStyleBackColor = false;
            AddOrderbtn.Click += AddOrderbtn_Click;
            // 
            // ReserveTableBtn
            // 
            ReserveTableBtn.BackColor = Color.FromArgb(238, 164, 127);
            ReserveTableBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReserveTableBtn.Location = new Point(719, 344);
            ReserveTableBtn.Margin = new Padding(3, 4, 3, 4);
            ReserveTableBtn.Name = "ReserveTableBtn";
            ReserveTableBtn.Size = new Size(131, 64);
            ReserveTableBtn.TabIndex = 4;
            ReserveTableBtn.Text = "Reserve Table";
            ReserveTableBtn.UseVisualStyleBackColor = false;
            ReserveTableBtn.Click += OccupyTableBtn_Click;
            // 
            // FreeTableBtn
            // 
            FreeTableBtn.BackColor = Color.FromArgb(255, 179, 71);
            FreeTableBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FreeTableBtn.Location = new Point(719, 435);
            FreeTableBtn.Margin = new Padding(3, 4, 3, 4);
            FreeTableBtn.Name = "FreeTableBtn";
            FreeTableBtn.Size = new Size(131, 64);
            FreeTableBtn.TabIndex = 5;
            FreeTableBtn.Text = "FreeTable";
            FreeTableBtn.UseVisualStyleBackColor = false;
            FreeTableBtn.Click += FreeTableBtn_Click;
            // 
            // tableNumberlbl
            // 
            tableNumberlbl.AutoSize = true;
            tableNumberlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableNumberlbl.Location = new Point(351, 141);
            tableNumberlbl.Name = "tableNumberlbl";
            tableNumberlbl.Size = new Size(0, 28);
            tableNumberlbl.TabIndex = 6;
            // 
            // serveBtn
            // 
            serveBtn.BackColor = Color.FromArgb(138, 210, 176);
            serveBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            serveBtn.Location = new Point(719, 526);
            serveBtn.Margin = new Padding(3, 4, 3, 4);
            serveBtn.Name = "serveBtn";
            serveBtn.Size = new Size(131, 64);
            serveBtn.TabIndex = 7;
            serveBtn.Text = "Serve";
            serveBtn.UseVisualStyleBackColor = false;
            serveBtn.Click += serveBtn_Click;
            // 
            // TableOrderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 677);
            Controls.Add(serveBtn);
            Controls.Add(tableNumberlbl);
            Controls.Add(FreeTableBtn);
            Controls.Add(ReserveTableBtn);
            Controls.Add(AddOrderbtn);
            Controls.Add(BillBtn);
            Controls.Add(listViewOrders);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TableOrderView";
            Text = "TableOrderView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private Button serveBtn;
        private Label namelabel;
        private Button button1;
    }
}