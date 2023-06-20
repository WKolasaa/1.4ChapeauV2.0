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
        public int TableNumber { get; set; }
       // public int PaymentMethodID { get; set; }
        public int PaymentHistoryID { get; set; }
        public decimal Tips { get; set; }
        public decimal TotalAmount { get; set; }
        public List<PaymentMethod> PaymentMethods;
        public PaymentMethod PaymentMethod { get; set; }

        public DateTime Datetime { get; set; } 
    }
    
}

