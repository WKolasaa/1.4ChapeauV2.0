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
            lblLogin = new Label();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            passwordPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.GradientActiveCaption;
            LoginPanel.BorderStyle = BorderStyle.FixedSingle;
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Controls.Add(loginbtn);
            LoginPanel.Controls.Add(passwordPanel);
            LoginPanel.Controls.Add(UsernamePanel);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(lblLogin);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Margin = new Padding(3, 2, 3, 2);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(702, 339);
            LoginPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.Location = new Point(271, 268);
            loginbtn.Margin = new Padding(3, 2, 3, 2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(133, 45);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click_1;
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(235, 205);
            passwordPanel.Margin = new Padding(3, 2, 3, 2);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(219, 36);
            passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(17, 7);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 23);
            passwordTextBox.TabIndex = 0;
            // 
            // UsernamePanel
            // 
            UsernamePanel.Controls.Add(usernameTextBox);
            UsernamePanel.Location = new Point(235, 150);
            UsernamePanel.Margin = new Padding(3, 2, 3, 2);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(219, 36);
            UsernamePanel.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(16, 7);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(187, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 157);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 210);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(271, 93);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(117, 44);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(700, 338);
            Controls.Add(LoginPanel);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblLogin;
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