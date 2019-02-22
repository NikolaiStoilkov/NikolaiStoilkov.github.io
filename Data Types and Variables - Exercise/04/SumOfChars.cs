using System;

namespace _04
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char nextNum = char.Parse(Console.ReadLine());
                sum += (int)nextNum;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
