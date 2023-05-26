using ChapeauModel;
using ChapeauService;

namespace OrderTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowOrderPanel()
        {
            pnlDashboard.Hide(); //okokokokoko
            pnlOrder.Show();

            try
            {
                // get and display all orders
                List<Order> orders = GetOrders();
                DisplayOrders(orders);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = new List<Order>();
            return orders;
        }

        private void DisplayOrders(List<Order> orders)
        {

        }
    }
}