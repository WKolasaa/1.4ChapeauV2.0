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
            panel1 = new Panel();
            namelabel = new Label();
            button1 = new Button();
            Refreshbtn = new Button();
            tablepanel = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.FromArgb(255, 179, 71);
            Logoutbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Logoutbtn.Location = new Point(13, 12);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(84, 34);
            Logoutbtn.TabIndex = 0;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(335, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Refreshbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logoutbtn);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 102);
            panel1.TabIndex = 0;
            // 
            // namelabel
            // 
            namelabel.AutoEllipsis = true;
            namelabel.AutoSize = true;
            namelabel.BackColor = Color.FromArgb(255, 179, 71);
            namelabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            namelabel.Image = Properties.Resources.Screenshot_2023_06_19_234218_removebg_preview;
            namelabel.Location = new Point(772, 40);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(0, 17);
            namelabel.TabIndex = 6;
            namelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 179, 71);
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(762, 29);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 40);
            button1.TabIndex = 5;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.FromArgb(138, 210, 176);
            Refreshbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Refreshbtn.Location = new Point(13, 52);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(84, 34);
            Refreshbtn.TabIndex = 4;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // tablepanel
            // 
            tablepanel.Location = new Point(-1, 152);
            tablepanel.Margin = new Padding(3, 2, 3, 2);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(905, 515);
            tablepanel.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(334, 100);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 678);
            Controls.Add(pictureBox2);
            Controls.Add(tablepanel);
            Controls.Add(panel1);
            Name = "TableOverview";
            Text = "TableOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Logoutbtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Refreshbtn;
        private Panel tablepanel;
        private Button button1;
        private PictureBox pictureBox2;
        private Label namelabel;
    }
}