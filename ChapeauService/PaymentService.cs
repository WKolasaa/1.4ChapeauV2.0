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
        public void PaymentHistory(Payment payment)
        {
            PaymentDao.PaymentHistory(payment);
        }
        public List<Payment> GetPaymentHistory()
        {
            List<Payment> payments = PaymentDao.GetPaymentHistory();
            return payments;    
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
