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

            string print = string.Empty;

            int countOfStack = stack.Count();
            for (int i = 0; i < countOfStack; i++)
            {
                int evenNumber;
                stack.TryPop(out evenNumber);

                if (evenNumber % 2 == 0)
                {
                    print += evenNumber.ToString() + ", ";
                }
            }

            Console.WriteLine(print);

        }
    }
}
