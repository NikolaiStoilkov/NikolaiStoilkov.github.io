using System;

namespace _07
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int maxCapacityOfTank = 255;
            int currentCapacityOfTank = 0;

            for (int i = 0; i < n; i++)
            {
                int amountOfWater = int.Parse(Console.ReadLine());

                if (currentCapacityOfTank + amountOfWater > maxCapacityOfTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentCapacityOfTank += amountOfWater;
                }


            }

            Console.WriteLine(currentCapacityOfTank);

        }
    }
}
