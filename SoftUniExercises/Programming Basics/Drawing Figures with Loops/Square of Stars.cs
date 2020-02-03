using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("*");

                for (int j = 1; j < rows; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
