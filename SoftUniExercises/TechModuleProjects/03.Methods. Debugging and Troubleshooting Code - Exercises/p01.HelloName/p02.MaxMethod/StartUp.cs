using System;

namespace p02.MaxMethod
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int biggestNumber = 0;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                biggestNumber = MaxMethod(number);
            }

            Console.WriteLine(biggestNumber);
        }
        
        public static int maxValue = int.MinValue;
        public static int MaxMethod(int n)
        {
            
            if (maxValue < n)
            {
                maxValue = n;
            }

            return maxValue;
        }
    }
}
