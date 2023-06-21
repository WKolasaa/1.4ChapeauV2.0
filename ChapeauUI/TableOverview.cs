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

                AssignTableButtonHandler();

                this.CenterToScreen();

                UniqueLoggedInEmployee loggedEmployee = UniqueLoggedInEmployee.GetInstance();

                namelabel.Text = $"{loggedEmployee.GetEmployee().Name}";
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
                AssignTableButtonHandler();
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

        private void AssignTableButtonHandler()
        {
            try
            {
                tablepanel.Controls.Clear();

                tables = tableService.GetAllTables();

                int buttonDiameter = 100;
                int buttonsPerRow = 4;
                int horizontalSpacing = 200;
                int verticalSpacing = 90;

                for (int i = 0; i < tables.Count; i++)
                {
                    Button tableButton = CreateTableButton(i, buttonDiameter);
                    PositionButton(tableButton, i, buttonDiameter, horizontalSpacing, verticalSpacing);
                    GetColour(tables[i], tableButton);

                    // Create and position the status label
                    Label statusLabel = CreateStatusLabel(tables[i]);
                    PositionStatusLabel(statusLabel, tableButton);

                    tablepanel.Controls.Add(tableButton);
                    tablepanel.Controls.Add(statusLabel);
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

            foreach (var foodItem in orderItemService.GetFoodStatusByTableId(table.TableId))
            {
                if (foodItem.Status == OrderStatus.Ready) isFoodReady = true;
                else if (foodItem.Status == OrderStatus.Preparing) isFoodPreparing = true;
                else if (foodItem.Status == OrderStatus.Ordered) isFoodOrdered = true;

                if (isFoodReady || isFoodPreparing || isFoodOrdered) break;
            }

            foreach (var drinkItem in orderItemService.GetDrinkStatusByTableId(table.TableId))
            {
                if (drinkItem.Status == OrderStatus.Ready) isDrinkReady = true;
                else if (drinkItem.Status == OrderStatus.Preparing) isDrinkPreparing = true;
                else if (drinkItem.Status == OrderStatus.Ordered) isDrinkOrdered = true;

                if (isDrinkReady || isDrinkPreparing || isDrinkOrdered) break;
            }

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

            tableButton.Click += TableButtonClick;  // Attach the event handler for button click

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
                AssignTableButtonHandler();
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
                        bool hasActiveOrders = orderItemService.CheckIfTableHasActiveOrders(table);
                        if (hasActiveOrders)
                        {
                            table.TableStatus = TableStatus.Occupied;
                            button.BackColor = Color.Orange;
                        }
                        else
                        {
                            table.TableStatus = TableStatus.Free;
                            button.BackColor = Color.MediumSeaGreen;
                        }
                        break;
                    case TableStatus.Reserved:
                        button.BackColor = Color.Gray;
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
