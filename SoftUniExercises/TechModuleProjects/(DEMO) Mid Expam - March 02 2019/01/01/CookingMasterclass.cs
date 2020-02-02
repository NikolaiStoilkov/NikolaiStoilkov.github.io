using System;

namespace _01
{
    class CookingMasterclass
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudent = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEggs = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            int flourCount = countOfStudent - (countOfStudent / 5);
            int aprons = countOfStudent + (int)Math.Ceiling((countOfStudent * 0.2));

            double money = aprons * priceOfApron +
                priceOfEggs * 10 * countOfStudent + priceOfFlour * flourCount;

            if (money <= budget)
            {
                Console.WriteLine($"Items purchased for {money:f2}$.");
            }
            else
            {
                double sum = money - budget;
                Console.WriteLine($"{sum:f2}$ more needed.");
            }


        }
    }
}
