﻿using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChapeauModel.Order;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        Employee employee;
        TableService tableService;
        OrderService orderService;
        List<Table> tables = new List<Table>();
        OrderItemService orderItemService;
        List<OrderItem> orderItems = new List<OrderItem>();
        Dictionary<Button, Table> buttonDictionary = new Dictionary<Button, Table>();
        public TableOverview(Employee employee)
        {
            this.employee = employee;
           

            tableService = new TableService();
            orderService = new OrderService();
            orderItemService = new OrderItemService();
            tables = tableService.GetAllTables();

            InitializeComponent();
            
            AssigneTableButtonHandler();

            this.CenterToScreen();

            UserNamelbl.Text = $"{employee.Name}";
           
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.ShowDialog();
                this.Close();
            }
        }


        private void SelectedTable(int tableNumber)
        {
            this.Hide();
            TableOrderView tableOrderView = new TableOrderView(employee, tables[tableNumber]);
            tableOrderView.ShowDialog();
            this.Show();
            AssigneTableButtonHandler();
          

        }
        private void TableButtonClick(object sender, EventArgs e)
        {
            Button tableButton = (Button)sender;
            int tableNumber = int.Parse(tableButton.Tag.ToString());
            SelectedTable(tableNumber);
        }

        private void AssigneTableButtonHandler()
        {
            // TODO: improve
            /* List<Table> tables = tableService.GetAllTables();

             foreach (Table table in tables)
             {
                 // create button, hint dictionary
                 // create eventhandler
             }*/
            tables = tableService.GetAllTables();
            Dictionary<Button, Table> tableButtonDictionary = new Dictionary<Button, Table>();

            for (int i = 0; i < tables.Count; i++)
            {
                Button tableButton = new Button();
                tableButton.Text = "Table " + (i + 1);
                tableButton.Location = new Point(10, 10 + i * 30);
                tableButton.Tag = i;
                tableButton.Click += TableButtonClick;
                tableButtonDictionary.Add(tableButton, tables[i]);

                // Add the button to a container
                tablepanel.Controls.Add(tableButton);
                switch (tables[i].TableStatus)
                {
                    case TableStatus.Occupied:
                        tableButton.BackColor = Color.Yellow;
                        break;
                    case TableStatus.Free:
                        tableButton.BackColor = Color.Green;
                        break;
                    case TableStatus.Reserved:
                        tableButton.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            AssigneTableButtonHandler();
        }
    }
}
