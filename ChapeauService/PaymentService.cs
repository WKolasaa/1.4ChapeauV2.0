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
        /*public void PaymentHistory(Payment payment)
        {
            PaymentDao.PaymentHistory(payment);
        }*/
        public int CreatePayment(Payment payment)
        {
            int paymentHistoryID = PaymentDao.PaymentHistory(payment);
            return paymentHistoryID;
        }

        public int StorePaymentHistory(Payment payment)
        {
            int paymentHistoryID = PaymentDao.PaymentHistory(payment);
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

        public bool GetVATStatus(Payment item)
        { 
        return PaymentDao.GetVATStatus(item);  
             
        }

        public List<Payment> GetItemsByTableNumber(int tableNumber)
        {
           List<Payment> items=PaymentDao.GetItemsByTableNumber(tableNumber);
            return items;
        }

        public List<Payment>GetAllItem()
        {
           List<Payment> items= PaymentDao.GetAllItems();
            return items;
        }

        
    }
}
