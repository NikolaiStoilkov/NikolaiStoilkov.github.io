using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> orders = new Dictionary<string, decimal>();


            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (input[0] != "buy")
            {
                if (orders.ContainsKey(input[0]) == false)
                {
                    decimal value = decimal.Parse(input[1]) * decimal.Parse(input[2]);
                    orders.Add(input[0], value);
                }
                else if (orders.ContainsKey(input[0]))
                {
                    decimal value = decimal.Parse(input[1]) * decimal.Parse(input[2]);
                    orders[input[0]] += value;
                }

                input = Console.ReadLine()
                .Split()
                .ToList();

            }

            foreach (var or in orders)
            {
                Console.WriteLine($"{or.Key:f2} -> {or.Value:f2}");
            }
        }
    }
}
