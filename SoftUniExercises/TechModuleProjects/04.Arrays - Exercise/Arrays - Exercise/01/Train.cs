using System;

namespace _01
{
    class Train
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int addedNumber = int.Parse(Console.ReadLine());
                numbersArray[i] += addedNumber;
                sum += addedNumber;
            }

            Console.WriteLine(string.Join(' ', numbersArray));
            Console.WriteLine(sum);
        }
    }
}
