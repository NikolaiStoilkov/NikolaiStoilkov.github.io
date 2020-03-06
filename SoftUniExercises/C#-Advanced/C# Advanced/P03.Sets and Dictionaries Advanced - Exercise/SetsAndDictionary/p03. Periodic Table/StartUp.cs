using System;
using System.Linq;
using System.Collections.Generic;



namespace _03
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();


            for (int i = 0; i < n; i++)
            {
                string[] periodicElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < periodicElements.Length; j++)
                    elements.Add(periodicElements[j]);

            }


            Console.WriteLine(string.Join(" ", elements));

        }
    }
}
