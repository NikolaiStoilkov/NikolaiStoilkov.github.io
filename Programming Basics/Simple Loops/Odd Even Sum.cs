using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading user input
            int n = int.Parse(Console.ReadLine());

            // Value of odd numbers
            int oddSum = 0;

            // Value of even numbers
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int elemtents = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += elemtents;
                    

                }
                else
                {
                    evenSum += elemtents;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes, sum = {oddSum}");
            }
            else
            {
                int deferences = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No diff = {deferences}");
            }
        }
    }
}
