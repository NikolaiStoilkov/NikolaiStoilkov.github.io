using System;
using System.Linq;
using System.Collections.Generic;


namespace _04
{
    class FastFood
    {
        static void Main(string[] args)
        {
            Queue<int> peoples = new Queue<int>();

            int food = int.Parse(Console.ReadLine());

            List<int> foodOrders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            CheckIfFoodIsEnough(food, foodOrders);
        }

        private static void CheckIfFoodIsEnough(int food, List<int> foodOrders)
        {
            int biggestOrder = 0;
            for (int i = 0; i < foodOrders.Count; i++)
            {
                if (food >= foodOrders[i])
                {
                    food -= foodOrders[i];
                }
                else
                {
                    Console.WriteLine($"{biggestOrder}");
                    Console.WriteLine($"Orders left: {foodOrders[i]}");
                    return;
                }

                if (foodOrders[i] > biggestOrder)
                {
                    biggestOrder = foodOrders[i];
                }
            }

            Console.WriteLine($"{biggestOrder}");
            Console.WriteLine("Orders complete");

        }
    }
}
