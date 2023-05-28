namespace OrderTable
{
    partial class Form1
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
            btnLunch = new Button();
            btnDinner = new Button();
            btnDrinks = new Button();
            label1 = new Label();
            label2 = new Label();
            listViewStartersLunch = new ListView();
            SuspendLayout();
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.Transparent;
            btnLunch.ForeColor = SystemColors.ActiveCaptionText;
            btnLunch.Location = new Point(12, 88);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(147, 46);
            btnLunch.TabIndex = 0;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnDinner
            // 
            btnDinner.Location = new Point(222, 88);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(147, 46);
            btnDinner.TabIndex = 1;
            btnDinner.Text = "Dinner";
            btnDinner.UseVisualStyleBackColor = true;
            // 
            // btnDrinks
            // 
            btnDrinks.Location = new Point(428, 88);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(147, 46);
            btnDrinks.TabIndex = 2;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 171);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Starters";
            // 
            // listViewStartersLunch
            // 
            listViewStartersLunch.Location = new Point(12, 205);
            listViewStartersLunch.Name = "listViewStartersLunch";
            listViewStartersLunch.Size = new Size(563, 134);
            listViewStartersLunch.TabIndex = 4;
            listViewStartersLunch.UseCompatibleStateImageBehavior = false;
            listViewStartersLunch.View = View.Details;
            listViewStartersLunch.SelectedIndexChanged += listViewStartersLunch_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 713);
            Controls.Add(listViewStartersLunch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLunch;
        private Button btnDinner;
        private Button btnDrinks;
        private Label label1;
        private Label label2;
        private ListView listViewStartersLunch;
    }
}