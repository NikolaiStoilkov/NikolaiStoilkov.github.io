using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int curentNumber = 0; curentNumber < 1000; curentNumber++)
            {
                if (curentNumber % 10 == 7)
                {
                    Console.WriteLine(curentNumber);
                }
            }
        }
    }
}
