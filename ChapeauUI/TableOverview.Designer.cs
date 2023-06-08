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
            table1btn = new Button();
            table2btn = new Button();
            table3btn = new Button();
            table4btn = new Button();
            table5btn = new Button();
            table6btn = new Button();
            table7btn = new Button();
            table8btn = new Button();
            table9btn = new Button();
            table10btn = new Button();
            orderstatus1 = new Button();
            orderstatus5 = new Button();
            orderstatus9 = new Button();
            orderstatus2 = new Button();
            orderstatus6 = new Button();
            orderstatus10 = new Button();
            orderstatus3 = new Button();
            orderstatus7 = new Button();
            orderstatus4 = new Button();
            orderstatus8 = new Button();
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
            pictureBox1.Size = new Size(248, 81);
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
            panel1.BackColor = SystemColors.GradientActiveCaption;
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
            Refreshbtn.Location = new Point(15, 69);
            Refreshbtn.Margin = new Padding(3, 4, 3, 4);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(96, 45);
            Refreshbtn.TabIndex = 4;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = true;
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
            pictureBox2.Location = new Point(635, 139);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // table1btn
            // 
            table1btn.Location = new Point(29, 260);
            table1btn.Margin = new Padding(3, 4, 3, 4);
            table1btn.Name = "table1btn";
            table1btn.Size = new Size(117, 119);
            table1btn.TabIndex = 3;
            table1btn.Text = "Table1";
            table1btn.UseVisualStyleBackColor = true;
            // 
            // table2btn
            // 
            table2btn.Location = new Point(286, 260);
            table2btn.Margin = new Padding(3, 4, 3, 4);
            table2btn.Name = "table2btn";
            table2btn.Size = new Size(117, 119);
            table2btn.TabIndex = 4;
            table2btn.Text = "Table2";
            table2btn.UseVisualStyleBackColor = true;
            // 
            // table3btn
            // 
            table3btn.Location = new Point(507, 260);
            table3btn.Margin = new Padding(3, 4, 3, 4);
            table3btn.Name = "table3btn";
            table3btn.Size = new Size(117, 119);
            table3btn.TabIndex = 5;
            table3btn.Text = "Table3";
            table3btn.UseVisualStyleBackColor = true;
            // 
            // table4btn
            // 
            table4btn.Location = new Point(731, 260);
            table4btn.Margin = new Padding(3, 4, 3, 4);
            table4btn.Name = "table4btn";
            table4btn.Size = new Size(117, 119);
            table4btn.TabIndex = 6;
            table4btn.Text = "Table4";
            table4btn.UseVisualStyleBackColor = true;
            // 
            // table5btn
            // 
            table5btn.Location = new Point(27, 440);
            table5btn.Margin = new Padding(3, 4, 3, 4);
            table5btn.Name = "table5btn";
            table5btn.Size = new Size(117, 119);
            table5btn.TabIndex = 7;
            table5btn.Text = "Table5";
            table5btn.UseVisualStyleBackColor = true;
            // 
            // table6btn
            // 
            table6btn.Location = new Point(286, 440);
            table6btn.Margin = new Padding(3, 4, 3, 4);
            table6btn.Name = "table6btn";
            table6btn.Size = new Size(117, 119);
            table6btn.TabIndex = 8;
            table6btn.Text = "Table6";
            table6btn.UseVisualStyleBackColor = true;
            // 
            // table7btn
            // 
            table7btn.Location = new Point(507, 452);
            table7btn.Margin = new Padding(3, 4, 3, 4);
            table7btn.Name = "table7btn";
            table7btn.Size = new Size(117, 119);
            table7btn.TabIndex = 9;
            table7btn.Text = "Table7";
            table7btn.UseVisualStyleBackColor = true;
            // 
            // table8btn
            // 
            table8btn.Location = new Point(731, 452);
            table8btn.Margin = new Padding(3, 4, 3, 4);
            table8btn.Name = "table8btn";
            table8btn.Size = new Size(117, 119);
            table8btn.TabIndex = 10;
            table8btn.Text = "Table8";
            table8btn.UseVisualStyleBackColor = true;
            // 
            // table9btn
            // 
            table9btn.Location = new Point(27, 616);
            table9btn.Margin = new Padding(3, 4, 3, 4);
            table9btn.Name = "table9btn";
            table9btn.Size = new Size(117, 119);
            table9btn.TabIndex = 11;
            table9btn.Text = "Table9";
            table9btn.UseVisualStyleBackColor = true;
            // 
            // table10btn
            // 
            table10btn.Location = new Point(286, 616);
            table10btn.Margin = new Padding(3, 4, 3, 4);
            table10btn.Name = "table10btn";
            table10btn.Size = new Size(117, 119);
            table10btn.TabIndex = 12;
            table10btn.Text = "Table10";
            table10btn.UseVisualStyleBackColor = true;
            // 
            // orderstatus1
            // 
            orderstatus1.Location = new Point(152, 260);
            orderstatus1.Margin = new Padding(3, 4, 3, 4);
            orderstatus1.Name = "orderstatus1";
            orderstatus1.Size = new Size(29, 31);
            orderstatus1.TabIndex = 13;
            orderstatus1.UseVisualStyleBackColor = true;
            // 
            // orderstatus5
            // 
            orderstatus5.Location = new Point(152, 440);
            orderstatus5.Margin = new Padding(3, 4, 3, 4);
            orderstatus5.Name = "orderstatus5";
            orderstatus5.Size = new Size(29, 31);
            orderstatus5.TabIndex = 14;
            orderstatus5.UseVisualStyleBackColor = true;
            // 
            // orderstatus9
            // 
            orderstatus9.Location = new Point(152, 616);
            orderstatus9.Margin = new Padding(3, 4, 3, 4);
            orderstatus9.Name = "orderstatus9";
            orderstatus9.Size = new Size(29, 31);
            orderstatus9.TabIndex = 15;
            orderstatus9.UseVisualStyleBackColor = true;
            // 
            // orderstatus2
            // 
            orderstatus2.Location = new Point(409, 260);
            orderstatus2.Margin = new Padding(3, 4, 3, 4);
            orderstatus2.Name = "orderstatus2";
            orderstatus2.Size = new Size(29, 31);
            orderstatus2.TabIndex = 16;
            orderstatus2.UseVisualStyleBackColor = true;
            // 
            // orderstatus6
            // 
            orderstatus6.Location = new Point(409, 440);
            orderstatus6.Margin = new Padding(3, 4, 3, 4);
            orderstatus6.Name = "orderstatus6";
            orderstatus6.Size = new Size(29, 31);
            orderstatus6.TabIndex = 17;
            orderstatus6.UseVisualStyleBackColor = true;
            // 
            // orderstatus10
            // 
            orderstatus10.Location = new Point(409, 616);
            orderstatus10.Margin = new Padding(3, 4, 3, 4);
            orderstatus10.Name = "orderstatus10";
            orderstatus10.Size = new Size(29, 31);
            orderstatus10.TabIndex = 18;
            orderstatus10.UseVisualStyleBackColor = true;
            // 
            // orderstatus3
            // 
            orderstatus3.Location = new Point(631, 260);
            orderstatus3.Margin = new Padding(3, 4, 3, 4);
            orderstatus3.Name = "orderstatus3";
            orderstatus3.Size = new Size(29, 31);
            orderstatus3.TabIndex = 19;
            orderstatus3.UseVisualStyleBackColor = true;
            // 
            // orderstatus7
            // 
            orderstatus7.Location = new Point(631, 452);
            orderstatus7.Margin = new Padding(3, 4, 3, 4);
            orderstatus7.Name = "orderstatus7";
            orderstatus7.Size = new Size(29, 31);
            orderstatus7.TabIndex = 20;
            orderstatus7.UseVisualStyleBackColor = true;
            // 
            // orderstatus4
            // 
            orderstatus4.Location = new Point(855, 260);
            orderstatus4.Margin = new Padding(3, 4, 3, 4);
            orderstatus4.Name = "orderstatus4";
            orderstatus4.Size = new Size(29, 31);
            orderstatus4.TabIndex = 21;
            orderstatus4.UseVisualStyleBackColor = true;
            // 
            // orderstatus8
            // 
            orderstatus8.Location = new Point(855, 452);
            orderstatus8.Margin = new Padding(3, 4, 3, 4);
            orderstatus8.Name = "orderstatus8";
            orderstatus8.Size = new Size(29, 31);
            orderstatus8.TabIndex = 22;
            orderstatus8.UseVisualStyleBackColor = true;
            // 
            // tablepanel
            // 
            tablepanel.Location = new Point(29, 184);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(763, 338);
            tablepanel.TabIndex = 23;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(909, 777);
            Controls.Add(tablepanel);
            Controls.Add(orderstatus8);
            Controls.Add(orderstatus4);
            Controls.Add(orderstatus7);
            Controls.Add(orderstatus3);
            Controls.Add(orderstatus10);
            Controls.Add(orderstatus6);
            Controls.Add(orderstatus2);
            Controls.Add(orderstatus9);
            Controls.Add(orderstatus5);
            Controls.Add(orderstatus1);
            Controls.Add(table10btn);
            Controls.Add(table9btn);
            Controls.Add(table8btn);
            Controls.Add(table7btn);
            Controls.Add(table6btn);
            Controls.Add(table5btn);
            Controls.Add(table4btn);
            Controls.Add(table3btn);
            Controls.Add(table2btn);
            Controls.Add(table1btn);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
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
        private Button table1btn;
        private Button table2btn;
        private Button table3btn;
        private Button table4btn;
        private Button table5btn;
        private Button table6btn;
        private Button table7btn;
        private Button table8btn;
        private Button table9btn;
        private Button table10btn;
        private Button Refreshbtn;
        private Button orderstatus1;
        private Button orderstatus5;
        private Button orderstatus9;
        private Button orderstatus2;
        private Button orderstatus6;
        private Button orderstatus10;
        private Button orderstatus3;
        private Button orderstatus7;
        private Button orderstatus4;
        private Button orderstatus8;
        private Panel tablepanel;
    }
}