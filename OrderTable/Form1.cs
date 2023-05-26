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


        //SHOWING AND HIDING PANELS
        private void ShowOrderPanel()
        {
            pnlDashboard.Hide();
            pnlOrderView.Show();

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


        //LISTS FOR PANNELS
        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = new List<Order>();
            return orders;
        }



        //DISPLAYING THE LISTS IN PANNELS
        private void DisplayOrders(List<Order> orders)
        {

        }


        //BUTTONS FOR ORDERS TABLE
    }
}