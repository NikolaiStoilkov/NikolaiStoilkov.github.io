﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace p04
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> names = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int name = int.Parse(Console.ReadLine());
                names.Add(name);
            }

            var index = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int firstIndex = index[0];
            int secondIndex = index[1];

            Swap<int> swap = new Swap<int>();

            swap.SwapNames(names, firstIndex, secondIndex);

            Console.WriteLine(swap);
        }
    }
}
