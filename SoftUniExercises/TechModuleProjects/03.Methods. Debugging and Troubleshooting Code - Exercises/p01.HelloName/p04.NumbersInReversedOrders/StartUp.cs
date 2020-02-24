using System;

namespace p04.NumbersInReversedOrders
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine(ReverNumbers(input));
        }

        private static string ReverNumbers(double input)
        {
            string args = input.ToString();
            string reversedNumbers = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                reversedNumbers += args[args.Length - i - 1];
            }

            return reversedNumbers;
        }
    }
}
