using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {

        public decimal Price { get; set; }
        public string feedBack { get; set; }
        public int tableNumber;
        public int numberOfPeople;
        public decimal PaiedAmount { get; set; }
        public decimal TipAmount { get { return PaiedAmount - TotalAmount; } set { value = PaiedAmount - TotalAmount; } }// property

        public decimal TotalVAT { get { return Price * 0.21m; } }
        public decimal TotalAmount { get { return Price + TotalVAT; } set { value = Price + TotalVAT; } }

        public bool IsPaid { get; private set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal SplitAmount { get { return TotalAmount / numberOfPeople; } }



    }
}
    public enum PaymentMethod
    {
        Creditcard, Pin, Cash
    }

