using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class FoodPurchase
    {
        public bool Refrigerate;
        public string ProductName { get; }
        public int Number
        {
            get
            {
                return Number;
            }
            set
            {

                if (value < 0)
                {
                    Console.WriteLine("Ongeldig aantal");
                }
                else
                {
                    Number++;
                }
            }
        }
        public double UnitPrice
        {
            get
            {
                return UnitPrice;
            }
            set
            {
                if(value<0 || value > 5000)
                {
                    Console.WriteLine("Ongeldige eenheidsprijs");
                }
            }
        }
        public DateTime ExpirationDate { get { return ExpirationDate.AddMonths(2); } }

        public FoodPurchase(string productName, byte number,double unitPrice,bool refrigerate)
        {
            this.ProductName = productName.ToUpper();
            this.Number = number;
            this.UnitPrice = unitPrice;
            this.Refrigerate = refrigerate;
        }
        public double CalculateTotalPrice()
        {
            return UnitPrice * Number;
        }

      
       
    }
}
