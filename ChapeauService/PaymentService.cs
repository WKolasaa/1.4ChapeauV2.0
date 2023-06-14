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

        public int StorePaymentHistory(Payment payment)
        {
            int paymentHistoryID = PaymentDao.AddPaymentHistory(payment);
            return paymentHistoryID;
        }

        public List<Payment> GetPaymentHistory()
        {
            List<Payment> payments = PaymentDao.GetPaymentHistory();

            // Retrieve and set the payment method for each payment
            foreach (Payment payment in payments)
            {
                string paymentMethod = GetPaymentMethod(payment.PaymentHistoryID);
                payment.PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), paymentMethod);
            }
            return payments;
        }

        public string GetPaymentMethod(int paymentHistoryId)
        {
            return PaymentDao.GetPaymentMethod(paymentHistoryId);
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

        public List<OrderItem> GetAllItem()
        {
            List<OrderItem> items = PaymentDao.GetAllItems();
            return items;
        }

    }
}
