using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0.0;

            if (city == "sofia")
            {
                if (products == "coffee")
                {
                    price = 0.50;
                }
                else if (products == "water")
                {
                    price = 0.80;
                }
                else if (products == "beer")
                {
                    price = 1.20;
                }
                else if (products == "sweets")
                {
                    price = 1.45;
                }
                else if (products == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (city == "plovdiv")
            {
                if (products == "coffee")
                {
                    price = 0.40;
                }
                else if (products == "water")
                {
                    price = 0.70;
                }
                else if (products == "beer")
                {
                    price = 1.15;
                }
                else if (products == "sweets")
                {
                    price = 1.30;
                }
                else if (products == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "varna")
            {
                if (products == "coffee")
                {
                    price = 0.45;
                }
                else if (products == "water")
                {
                    price = 0.70;
                }
                else if (products == "beer")
                {
                    price = 1.10;
                }
                else if (products == "sweets")
                {
                    price = 1.35;
                }
                else if (products == "peanuts")
                {
                    price = 1.55;
                }
            }
            if (price >0)
            {
                Console.WriteLine("{0:f2}", quantity * price);
            }
            else
            {
                Console.WriteLine("No purchases");
            }
        }
    }
}
