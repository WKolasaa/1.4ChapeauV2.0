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
            listcolumncomment = new ColumnHeader();
            columnTime = new ColumnHeader();
            BillBtn = new Button();
            AddOrderbtn = new Button();
            FreeTableBtn = new Button();
            tableNumberlbl = new Label();
            serveBtn = new Button();
            ReserveTableBtn = new Button();
            columnHeader1 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Quantity";
            columnHeader1.Width = 113;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(GoBackBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 102);
            panel1.TabIndex = 0;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.BackColor = Color.FromArgb(255, 179, 71);
            namelabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            namelabel.Location = new Point(683, 31);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(0, 17);
            namelabel.TabIndex = 4;
            namelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 179, 71);
            button1.Enabled = false;
            button1.Location = new Point(667, 19);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 3;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.FromArgb(138, 210, 176);
            GoBackBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackBtn.Location = new Point(11, 59);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(84, 34);
            GoBackBtn.TabIndex = 1;
            GoBackBtn.Text = "Back";
            GoBackBtn.UseVisualStyleBackColor = false;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 179, 71);
            LogoutBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.Location = new Point(11, 12);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(84, 34);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { listcolumnName, columnHeader1, columnHeader2, columnHeader3, listcolumncomment, columnTime });
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(12, 130);
            listViewOrders.MultiSelect = false;
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(597, 335);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged;
            // 
            // listcolumnName
            // 
            listcolumnName.Text = "Name";
            listcolumnName.Width = 113;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 113;
            // 
            // listcolumncomment
            // 
            listcolumncomment.Text = "Comment";
            listcolumncomment.Width = 147;
            // 
            // columnTime
            // 
            columnTime.Text = "Time";
            columnTime.Width = 80;
            // 
            // BillBtn
            // 
            BillBtn.BackColor = Color.FromArgb(138, 210, 176);
            BillBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BillBtn.Location = new Point(629, 196);
            BillBtn.Name = "BillBtn";
            BillBtn.Size = new Size(115, 48);
            BillBtn.TabIndex = 2;
            BillBtn.Text = "Bill";
            BillBtn.UseVisualStyleBackColor = false;
            BillBtn.Click += BillBtn_Click_1;
            // 
            // AddOrderbtn
            // 
            AddOrderbtn.BackColor = Color.FromArgb(138, 210, 176);
            AddOrderbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrderbtn.Location = new Point(629, 130);
            AddOrderbtn.Name = "AddOrderbtn";
            AddOrderbtn.Size = new Size(115, 48);
            AddOrderbtn.TabIndex = 3;
            AddOrderbtn.Text = "Add Order";
            AddOrderbtn.UseVisualStyleBackColor = false;
            AddOrderbtn.Click += AddOrderbtn_Click;
            // 
            // FreeTableBtn
            // 
            FreeTableBtn.BackColor = Color.FromArgb(255, 179, 71);
            FreeTableBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FreeTableBtn.Location = new Point(629, 326);
            FreeTableBtn.Name = "FreeTableBtn";
            FreeTableBtn.Size = new Size(115, 48);
            FreeTableBtn.TabIndex = 5;
            FreeTableBtn.Text = "FreeTable";
            FreeTableBtn.UseVisualStyleBackColor = false;
            FreeTableBtn.Click += FreeTableBtn_Click;
            // 
            // tableNumberlbl
            // 
            tableNumberlbl.AutoSize = true;
            tableNumberlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableNumberlbl.Location = new Point(307, 106);
            tableNumberlbl.Name = "tableNumberlbl";
            tableNumberlbl.Size = new Size(0, 21);
            tableNumberlbl.TabIndex = 6;
            // 
            // serveBtn
            // 
            serveBtn.BackColor = Color.FromArgb(138, 210, 176);
            serveBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            serveBtn.Location = new Point(629, 395);
            serveBtn.Name = "serveBtn";
            serveBtn.Size = new Size(115, 48);
            serveBtn.TabIndex = 7;
            serveBtn.Text = "Serve";
            serveBtn.UseVisualStyleBackColor = false;
            serveBtn.Click += serveBtn_Click;
            // 
            // ReserveTableBtn
            // 
            ReserveTableBtn.BackColor = Color.FromArgb(238, 164, 127);
            ReserveTableBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReserveTableBtn.Location = new Point(629, 258);
            ReserveTableBtn.Name = "ReserveTableBtn";
            ReserveTableBtn.Size = new Size(115, 48);
            ReserveTableBtn.TabIndex = 4;
            ReserveTableBtn.Text = "Reserve Table";
            ReserveTableBtn.UseVisualStyleBackColor = false;
            ReserveTableBtn.Click += ReserveTableBtn_Click;
            // 
            // TableOrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 508);
            Controls.Add(serveBtn);
            Controls.Add(tableNumberlbl);
            Controls.Add(FreeTableBtn);
            Controls.Add(ReserveTableBtn);
            Controls.Add(AddOrderbtn);
            Controls.Add(BillBtn);
            Controls.Add(listViewOrders);
            Controls.Add(panel1);
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
        private Button FreeTableBtn;
        private ColumnHeader listcolumnName;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label tableNumberlbl;
        private Button serveBtn;
        private Label namelabel;
        private Button button1;
        private ColumnHeader listcolumncomment;
        private ColumnHeader columnTime;
        private Button ReserveTableBtn;
    }
}