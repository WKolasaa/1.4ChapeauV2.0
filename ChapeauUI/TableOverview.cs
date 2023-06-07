using ChapeauModel;
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
        List<OrderItem>orderItems=new List<OrderItem>();
        public TableOverview(Employee employee)
        {
            this.employee = employee;

            tableService = new TableService();
            orderService = new OrderService();
            orderItemService=new OrderItemService();

            InitializeComponent();
            AssigneTableButtonHandler();

            GetTableStatus();
            GetOrderStatus();
            this.CenterToScreen();

            UserNamelbl.Text = $"{employee.Name}";
        }

        private void GetTableStatus()
        {
            tables = tableService.GetAllTables();
            Button[] buttons = { table1btn, table2btn, table3btn, table4btn, table5btn, table6btn, table7btn, table8btn, table9btn, table10btn };

            Color buttonColor = Color.Green;

            for (int i = 0; i < tables.Count && i < buttons.Length; i++)
            {
                if (tables[i].TableStatus == TableStatus.Occupied)
                {
                    buttonColor = Color.Yellow;
                }
                else if (tables[i].TableStatus == TableStatus.Reserved)
                {
                    buttonColor = Color.Red;
                }
                else
                {
                    buttonColor = Color.Green;
                }

                buttons[i].BackColor = buttonColor;



            }
        }

        private void GetOrderStatus()
        {
            Button[] orderStatusButtons = { orderstatus1, orderstatus2, orderstatus3, orderstatus4, orderstatus5, orderstatus6, orderstatus7, orderstatus8, orderstatus9, orderstatus10 };

            for (int i = 0; i < tables.Count && i < orderStatusButtons.Length; i++)
            {
                int tableNumber = tables[i].TableNumber;
                Color buttonColor = GetButtonColorForTable(tableNumber);
                orderStatusButtons[i].BackColor = buttonColor;
            }
        }

        private Color GetButtonColorForTable(int tableNumber)
        {
            List<OrderItem> orderItems = orderItemService.GetOrderStatusByTable(tableNumber);

            if (orderItems.Count > 0)
            {
                OrderStatus maxOrderStatus = orderItems.Max(item => item.Status);

                switch (maxOrderStatus)
                {
                    case OrderStatus.Ordered:
                        return Color.Aqua;
                    case OrderStatus.Preparing:
                        return Color.Orange;
                    case OrderStatus.Ready:
                        return Color.Green;
                   
                }
            }

            return Color.Gray;
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
            GetTableStatus();

        }
        private void TableButtonClick(Object sender, EventArgs e)
        {
            Button tabbleButton = (Button)sender;
            int tableNumber = int.Parse(tabbleButton.Tag.ToString());
            SelectedTable(tableNumber);
        }
        private void AssigneTableButtonHandler()
        {
            table1btn.Tag = 0;
            table2btn.Tag = 1;
            table3btn.Tag = 2;
            table4btn.Tag = 3;
            table5btn.Tag = 4;
            table6btn.Tag = 5;
            table7btn.Tag = 6;
            table8btn.Tag = 7;
            table9btn.Tag = 8;
            table10btn.Tag = 9;

            table1btn.Click += TableButtonClick;
            table2btn.Click += TableButtonClick;
            table3btn.Click += TableButtonClick;
            table4btn.Click += TableButtonClick;
            table5btn.Click += TableButtonClick;
            table6btn.Click += TableButtonClick;
            table7btn.Click += TableButtonClick;
            table8btn.Click += TableButtonClick;
            table9btn.Click += TableButtonClick;
            table10btn.Click += TableButtonClick;

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            GetTableStatus();
            GetOrderStatus();
        }
    }
}
