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
            int numbersToRead = int.Parse(Console.ReadLine());

            //Biggest Number
            int biggestNumer = int.MinValue;

            //Sum of all numbers included
            int sumOfAllNumber = 0;

            for (int i = 0; i < numbersToRead; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());

                sumOfAllNumber += readNumber;

                if (readNumber > biggestNumer )
                {
                    biggestNumer = readNumber;
                }
                
            }
            int sumOfOtherNumber = sumOfAllNumber - biggestNumer;

            if (biggestNumer == sumOfOtherNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($" sum = {biggestNumer} ");
            }
            else
            {
                int defereneces = Math.Abs(biggestNumer - sumOfOtherNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {defereneces}");
            }
        }
    }
}
