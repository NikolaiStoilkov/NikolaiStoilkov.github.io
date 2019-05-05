using System;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class SeizeTheFire
    {
        static void Main(string[] args)
        {

            List<string> cells = Console.ReadLine()
                 .Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();


            double amountOfWater = double.Parse(Console.ReadLine());

            List<double> validCells = new List<double>();

            for (int i = 0; i < cells.Count; i++)
            {
                string[] type = cells[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (type[0] == "High ")
                {
                    if (int.Parse(type[1]) >= 89 && int.Parse(type[1]) <= 125)
                    {
                        validCells.Add(int.Parse(type[1]));
                    }
                }
                else if (type[0] == "Medium ")
                {
                    if (int.Parse(type[1]) >= 51 && int.Parse(type[1]) <= 80)
                    {
                        validCells.Add(int.Parse(type[1]));
                    }
                }
                else if (type[0] == "Low ")
                {
                    if (int.Parse(type[1]) >= 1 && int.Parse(type[1]) <= 50)
                    {
                        validCells.Add(int.Parse(type[1]));
                    }
                }
            }

            double effort = 0;
            double totalFire = 0;


            List<double> listeValuse = new List<double>();
            for (int i = 0; i < validCells.Count; i++)
            {
                if (validCells[i] < amountOfWater)
                {
                    amountOfWater -= validCells[i];
                    double eff = validCells[i] * 0.25;
                    effort += eff;
                    totalFire += validCells[i];
                    listeValuse.Add(validCells[i]);
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine("Cells:");
            for (int i = 0; i < listeValuse.Count; i++)
            {
                Console.WriteLine($" - {listeValuse[i]}");
            }

            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
