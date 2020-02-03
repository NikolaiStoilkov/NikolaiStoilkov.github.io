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
            for (int i = 1; i <= 10; i++)
            {
                for (int secondFor = 1; secondFor <= 10; secondFor++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
