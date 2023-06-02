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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLunch = new Button();
            btnDinner = new Button();
            btnDrinks = new Button();
            label1 = new Label();
            label2 = new Label();
            listViewStarters = new ListView();
            Main = new Label();
            listViewMain = new ListView();
            label4 = new Label();
            listViewDessert = new ListView();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(components);
            guna2ResizeForm2 = new Guna.UI2.WinForms.Guna2ResizeForm(components);
            guna2AnimateWindow3 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label3 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            orderListView = new ListView();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            AddOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.DarkSeaGreen;
            btnLunch.ForeColor = Color.Black;
            btnLunch.Location = new Point(31, 88);
            btnLunch.Margin = new Padding(0);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(147, 59);
            btnLunch.TabIndex = 0;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.DarkSeaGreen;
            btnDinner.Location = new Point(224, 88);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(147, 59);
            btnDinner.TabIndex = 1;
            btnDinner.Text = "Dinner";
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += btnDinner_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.DarkSeaGreen;
            btnDrinks.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            btnDrinks.FlatAppearance.BorderSize = 0;
            btnDrinks.Location = new Point(415, 88);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(147, 59);
            btnDrinks.TabIndex = 2;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
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
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 160);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 3;
            label2.Text = "Starters";
            // 
            // listViewStarters
            // 
            listViewStarters.Location = new Point(12, 194);
            listViewStarters.Name = "listViewStarters";
            listViewStarters.Size = new Size(563, 134);
            listViewStarters.TabIndex = 4;
            listViewStarters.UseCompatibleStateImageBehavior = false;
            listViewStarters.View = View.Details;
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Main.Location = new Point(255, 352);
            Main.Name = "Main";
            Main.Size = new Size(69, 31);
            Main.TabIndex = 5;
            Main.Text = "Main";
            // 
            // listViewMain
            // 
            listViewMain.Location = new Point(12, 386);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(563, 134);
            listViewMain.TabIndex = 6;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = View.Details;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(242, 536);
            label4.Name = "label4";
            label4.Size = new Size(94, 31);
            label4.TabIndex = 7;
            label4.Text = "Dessert";
            // 
            // listViewDessert
            // 
            listViewDessert.Location = new Point(12, 570);
            listViewDessert.Name = "listViewDessert";
            listViewDessert.Size = new Size(563, 134);
            listViewDessert.TabIndex = 8;
            listViewDessert.UseCompatibleStateImageBehavior = false;
            listViewDessert.View = View.Details;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = btnLunch;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = btnDinner;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 10;
            guna2Elipse3.TargetControl = btnDrinks;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 735);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 9;
            label3.Text = "Order";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(0, 727);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(595, 12);
            guna2Separator1.TabIndex = 10;
            // 
            // orderListView
            // 
            orderListView.Location = new Point(12, 766);
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(563, 170);
            orderListView.TabIndex = 11;
            orderListView.UseCompatibleStateImageBehavior = false;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 10;
            guna2Elipse4.TargetControl = orderListView;
            // 
            // AddOrderBtn
            // 
            AddOrderBtn.CustomizableEdges = customizableEdges3;
            AddOrderBtn.DisabledState.BorderColor = Color.DarkGray;
            AddOrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddOrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddOrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddOrderBtn.FillColor = Color.DarkOrange;
            AddOrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrderBtn.ForeColor = Color.Black;
            AddOrderBtn.Location = new Point(379, 945);
            AddOrderBtn.Name = "AddOrderBtn";
            AddOrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddOrderBtn.Size = new Size(196, 41);
            AddOrderBtn.TabIndex = 12;
            AddOrderBtn.Text = "Add";
            AddOrderBtn.Click += AddOrderBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 998);
            Controls.Add(AddOrderBtn);
            Controls.Add(orderListView);
            Controls.Add(guna2Separator1);
            Controls.Add(label3);
            Controls.Add(listViewDessert);
            Controls.Add(label4);
            Controls.Add(listViewMain);
            Controls.Add(Main);
            Controls.Add(listViewStarters);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ListView listViewStarters;
        private Label Main;
        private ListView listViewMain;
        private Label label4;
        private ListView listViewDessert;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private ListView orderListView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button AddOrderBtn;
    }
}