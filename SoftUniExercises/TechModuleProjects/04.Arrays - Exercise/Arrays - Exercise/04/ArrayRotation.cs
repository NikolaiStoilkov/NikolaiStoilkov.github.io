using System;
using System.Linq;

namespace _04
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] arrOfNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = arrOfNums[0];
                for (int j = 1; j < arrOfNums.Length; j++)
                {
                    arrOfNums[j - 1] = arrOfNums[j];

                }
                arrOfNums[arrOfNums.Length - 1] = currentNumber;
            }


            Console.WriteLine(string.Join(' ', arrOfNums));
        }
    }
}
