using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauUI
{
    internal class ManagerMenuStip
    {
        public void OpenMainView(Form form)
        {
            LoginScreen loginScreen = new LoginScreen();
            form.Hide();
            ManagerMainView managerMainView = new ManagerMainView();
            managerMainView.ShowDialog();
            form.Close();
        }

        public void OpenEmployeesView(Form form)
        {
            form.Hide();
            ManagerEmployees managerEmployees = new ManagerEmployees();
            managerEmployees.ShowDialog();
            form.Hide();
        }

        public void OpenMenuView(Form form)
        {
            form.Hide();
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.ShowDialog();
            form.Close();
        }

        public void OpenStockView(Form form)
        {
            form.Hide();
            ManagerStock managerStock = new ManagerStock();
            managerStock.ShowDialog();
            form.Hide();
        }
    }
}
