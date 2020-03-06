using System;
using System.Linq;
using System.Collections.Generic;


namespace _05
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = inputArgs[0];
                string[] clothes = inputArgs[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var cl in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cl))
                    {
                        wardrobe[color][cl] = 0;
                    }

                    wardrobe[color][cl]++;
                }
            }

            string[] searchArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            string searchedColor = searchArgs[0];
            string searchedCloth = searchArgs[1];

            foreach (var cdp in wardrobe)
            {
                string color = cdp.Key;
                Dictionary<string, int> clothes = cdp.Value;

                Console.WriteLine($"{color} clothes:");
                foreach (var cqp in clothes)
                {
                    string cloth = cqp.Key;
                    int qnt = cqp.Value;

                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.WriteLine($"* {cloth} - {qnt} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {qnt}");
                    }
                }
            }
        }
    }
}