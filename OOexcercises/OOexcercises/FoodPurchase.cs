using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class FoodPurchase
    {
        private bool refrigerate;
        public bool Refrigerate
        {
            get
            {
                return refrigerate;
            }
            set
            {
                refrigerate = value;
            }
        }
        private string productName;
        public string ProductName
        {
            get
            {
                return productName.ToUpper();
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ongeldig aantal");
                }
                else
                {
                    number = value;
                }
            }

        }
        private double unitprice;
        public double Unitprice
        {
            get
            {
                return unitprice;
            }
            set
            {
                if (value > 5000 || value < 0)
                {
                    Console.WriteLine("Prijs kleiner is dan 0 of groter is dan 5000: “Ongeldige eenheidsprijs”");
                }
                else
                {
                    unitprice = value;
                }
            }
        }
        private DateTime expirationDate;
        public DateTime ExpirationDate 
        {
            get
            {
                return expirationDate.AddMonths(2);
            }
        }
        public FoodPurchase(string name,byte number,double unitprice,bool refrigerate)
        {
            this.productName = name;
            this.Number = number;
            this.Unitprice = unitprice;
            this.Refrigerate = refrigerate;
        } 
        public double calculateTotalPrice()
        {
            return unitprice * number;
        } 
        public void ShowOverview()
        {
            Console.WriteLine($"De totaalprijs van {ProductName} is {calculateTotalPrice()} euro." +
                $"\n De vervaldatum van aankoop 1 is {expirationDate}");
        }
    }
}