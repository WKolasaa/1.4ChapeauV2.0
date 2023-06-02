using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenAndBarUI : Form
    {
        private Employee employee;

        OrderItemService orderItemService = new OrderItemService();

        List<OrderItem> orderedItems;




        public KitchenAndBarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private List<OrderItem> GetAllItems()
        {
            List<OrderItem> orderedItems = new List<OrderItem>();
            try
            {


                if (employee.EmployeeType == EmployeeType.Chef)
                {
                    //orderedItems = OrderItemsService.GetFood();
                }
                else if (employee.EmployeeType == EmployeeType.Bartender)
                {
                    //orderedItems = OrderItemsService.GetDrinks();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error getting the ordered items!", "Error", MessageBoxButtons.OK);
            }

            return orderedItems;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new LoginScreen();
            form.Show();
            this.Hide();
        }
    }
}
