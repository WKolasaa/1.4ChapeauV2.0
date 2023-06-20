namespace ChapeauUI
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            LoginPanel = new Panel();
            pictureBox1 = new PictureBox();
            loginbtn = new Button();
            passwordPanel = new Panel();
            passwordTextBox = new TextBox();
            UsernamePanel = new Panel();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            passwordPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.Control;
            LoginPanel.BorderStyle = BorderStyle.FixedSingle;
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Controls.Add(loginbtn);
            LoginPanel.Controls.Add(passwordPanel);
            LoginPanel.Controls.Add(UsernamePanel);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(802, 451);
            LoginPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(138, 210, 176);
            loginbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.ForeColor = SystemColors.ControlText;
            loginbtn.Location = new Point(296, 322);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(152, 60);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click_1;
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(268, 237);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(250, 48);
            passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(19, 9);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(212, 27);
            passwordTextBox.TabIndex = 0;
            // 
            // UsernamePanel
            // 
            UsernamePanel.Controls.Add(usernameTextBox);
            UsernamePanel.Location = new Point(268, 164);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(250, 48);
            UsernamePanel.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(18, 9);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(213, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 173);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 244);
            label1.Name = "label1";
            label1.Size = new Size(124, 29);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 451);
            Controls.Add(LoginPanel);
            MaximizeBox = false;
            Name = "LoginScreen";
            Text = "Chapeau";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Panel UsernamePanel;
        private Label label2;
        private Label label1;
        private Panel passwordPanel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button loginbtn;
        private PictureBox pictureBox1;
    }
}