namespace ChapeauUI
{
    partial class KitchenAndBarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenAndBarUI));
            orderesListView = new ListView();
            TableNumber = new ColumnHeader();
            ItemName = new ColumnHeader();
            Quantity = new ColumnHeader();
            Comments = new ColumnHeader();
            listViewSelectedItem = new ListView();
            ItemID = new ColumnHeader();
            OrderStatus = new ColumnHeader();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            labelMenuBar = new Label();
            btnLogout = new Button();
            panelHeader2 = new Panel();
            labelInfo1 = new Label();
            panelHeader3 = new Panel();
            labelInfo2 = new Label();
            btnInPreparation = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            panelHeader2.SuspendLayout();
            panelHeader3.SuspendLayout();
            SuspendLayout();
            // 
            // orderesListView
            // 
            orderesListView.Columns.AddRange(new ColumnHeader[] { TableNumber, ItemName, Quantity, Comments });
            orderesListView.FullRowSelect = true;
            orderesListView.Location = new Point(39, 204);
            orderesListView.Name = "orderesListView";
            orderesListView.Size = new Size(562, 336);
            orderesListView.TabIndex = 1;
            orderesListView.UseCompatibleStateImageBehavior = false;
            orderesListView.View = View.Details;
            orderesListView.ItemSelectionChanged += orderesListView_ItemSelectionChanged;
            orderesListView.SelectedIndexChanged += orderesListView_SelectedIndexChanged;
            // 
            // TableNumber
            // 
            TableNumber.Text = "TableNumber";
            TableNumber.Width = 140;
            // 
            // ItemName
            // 
            ItemName.Text = "Name";
            ItemName.Width = 140;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 140;
            // 
            // Comments
            // 
            Comments.Text = "Comments";
            Comments.Width = 140;
            // 
            // listViewSelectedItem
            // 
            listViewSelectedItem.Columns.AddRange(new ColumnHeader[] { ItemID, OrderStatus });
            listViewSelectedItem.FullRowSelect = true;
            listViewSelectedItem.Location = new Point(600, 367);
            listViewSelectedItem.Name = "listViewSelectedItem";
            listViewSelectedItem.Size = new Size(484, 173);
            listViewSelectedItem.TabIndex = 2;
            listViewSelectedItem.UseCompatibleStateImageBehavior = false;
            listViewSelectedItem.View = View.Details;
            // 
            // ItemID
            // 
            ItemID.DisplayIndex = 1;
            ItemID.Text = "Selected Order ID";
            ItemID.Width = 242;
            // 
            // OrderStatus
            // 
            OrderStatus.DisplayIndex = 0;
            OrderStatus.Text = "Order Status";
            OrderStatus.TextAlign = HorizontalAlignment.Center;
            OrderStatus.Width = 242;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 128, 0);
            panelHeader.Controls.Add(labelMenuBar);
            panelHeader.Location = new Point(39, 75);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1045, 70);
            panelHeader.TabIndex = 4;
            // 
            // labelMenuBar
            // 
            labelMenuBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelMenuBar.AutoSize = true;
            labelMenuBar.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenuBar.Location = new Point(426, 14);
            labelMenuBar.Name = "labelMenuBar";
            labelMenuBar.Size = new Size(214, 41);
            labelMenuBar.TabIndex = 0;
            labelMenuBar.Text = "Kitchen Orders";
            labelMenuBar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 128, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(1002, 35);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(82, 34);
            btnLogout.TabIndex = 5;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelHeader2
            // 
            panelHeader2.BackColor = Color.FromArgb(255, 128, 0);
            panelHeader2.Controls.Add(labelInfo1);
            panelHeader2.Location = new Point(600, 204);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Size = new Size(484, 50);
            panelHeader2.TabIndex = 6;
            // 
            // labelInfo1
            // 
            labelInfo1.AutoSize = true;
            labelInfo1.Location = new Point(189, 18);
            labelInfo1.Name = "labelInfo1";
            labelInfo1.Size = new Size(116, 15);
            labelInfo1.TabIndex = 0;
            labelInfo1.Text = "Change Order Status";
            // 
            // panelHeader3
            // 
            panelHeader3.BackColor = Color.FromArgb(255, 128, 0);
            panelHeader3.Controls.Add(labelInfo2);
            panelHeader3.Location = new Point(600, 317);
            panelHeader3.Name = "panelHeader3";
            panelHeader3.Size = new Size(484, 50);
            panelHeader3.TabIndex = 7;
            // 
            // labelInfo2
            // 
            labelInfo2.AutoSize = true;
            labelInfo2.Location = new Point(205, 18);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(100, 15);
            labelInfo2.TabIndex = 0;
            labelInfo2.Text = "View Order Status";
            // 
            // btnInPreparation
            // 
            btnInPreparation.Enabled = false;
            btnInPreparation.Location = new Point(607, 272);
            btnInPreparation.Name = "btnInPreparation";
            btnInPreparation.Size = new Size(140, 29);
            btnInPreparation.TabIndex = 8;
            btnInPreparation.Text = "In Preparation";
            btnInPreparation.UseVisualStyleBackColor = true;
            btnInPreparation.Click += btnInPreparation_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Enabled = false;
            button1.Location = new Point(779, 272);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 9;
            button1.Text = "Preapared";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Enabled = false;
            button2.Location = new Point(944, 272);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 10;
            button2.Text = "Served";
            button2.UseVisualStyleBackColor = false;
            // 
            // KitchenAndBarUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1117, 592);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnInPreparation);
            Controls.Add(panelHeader3);
            Controls.Add(panelHeader2);
            Controls.Add(btnLogout);
            Controls.Add(panelHeader);
            Controls.Add(pictureBox1);
            Controls.Add(listViewSelectedItem);
            Controls.Add(orderesListView);
            Name = "KitchenAndBarUI";
            Text = "Kitchen ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            panelHeader3.ResumeLayout(false);
            panelHeader3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView orderesListView;
        private ListView listViewSelectedItem;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Label labelMenuBar;
        private Button btnLogout;
        private Panel panelHeader2;
        private Label labelInfo1;
        private Panel panelHeader3;
        private Label labelInfo2;
        private Button btnInPreparation;
        private Button button1;
        private Button button2;
        private ColumnHeader TableNumber;
        private ColumnHeader ItemName;
        private ColumnHeader Quantity;
        private ColumnHeader Comments;
        private ColumnHeader ItemID;
        private ColumnHeader OrderStatus;
    }
}