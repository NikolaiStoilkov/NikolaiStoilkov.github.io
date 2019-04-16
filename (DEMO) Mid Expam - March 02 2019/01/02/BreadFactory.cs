using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class BreadFactory
    {
        static void Main(string[] args)
        {
            List<string> events = Console.ReadLine()
                .Split('|')
                .ToList();

            int energy = 100;
            int coins = 0;


            for (int i = 0; i < events.Count; i++)
            {
                string[] reqEvents = events[i].Split('-').ToArray();

                string request = reqEvents[0];
                int energyOrCoins = int.Parse(reqEvents[1]);

                if (request == "rest")
                {
                    if (energy + energyOrCoins > 100)
                    {
                        Console.WriteLine("You gained 0 energy.");
                    }
                    else if (energy + energyOrCoins < 100)
                    {
                        Console.WriteLine($"You gained {energyOrCoins} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (request == "order")
                {
                    if (energy >= 30)
                    {
                        energy -= 30;
                        coins += energyOrCoins;

                    }


                }

            }
        }
    }
}
