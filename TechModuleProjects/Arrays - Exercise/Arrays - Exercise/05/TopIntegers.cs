using System;
using System.Linq;

namespace _05
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            string numbers = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    numbers += arr[i].ToString() + " ";
                    break;
                }
                else if (arr[i] > arr[i + 1]) // In case that only is lower with 1 --> && (arr[i] - 1) == arr[i + 1]
                {
                    numbers += arr[i].ToString() + " ";
                }
            }


            Console.WriteLine(numbers);

        }
    }
}
