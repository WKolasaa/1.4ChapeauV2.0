namespace ChapeauUI
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernametxt = new TextBox();
            passwordtext = new TextBox();
            Loginbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 164);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 106);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 152);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(349, 109);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(125, 27);
            usernametxt.TabIndex = 3;
            // 
            // passwordtext
            // 
            passwordtext.Location = new Point(350, 149);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(125, 27);
            passwordtext.TabIndex = 4;
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(349, 222);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(94, 29);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loginbtn);
            Controls.Add(passwordtext);
            Controls.Add(usernametxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernametxt;
        private TextBox passwordtext;
        private Button Loginbtn;
    }
}