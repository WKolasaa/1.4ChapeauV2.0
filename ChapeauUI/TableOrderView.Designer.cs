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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrderView));
            panel1 = new Panel();
            Userlbl = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            GoBackBtn = new Button();
            LogoutBtn = new Button();
            listViewOrders = new ListView();
            BillBtn = new Button();
            AddOrderbtn = new Button();
            OccupyTableBtn = new Button();
            FreeTableBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Userlbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(GoBackBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 103);
            panel1.TabIndex = 0;
            // 
            // Userlbl
            // 
            Userlbl.AutoSize = true;
            Userlbl.Location = new Point(680, 44);
            Userlbl.Name = "Userlbl";
            Userlbl.Size = new Size(0, 15);
            Userlbl.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 44);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(264, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GoBackBtn
            // 
            GoBackBtn.Location = new Point(36, 59);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(75, 25);
            GoBackBtn.TabIndex = 1;
            GoBackBtn.Text = "Back";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(36, 16);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 26);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Location = new Point(12, 130);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(597, 335);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // BillBtn
            // 
            BillBtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BillBtn.Location = new Point(629, 201);
            BillBtn.Name = "BillBtn";
            BillBtn.Size = new Size(115, 40);
            BillBtn.TabIndex = 2;
            BillBtn.Text = "Bill";
            BillBtn.UseVisualStyleBackColor = true;
            // 
            // AddOrderbtn
            // 
            AddOrderbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrderbtn.Location = new Point(629, 144);
            AddOrderbtn.Name = "AddOrderbtn";
            AddOrderbtn.Size = new Size(115, 39);
            AddOrderbtn.TabIndex = 3;
            AddOrderbtn.Text = "Add Order";
            AddOrderbtn.UseVisualStyleBackColor = true;
            AddOrderbtn.Click += AddOrderbtn_Click;
            // 
            // OccupyTableBtn
            // 
            OccupyTableBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OccupyTableBtn.Location = new Point(629, 262);
            OccupyTableBtn.Name = "OccupyTableBtn";
            OccupyTableBtn.Size = new Size(115, 65);
            OccupyTableBtn.TabIndex = 4;
            OccupyTableBtn.Text = "Occupy Table";
            OccupyTableBtn.UseVisualStyleBackColor = true;
            OccupyTableBtn.Click += OccupyTableBtn_Click;
            // 
            // FreeTableBtn
            // 
            FreeTableBtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FreeTableBtn.Location = new Point(629, 348);
            FreeTableBtn.Name = "FreeTableBtn";
            FreeTableBtn.Size = new Size(115, 55);
            FreeTableBtn.TabIndex = 5;
            FreeTableBtn.Text = "FreeTable";
            FreeTableBtn.UseVisualStyleBackColor = true;
            FreeTableBtn.Click += FreeTableBtn_Click;
            // 
            // TableOrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(FreeTableBtn);
            Controls.Add(OccupyTableBtn);
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
        private Button OccupyTableBtn;
        private Button FreeTableBtn;
    }
}