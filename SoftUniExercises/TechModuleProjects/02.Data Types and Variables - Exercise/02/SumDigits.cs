using System;

namespace _02
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            string rotate = input.ToString();
            for (int i = 0; i < rotate.Length; i++)
            {
                sum += input % 10;

                input /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
