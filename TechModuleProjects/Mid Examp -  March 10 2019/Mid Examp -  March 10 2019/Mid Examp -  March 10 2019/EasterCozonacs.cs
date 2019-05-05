using System;

namespace ConsoleApp2
{
    class EasterCozonacs
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double floor = double.Parse(Console.ReadLine());

            double milk = floor * 1.25;
            double eggs = floor * 0.75;
            double milkOfml = milk * 0.25;
            double oneCoz = floor + eggs + milkOfml;
            int counter = 0;
            int eggsBonus = 0;
            int i = 0;

            while (budget > oneCoz)
            {


                if (i % 3 == 0 && i != 0)
                {
                    eggsBonus -= (counter - 2);
                }

                if (budget >= oneCoz)
                {
                    counter++;
                }

                eggsBonus += 3;
                i++;
                budget -= oneCoz;
            }



            Console.WriteLine($"You made {counter} cozonacs! Now you have {eggsBonus} eggs and {budget:f2}BGN left.");
        }
    }
}