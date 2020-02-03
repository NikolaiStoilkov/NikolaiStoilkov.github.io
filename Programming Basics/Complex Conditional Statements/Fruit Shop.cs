using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string products = string.Format(Console.ReadLine());
            string days = string.Format(Console.ReadLine());
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (days == "Monday" || days == "Tuesday" || days == "Wednesday" || days == "Thursday" || days == "Friday")
            {
                if (products == "banana")
                {
                    price = 2.50;
                }
                else if (products == "apple")
                {
                    price = 1.20;
                }
                else if (products == "orange")
                {
                    price = 0.85;
                }
                else if (products == "grapefruit")
                {
                    price = 1.45;
                }
                else if (products == "kiwi")
                {
                    price = 2.70;
                }
                else if (products == "pineapple")
                {
                    price = 5.50;
                }
                else if (products == "grapes")
                {
                    price = 3.85;
                }
            }
            else if (days == "Saturday" || days == "Sunday")
            {
                if (products == "banana")
                {
                    price = 2.70;
                }
                else if (products == "apple")
                {
                    price = 1.25;
                }
                else if (products == "orange")
                {
                    price = 0.90;
                }
                else if (products == "grapefruit")
                {
                    price = 1.60;
                }
                else if (products == "kiwi")
                {
                    price = 3.00;
                }
                else if (products == "pineapple")
                {
                    price = 5.60;
                }
                else if (products == "grapes")
                {
                    price = 4.20;
                }
            }
            if (price > 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
