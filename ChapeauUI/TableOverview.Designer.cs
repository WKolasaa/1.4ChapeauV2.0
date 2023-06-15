namespace ChapeauUI
{
    partial class TableOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOverview));
            Logoutbtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UserNamelbl = new Label();
            panel1 = new Panel();
            Refreshbtn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tablepanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Logoutbtn
            // 
            Logoutbtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Logoutbtn.Location = new Point(15, 16);
            Logoutbtn.Margin = new Padding(3, 4, 3, 4);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(96, 45);
            Logoutbtn.TabIndex = 0;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = true;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(749, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 2;
            label1.Text = "User: ";
            // 
            // UserNamelbl
            // 
            UserNamelbl.AutoSize = true;
            UserNamelbl.Location = new Point(805, 57);
            UserNamelbl.Name = "UserNamelbl";
            UserNamelbl.Size = new Size(9, 20);
            UserNamelbl.TabIndex = 3;
            UserNamelbl.Text = "\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(Refreshbtn);
            panel1.Controls.Add(UserNamelbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logoutbtn);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 136);
            panel1.TabIndex = 0;
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.Transparent;
            Refreshbtn.Location = new Point(15, 69);
            Refreshbtn.Margin = new Padding(3, 4, 3, 4);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(96, 45);
            Refreshbtn.TabIndex = 4;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(320, 139);
            label2.Name = "label2";
            label2.Size = new Size(188, 29);
            label2.TabIndex = 1;
            label2.Text = "Table Overview";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 139);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tablepanel
            // 
            tablepanel.Location = new Point(-1, 202);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(898, 563);
            tablepanel.TabIndex = 23;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(909, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(tablepanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TableOverview";
            Text = "TableOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logoutbtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label UserNamelbl;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button Refreshbtn;
        private Panel tablepanel;
    }
}