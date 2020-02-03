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
            string city = string.Format(Console.ReadLine().ToLower());
            double sales = double.Parse(Console.ReadLine());

            var commission = 0.0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales > 10000)
                {
                    commission = 0.12;
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.1;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
            }
            if (commission > 0)
            {
                Console.WriteLine("{0:f2}", sales * commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
