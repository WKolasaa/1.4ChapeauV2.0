using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class Payment
    {
        const decimal HighVAT = 0.21m;//for the alcoholic
        const decimal LowVAT = 0.06m;//for the nonAlcoholic and Food

        public decimal ItemPrice { get; set; }
        public string FeedBack { get; set; }
        public string Comment { get; set; }

        public int tableNumber;

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public string itemName;

        public int numberOfPeople;

        public bool IsAlcoholic;
        public decimal PaidAmount { get; set; }
        public decimal TotalPriceMoney { get; set; }

        public decimal Tips { get; set; }



        public bool IsPaid { get; private set; }

        public PaymentMethod PaymentMethod { get; set; }

        // public decimal SplitAmount { get { return TotalAmount / numberOfPeople; } }

        /*  public decimal ChangeAmount()
          {
              return PaidAmount - TotalAmount;
          }
          // you should call the service layer
          public decimal VATPerItem(string item)
          {

            //  bool isAlcoholic =PaymentService GetVATStatus(item);

              decimal vatRate = isAlcoholic ? HighVAT : LowVAT;
              decimal vatPerItem = ItemPrice * vatRate;

              return vatPerItem;
          }
          public decimal TotalVat()
          {
            //  List<Item> items = PaymentService.GetAllItems(); // Retrieve all items from the DAL

              decimal totalVat = 0;

              foreach (Payment item in items)
              {
                  decimal vatPerItem = VATPerItem(item.itemName);
                  totalVat += vatPerItem;
              }

              return totalVat;
          }

          public decimal TotalPriceWithoutVAT(int table)
          {
              // i need to call the service layer

              //  List<Item> items = PaymentService.GetItemsByTableNumber(tableNumber); // Retrieve items for the specific table

              decimal totalAmount = 0;

              foreach (Payment item in items)
              {
                  decimal itemTotal = item.ItemPrice * Quantity;
                  totalAmount += itemTotal;
              }

              return totalAmount;

          }

          public decimal PriceWithVAT(int table)
          {
              decimal priceWithoutVAT = TotalPriceWithoutVAT(table);
              decimal priceWithVAT = TotalVat();
              TotalPriceMoney = priceWithoutVAT + priceWithVAT;
              return TotalPriceMoney;
          }



      }*/
    }
    public enum PaymentMethod
    {
        Visa, Pin, Cash
    }
}

