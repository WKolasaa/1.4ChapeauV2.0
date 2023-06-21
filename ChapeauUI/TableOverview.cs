using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        
        private TableService tableService;
        private List<Table> tables;
        private Employee employee;
        private OrderItemService orderItemService;

        public TableOverview()
        {
            try
            {
                
                tables = new List<Table>();
                tableService = new TableService();
                orderItemService = new OrderItemService();

                InitializeComponent(); 

                AssignTableButtonHandler(); // Assign table buttons to the panel

                this.CenterToScreen(); // Center the form on the screen

                UniqueLoggedInEmployee loggedEmployee = UniqueLoggedInEmployee.GetInstance(); // Retrieve logged-in employee
                namelabel.Text = $"{loggedEmployee.GetEmployee().Name}"; // Display the employee's name
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
                    LoginScreen loginScreen = new LoginScreen(); // Create a new login screen form
                    loginScreen.ShowDialog(); // Display the login screen
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
                TableOrderView tableOrderView = new TableOrderView(employee, tables[tableNumber]); // Create a new table order view form
                tableOrderView.ShowDialog(); // Display the table order view form
                this.Show();
                AssignTableButtonHandler(); // Refresh the table buttons
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
                Button tableButton = (Button)sender; // Get the clicked table button
                int tableNumber = int.Parse(tableButton.Tag.ToString()); // Extract the table number from the button's tag
                SelectedTable(tableNumber); // Handle the selected table
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while handling the table button click: " + ex.Message, "Error");
            }
        }

        private void AssignTableButtonHandler()
        {
            try
            {
                tablepanel.Controls.Clear(); // Clear the existing controls in the table panel

                tables = tableService.GetAllTables(); // Retrieve all tables

                // Set up button and spacing dimensions
                int buttonDiameter = 100;
                int buttonsPerRow = 4;
                int horizontalSpacing = 200;
                int verticalSpacing = 90;

                for (int i = 0; i < tables.Count; i++)
                {
                    Button tableButton = CreateTableButton(i, buttonDiameter); // Create a table button
                    PositionButton(tableButton, i, buttonDiameter, horizontalSpacing, verticalSpacing); // Position the table button

                    GetColour(tables[i], tableButton); // Set the color of the table button based on its status

                    // Create and position the status label
                    Label statusLabel = CreateStatusLabel(tables[i]);
                    PositionStatusLabel(statusLabel, tableButton);

                    tablepanel.Controls.Add(tableButton); // Add the table button to the panel
                    tablepanel.Controls.Add(statusLabel); // Add the status label to the panel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while assigning table buttons: " + ex.Message, "Error");
            }
        }

        private void PositionStatusLabel(Label statusLabel, Button tableButton)
        {
            // Position the status label next to the table button
            statusLabel.Location = new Point(tableButton.Right + 10, tableButton.Top + (tableButton.Height - statusLabel.Height) / 2);
        }

        private Label CreateStatusLabel(Table table)
        {
            Label statusLabel = new Label { AutoSize = true };
            bool isFoodReady = false, isDrinkReady = false;
            bool isFoodPreparing = false, isDrinkPreparing = false;
            bool isFoodOrdered = false, isDrinkOrdered = false;

            // Check the order status for food items associated with the table
            foreach (var foodItem in orderItemService.GetFoodStatusByTableId(table.TableId))
            {
                if (foodItem.Status == OrderStatus.Ready) isFoodReady = true;
                else if (foodItem.Status == OrderStatus.Preparing) isFoodPreparing = true;
                else if (foodItem.Status == OrderStatus.Ordered) isFoodOrdered = true;

                if (isFoodReady || isFoodPreparing || isFoodOrdered) break;
            }

            // Check the order status for drink items associated with the table
            foreach (var drinkItem in orderItemService.GetDrinkStatusByTableId(table.TableId))
            {
                if (drinkItem.Status == OrderStatus.Ready) isDrinkReady = true;
                else if (drinkItem.Status == OrderStatus.Preparing) isDrinkPreparing = true;
                else if (drinkItem.Status == OrderStatus.Ordered) isDrinkOrdered = true;

                if (isDrinkReady || isDrinkPreparing || isDrinkOrdered) break;
            }

            // Set the text of the status label based on the order statuses
            if (isFoodReady && isDrinkReady) statusLabel.Text = "Food and Drink: Ready";
            else if (isFoodReady) statusLabel.Text = "Food: Ready";
            else if (isDrinkReady) statusLabel.Text = "Drink: Ready";
            else if (isFoodPreparing || isDrinkPreparing) statusLabel.Text = "Preparing...";
            else if (isFoodOrdered || isDrinkOrdered) statusLabel.Text = "Ordered";

            return statusLabel;
        }

        private Button CreateTableButton(int tableIndex, int buttonDiameter)
        {
            // Create a button to represent the table
            Button tableButton = new Button
            {
                Text = "Table " + (tableIndex + 1),
                Size = new Size(buttonDiameter, buttonDiameter),
                Tag = tableIndex
            };

            tableButton.Click += TableButtonClick; // Attach the event handler for button click

            return tableButton;
        }

        private void PositionButton(Button tableButton, int tableIndex, int buttonDiameter, int horizontalSpacing, int verticalSpacing)
        {
            // Calculate the position of the button based on the table index
            int row = tableIndex / 4;
            int col = tableIndex % 4;
            int x = 20 + col * (buttonDiameter + horizontalSpacing);
            int y = 10 + row * (buttonDiameter + verticalSpacing);
            tableButton.Location = new Point(x, y);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AssignTableButtonHandler(); // Refresh the table buttons
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
                TableStatus status = table.TableStatus;
                switch (status)
                {
                    case TableStatus.Occupied:
                        button.BackColor = Color.Orange;
                        break;
                    case TableStatus.Free:
                        button.BackColor = Color.MediumSeaGreen;
                        break;
                    case TableStatus.Reserved:
                        button.BackColor = Color.DarkGray;
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
