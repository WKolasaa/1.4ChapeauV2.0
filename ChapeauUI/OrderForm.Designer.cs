namespace OrderTable
{
    partial class OrderForm
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
            label3 = new Label();
            orderListView = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btAdd = new Button();
            btUpdate = new Button();
            btRemove = new Button();
            pnComment = new Panel();
            btSubmitComment = new Button();
            txtComment = new TextBox();
            label2 = new Label();
            btFinish = new Button();
            pnComment.SuspendLayout();
            SuspendLayout();
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.DarkSeaGreen;
            btnLunch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLunch.ForeColor = Color.Black;
            btnLunch.Location = new Point(30, 43);
            btnLunch.Margin = new Padding(0);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(151, 67);
            btnLunch.TabIndex = 0;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.DarkSeaGreen;
            btnDinner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDinner.Location = new Point(274, 43);
            btnDinner.Margin = new Padding(3, 2, 3, 2);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(151, 67);
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
            btnDrinks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDrinks.Location = new Point(529, 43);
            btnDrinks.Margin = new Padding(3, 2, 3, 2);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(151, 67);
            btnDrinks.TabIndex = 2;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 432);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 9;
            label3.Text = "Order";
            // 
            // orderListView
            // 
            orderListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            orderListView.FullRowSelect = true;
            orderListView.Location = new Point(30, 455);
            orderListView.Margin = new Padding(3, 2, 3, 2);
            orderListView.MultiSelect = false;
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(650, 128);
            orderListView.TabIndex = 11;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Details;
            orderListView.SelectedIndexChanged += orderListView_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Comment";
            columnHeader5.Width = 150;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(30, 154);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(650, 269);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Type";
            columnHeader6.Width = 100;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.DarkSeaGreen;
            btAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.Location = new Point(30, 606);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(151, 37);
            btAdd.TabIndex = 14;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.Orange;
            btUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.Location = new Point(274, 606);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(151, 37);
            btUpdate.TabIndex = 15;
            btUpdate.Text = "Comment";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Salmon;
            btRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btRemove.Location = new Point(529, 606);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(151, 37);
            btRemove.TabIndex = 16;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            btRemove.Click += btRemove_Click;
            // 
            // pnComment
            // 
            pnComment.Controls.Add(btSubmitComment);
            pnComment.Controls.Add(txtComment);
            pnComment.Controls.Add(label2);
            pnComment.Location = new Point(30, 267);
            pnComment.Name = "pnComment";
            pnComment.Size = new Size(650, 316);
            pnComment.TabIndex = 17;
            // 
            // btSubmitComment
            // 
            btSubmitComment.BackColor = Color.DarkSeaGreen;
            btSubmitComment.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btSubmitComment.Location = new Point(214, 230);
            btSubmitComment.Name = "btSubmitComment";
            btSubmitComment.Size = new Size(206, 43);
            btSubmitComment.TabIndex = 2;
            btSubmitComment.Text = "Submit";
            btSubmitComment.UseVisualStyleBackColor = false;
            btSubmitComment.Click += btSubmitComment_Click;
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtComment.Location = new Point(76, 147);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(505, 43);
            txtComment.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(164, 31);
            label2.Name = "label2";
            label2.Size = new Size(351, 54);
            label2.TabIndex = 0;
            label2.Text = "Enter a Comment";
            // 
            // btFinish
            // 
            btFinish.BackColor = Color.DarkSeaGreen;
            btFinish.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btFinish.Location = new Point(225, 689);
            btFinish.Name = "btFinish";
            btFinish.Size = new Size(242, 47);
            btFinish.TabIndex = 18;
            btFinish.Text = "Place Order";
            btFinish.UseVisualStyleBackColor = false;
            btFinish.Click += btFinish_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 748);
            Controls.Add(btFinish);
            Controls.Add(pnComment);
            Controls.Add(btRemove);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(listView1);
            Controls.Add(orderListView);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnComment.ResumeLayout(false);
            pnComment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLunch;
        private Button btnDinner;
        private Button btnDrinks;
        private Label label1;
        private Label label3;
        private ListView orderListView;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btAdd;
        private Button btUpdate;
        private Button btRemove;
        private Panel pnComment;
        private Button btSubmitComment;
        private TextBox txtComment;
        private Label label2;
        private Button btFinish;
    }
}