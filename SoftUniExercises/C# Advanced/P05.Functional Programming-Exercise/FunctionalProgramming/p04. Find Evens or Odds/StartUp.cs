using System;
using System.Linq;
using System.Collections.Generic;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = (x) => (x) % 2 == 0;
            Predicate<int> secondPredicate = (x) => (x) % 2 != 0;

            var arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
            string command = Console.ReadLine();

            int fromTo = arr[0];
            int endFrom = arr[1];

            List<int> numbers = new List<int>();

            for (int i = fromTo; i <= endFrom; i++)
            {
                if (predicate(i) && command == "even")
                {
                    numbers.Add(i);
                }
                else if (secondPredicate(i) && command == "odd")
                {
                    numbers.Add(i);
                }
            }



            Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
