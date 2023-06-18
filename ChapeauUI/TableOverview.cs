using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        List<Table> tables;
        Dictionary<Button, Table> buttonDictionary;
        Table table;
        OrderItemService orderItemService;


        public TableOverview(Employee employee)
        {
            try
            {
                this.employee = employee;

                tables = new List<Table>();
                tableService = new TableService();
                buttonDictionary = new Dictionary<Button, Table>();
                orderItemService = new OrderItemService();

                table = new Table();

                InitializeComponent();

                AssigneTableButtonHandler();

                this.CenterToScreen();

                UserNamelbl.Text = $"{employee.Name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during initialization: " + ex.Message, "Error");
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during logout: " + ex.Message, "Error");
            }
        }

        private void SelectedTable(int tableNumber)
        {
            try
            {
                this.Hide();
                TableOrderView tableOrderView = new TableOrderView(employee, tables[tableNumber]);
                tableOrderView.ShowDialog();
                this.Show();
                AssigneTableButtonHandler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the table: " + ex.Message, "Error");
            }
        }

        private void TableButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button tableButton = (Button)sender;
                int tableNumber = int.Parse(tableButton.Tag.ToString());
                SelectedTable(tableNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while handling the table button click: " + ex.Message, "Error");
            }
        }

        private void AssigneTableButtonHandler()
        {
            try
            {
                // Clear existing controls
                tablepanel.Controls.Clear();

                // Get all tables
                tables = tableService.GetAllTables();

                int buttonDiameter = 100;  // Set the desired diameter of each circular button
                int buttonsPerRow = 4;  // Set the number of buttons to display per row
                int horizontalSpacing = 200;  // Set the desired horizontal spacing between buttons
                int verticalSpacing = 90;  // Set the desired vertical spacing between buttons

                int tableCount = tables.Count;

                for (int i = 0; i < tableCount; i++)
                {
                    // Create a table button
                    Button tableButton = new Button();
                    tableButton.Text = "Table " + (i + 1);
                    tableButton.Size = new Size(buttonDiameter, buttonDiameter);

                    // Calculate the X and Y coordinates for the button's location
                    int row = i / buttonsPerRow;
                    int col = i % buttonsPerRow;
                    int x = 20 + col * (buttonDiameter + horizontalSpacing);
                    int y = 10 + row * (buttonDiameter + verticalSpacing);

                    tableButton.Location = new Point(x, y);
                    tableButton.Tag = i;
                    tableButton.Click += TableButtonClick;
                    GetColour(tables[i], tableButton);  // Set the button color based on the table status

                    // Create a circular region for the button
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, buttonDiameter, buttonDiameter);
                    tableButton.Region = new Region(path);

                    // Add the button to the container
                    tablepanel.Controls.Add(tableButton);

                    // Get the food and drink items for the table
                    List<OrderItem> foodItems = orderItemService.GetFoodStatusByTableId(tables[i].TableId);
                    List<OrderItem> drinkItems = orderItemService.GetDrinkStatusByTableId(tables[i].TableId);

                    // Check if there are any food or drink items with "Ready" status for the table
                    bool showLabels = false;

                    foreach (OrderItem foodItem in foodItems)
                    {
                        if (foodItem.Status == OrderStatus.Ready)
                        {
                            showLabels = true;
                            break;
                        }
                    }

                    if (!showLabels)
                    {
                        foreach (OrderItem drinkItem in drinkItems)
                        {
                            if (drinkItem.Status == OrderStatus.Ready)
                            {
                                showLabels = true;
                                break;
                            }
                        }
                    }

                    // Add the labels only if there are food or drink items with "Ready" status
                    if (showLabels)
                    {
                        // Create a status label
                        Label statusLabel = new Label();
                        statusLabel.AutoSize = true;

                        // Calculate the X and Y coordinates for the label's location
                        int labelX = x + buttonDiameter + 10;
                        int labelY = y + buttonDiameter / 2 - statusLabel.Height / 2;
                        statusLabel.Location = new Point(labelX, labelY);

                        // Generate the status string for food and drink items
                        string statusText = "";

                        foreach (OrderItem foodItem in foodItems)
                        {
                            if (foodItem.Status == OrderStatus.Ready)
                            {
                                statusText += "Food: Ready ";
                                break;
                            }
                        }

                        foreach (OrderItem drinkItem in drinkItems)
                        {
                            if (drinkItem.Status == OrderStatus.Ready)
                            {
                                statusText += "Drinks: Ready";
                                break;
                            }
                        }

                        statusLabel.Text = statusText;

                        // Add the label to the container
                        tablepanel.Controls.Add(statusLabel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while assigning table buttons: " + ex.Message, "Error");
            }
        }



        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AssigneTableButtonHandler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing table buttons: " + ex.Message, "Error");
            }
        }

        private Button GetColour(Table table, Button button)
        {
            try
            {
                switch (table.TableStatus)
                {
                    case TableStatus.Occupied:
                        button.BackColor = Color.Yellow;
                        break;
                    case TableStatus.Free:
                        if (orderItemService.CheckIfTableHasActiveOrders(table))
                        {
                            button.BackColor = Color.Yellow;
                        }
                        else
                        {
                            button.BackColor = Color.Green;
                        }
                        break;
                    case TableStatus.Reserved:
                        button.BackColor = Color.Red;
                        break;
                }

                return button;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting table color: " + ex.Message, "Error");
                return button;
            }
        }

    }

}
