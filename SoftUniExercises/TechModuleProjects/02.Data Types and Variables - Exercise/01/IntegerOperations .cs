using System;

namespace _01
{
    class IntegerOperations 
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());


            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;

            sum = num1 + num2;
            sum1 = sum / num3;
            sum2 = sum1 * num4;

            Console.WriteLine(sum2);
        }
    }
}
