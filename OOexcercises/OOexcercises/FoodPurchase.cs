using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class FoodPurchase
    {
        public bool refrigerate;
        public string ProductName { 
            get
            {
                return productname;
            }
            set 
            {
                productname = value.ToUpper();
            }
        }
        public int Number
        {
            get { return number; }
           private set
            {
                if (value > 0)
                {
                    number = value;
                }
            }
        }
        public double Unitprice
        {
            get { return unitprice; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    unitprice = value;
                }
                else
                {
                    Console.WriteLine("Eenheidsprijs moet tussen 0 en 50 liggen.");
                }
            }
        }
        public DateTime ExpirationDate { 
            get 
            { 
                return expirationDate; 
            } 
            set 
            {
                expirationDate = value;
            } 
        }


        private string productname;
        private int number;
        private double unitprice;
        private DateTime expirationDate;

        public FoodPurchase(string productname, int number, double unitprice, DateTime expirationDate,bool refrigerate)
        {
            this.ProductName = productname;
            this.Number = number;
            this.Unitprice = unitprice;
            this.ExpirationDate = expirationDate;
            this.refrigerate = refrigerate;
        }
        public double CalculateTotalPrice()
        {
            return Unitprice * Number;
        }
        public static void DemoPurchase()
        {
            DateTime now = DateTime.Now;
            FoodPurchase kaas = new FoodPurchase("kaas", 2, 2.45, new DateTime(2025 , 09 , 25).AddMonths(2),true);
            Console.WriteLine($"De totale prijs is {kaas.CalculateTotalPrice()}");
            Console.WriteLine($"De vervaldatum is {kaas.ExpirationDate.ToString("d")}");

            FoodPurchase boter = new FoodPurchase("Boter", 0,5555, now.AddMonths(2), true);
            Console.WriteLine($"De totale prijs is {boter.CalculateTotalPrice()}");
            Console.WriteLine($"De vervaldatum is {boter.ExpirationDate.ToString("d")}");

        }
    }
}
