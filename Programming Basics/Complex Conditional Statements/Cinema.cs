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
            string type = string.Format(Console.ReadLine().ToLower());
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            if (type == "premiere")
            {
                var premiere = 12.00;
                Console.WriteLine("{0:f2} leva", (row * column) * premiere);
            }
            else if (type == "normal")
            {
                var normal = 7.50;
                Console.WriteLine("{0:f2} leva", (row * column) * normal);
            }
            else if (type == "discount")
            {
                var discount = 5.00;
                Console.WriteLine("{0:f2} leva", (row * column) * discount);
            }
        }
    }
}
