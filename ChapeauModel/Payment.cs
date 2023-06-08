using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class Payment
    {
        public decimal ItemPrice { get; set; }
        public string FeedBack { get; set; }
        public string Comment { get; set; }

        public int tableNumber;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public string itemName;

        public bool IsAlcoholic;
        public decimal PaidAmount { get; set; }
        public int PaymentMethodID { get; set; }
        public int PaymentHistoryID { get; set; }
        public decimal Tips { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
    public enum PaymentMethod
    {
        Visa, Debit, Cash
    }
}

