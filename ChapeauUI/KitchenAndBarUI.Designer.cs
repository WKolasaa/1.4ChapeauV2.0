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
            this.orderesListView = new System.Windows.Forms.ListView();
            this.listViewSelectedItem = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMenuBar = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.panelHeader3 = new System.Windows.Forms.Panel();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.btnInPreparation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.panelHeader3.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderesListView
            // 
            this.orderesListView.Location = new System.Drawing.Point(39, 204);
            this.orderesListView.Name = "orderesListView";
            this.orderesListView.Size = new System.Drawing.Size(562, 336);
            this.orderesListView.TabIndex = 1;
            this.orderesListView.UseCompatibleStateImageBehavior = false;
            // 
            // listViewSelectedItem
            // 
            this.listViewSelectedItem.Location = new System.Drawing.Point(600, 367);
            this.listViewSelectedItem.Name = "listViewSelectedItem";
            this.listViewSelectedItem.Size = new System.Drawing.Size(484, 103);
            this.listViewSelectedItem.TabIndex = 2;
            this.listViewSelectedItem.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.labelMenuBar);
            this.panelHeader.Location = new System.Drawing.Point(39, 75);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1045, 70);
            this.panelHeader.TabIndex = 4;
            // 
            // labelMenuBar
            // 
            this.labelMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenuBar.AutoSize = true;
            this.labelMenuBar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMenuBar.Location = new System.Drawing.Point(426, 14);
            this.labelMenuBar.Name = "labelMenuBar";
            this.labelMenuBar.Size = new System.Drawing.Size(214, 41);
            this.labelMenuBar.TabIndex = 0;
            this.labelMenuBar.Text = "Kitchen Orders";
            this.labelMenuBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(1002, 35);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 34);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Mara";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader2.Controls.Add(this.labelInfo1);
            this.panelHeader2.Location = new System.Drawing.Point(600, 204);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(484, 50);
            this.panelHeader2.TabIndex = 6;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(189, 18);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(116, 15);
            this.labelInfo1.TabIndex = 0;
            this.labelInfo1.Text = "Change Order Status";
            // 
            // panelHeader3
            // 
            this.panelHeader3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader3.Controls.Add(this.labelInfo2);
            this.panelHeader3.Location = new System.Drawing.Point(600, 317);
            this.panelHeader3.Name = "panelHeader3";
            this.panelHeader3.Size = new System.Drawing.Size(484, 50);
            this.panelHeader3.TabIndex = 7;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(205, 18);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(100, 15);
            this.labelInfo2.TabIndex = 0;
            this.labelInfo2.Text = "View Order Status";
            // 
            // btnInPreparation
            // 
            this.btnInPreparation.Location = new System.Drawing.Point(607, 272);
            this.btnInPreparation.Name = "btnInPreparation";
            this.btnInPreparation.Size = new System.Drawing.Size(140, 29);
            this.btnInPreparation.TabIndex = 8;
            this.btnInPreparation.Text = "In Preparation";
            this.btnInPreparation.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(779, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Preapared";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(944, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Served";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // KitchenAndBarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1117, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInPreparation);
            this.Controls.Add(this.panelHeader3);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewSelectedItem);
            this.Controls.Add(this.orderesListView);
            this.Name = "KitchenAndBarUI";
            this.Text = "Kitchen ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.panelHeader3.ResumeLayout(false);
            this.panelHeader3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}