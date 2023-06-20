using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class PaymentService
    {
        PaymentDao PaymentDao;

        public PaymentService()
        {
            PaymentDao = new PaymentDao();
        }

        public void StorePaymentHistory(Payment payment)
        {
             PaymentDao.AddPaymentHistory(payment);
        }

        public List<Payment> GetPaymentHistory()
        {
            List<Payment> payments = PaymentDao.GetPaymentHistory();
            
            return payments;
        }

        public List<Payment> GetLastPaymentHistory()
        {
            List<Payment> payments = PaymentDao.GetLastPaymentHistory();

            return payments;
        }
        public void DeleteBill(int tableNumber)
        {
            PaymentDao.DeleteBill(tableNumber);
        }
        public bool GetVATStatus(OrderItem item)
        {
            return PaymentDao.GetVATStatus(item);
        }

        public List<OrderItem> GetItemsByTableNumber(int tableNumber)
        {
            List<OrderItem> items = PaymentDao.GetItemsByTableNumber(tableNumber);
            return items;
        }

        public List<Payment> GetPaymentHistoryByID(int paymentHistoryId)
        { 
        List<Payment> paymentHistory=PaymentDao.GetPaymentHistoryByID(paymentHistoryId);
            return paymentHistory;
        }

        public List<OrderItem> GetAllItem()
        {
            List<OrderItem> items = PaymentDao.GetAllItems();
            return items;
        }

        public decimal TodayIncome()
        {
            return PaymentDao.TodaysIncome();
        }

    }
}
