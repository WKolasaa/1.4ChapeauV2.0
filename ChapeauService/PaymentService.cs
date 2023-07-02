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
        private const decimal HighVAT = 0.21m;//for the alcoholic
        private const decimal LowVAT = 0.06m;//for the nonAlcoholic and Food
        public PaymentService()
        {
            PaymentDao = new PaymentDao();
        }

        public int StorePaymentHistory(Payment payment)
        {
           int paymentHistoryID= PaymentDao.AddPaymentHistory(payment);
            return paymentHistoryID;
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

        public Payment GetPaymentHistoryByID(int paymentHistoryId)
        { 
        Payment payment=PaymentDao.GetPaymentHistoryByID(paymentHistoryId);
            return payment;
        }

        public decimal TodayIncome()
        {
            return PaymentDao.TodaysIncome();
        }

        public decimal CalculateTotalPriceWithoutVAT(int tableNumber)
        {
            List<OrderItem> items = GetItemsByTableNumber(tableNumber);
            decimal totalAmount = 0;

            foreach (OrderItem item in items)
            {
                decimal totalItemPrice = item.PricePerItem * item.Quantity;
                totalAmount += totalItemPrice;
            }

            return totalAmount;
        }

        public decimal VATPerItem(OrderItem item)
        {
            PaymentService paymentService = new PaymentService();
            bool isAlcoholic = paymentService.GetVATStatus(item);
            decimal vatRate;

            if (isAlcoholic)
            {
                vatRate = HighVAT;
            }
            else
            {
                vatRate = LowVAT;
            }
            decimal vatPerItem = item.PricePerItem * vatRate * item.Quantity;
            return vatPerItem;
        }

        public decimal TotalVat(int tableNumber)
        {
            List<OrderItem> items = GetItemsByTableNumber(tableNumber);

            decimal totalVat = 0;
            foreach (OrderItem item in items)
            {
                decimal vatPerItem = VATPerItem(item);
                totalVat += vatPerItem;
            }
            return totalVat;
        }

        public decimal TotalAmountIncludeVAT(int tableNumber)
        {
            decimal totalVAT = TotalVat(tableNumber);
            decimal totalPriceWithoutVat= CalculateTotalPriceWithoutVAT(tableNumber);
            decimal sum=totalVAT + totalPriceWithoutVat;

            return sum;
        }
    }
}
