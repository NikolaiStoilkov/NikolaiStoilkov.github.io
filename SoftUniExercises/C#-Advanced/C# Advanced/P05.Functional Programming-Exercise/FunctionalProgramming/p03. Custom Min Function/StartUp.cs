using System;
using System.Linq;
using System.Collections.Generic;

namespace FunctionalPrograming
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //1 4 3 2 1 7 13
            Func<int[], int> numbers = (x) =>
            {
                int minValue = int.MaxValue;

                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] < minValue)
                    {
                        minValue = x[i];
                    }
                }

                return minValue;
            };

            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(numbers(input));
        }



    }
}
