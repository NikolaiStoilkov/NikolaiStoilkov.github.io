using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int countNums = endNum - startNum;

            int sum = 0;

            int[] arr = new int[countNums + 1];

            for (int i = 0; i < countNums + 1; i++)
            {
                arr[i] = startNum;
                Console.Write(startNum + " ");
                startNum++;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];
            }


            Console.WriteLine("Sum: " + sum);
        }
    }
}
