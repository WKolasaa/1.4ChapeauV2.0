using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class Payment
    {
        public string Feedback { get; set; }

        public int tableNumber;// same thing
        public decimal TotalPrice { get; set; }
        public int PaymentMethodID { get; set; }
        public int PaymentHistoryID { get; set; }
        public decimal Tips { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
    public enum PaymentMethod
    {
        Cash,Visa, Debit
    }
}

