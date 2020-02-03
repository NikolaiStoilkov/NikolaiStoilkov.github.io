using System;
using System.Linq;
using System.Collections.Generic;


namespace _05
{
    class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray());

            int count = stack.Count();
            var print = new List<string>();

            int countOfStack = stack.Count();
            for (int i = 0; i < countOfStack; i++)
            {
                int evenNumber;
                stack.TryPop(out evenNumber);

                if (evenNumber % 2 == 0)
                {
                    print.Add(evenNumber.ToString());
                }
            }

            print.Reverse();
            Console.WriteLine(string.Join(", ",print).Trim());

        }
    }
}
