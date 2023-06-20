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
            Logoutbtn.Location = new Point(15, 16);
            Logoutbtn.Margin = new Padding(3, 4, 3, 4);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(96, 45);
            Logoutbtn.TabIndex = 0;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Refreshbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logoutbtn);
            panel1.Location = new Point(-1, 0);
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
            namelabel.Image = Properties.Resources.Screenshot_2023_06_19_234218_removebg_preview;
            namelabel.Location = new Point(772, 39);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(0, 20);
            namelabel.TabIndex = 6;
            namelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 179, 71);
            button1.Enabled = false;
            button1.Location = new Point(753, 23);
            button1.Name = "button1";
            button1.Size = new Size(119, 53);
            button1.TabIndex = 5;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.FromArgb(138, 210, 176);
            Refreshbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Refreshbtn.Location = new Point(15, 69);
            Refreshbtn.Margin = new Padding(3, 4, 3, 4);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(96, 45);
            Refreshbtn.TabIndex = 4;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // tablepanel
            // 
            tablepanel.Location = new Point(-1, 202);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(898, 563);
            tablepanel.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(286, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(909, 777);
            Controls.Add(pictureBox2);
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
        }

        #endregion

        private Button Logoutbtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Refreshbtn;
        private Panel tablepanel;
        private Label namelabel;
        private Button button1;
        private PictureBox pictureBox2;
    }
}