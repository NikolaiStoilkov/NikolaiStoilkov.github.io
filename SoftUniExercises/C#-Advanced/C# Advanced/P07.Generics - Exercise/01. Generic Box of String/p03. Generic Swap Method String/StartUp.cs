using System;
using System.Collections.Generic;
using System.Linq;

namespace p03
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            var index = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int firstIndex = index[0];
            int secondIndex = index[1];

            Swap<string> swap = new Swap<string>();

            swap.SwapNames(names, firstIndex, secondIndex);

            Console.WriteLine(swap);
        }
    }
}
