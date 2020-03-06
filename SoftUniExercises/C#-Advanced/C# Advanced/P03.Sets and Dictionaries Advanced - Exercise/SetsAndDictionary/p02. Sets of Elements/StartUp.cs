using System;
using System.Linq;
using System.Collections.Generic;


namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            HashSet<int> hashOfN = new HashSet<int>();
            HashSet<int> hashOfM = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                hashOfN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < input[1]; i++)
            {
                hashOfM.Add(int.Parse(Console.ReadLine()));
            }

            List<int> numbers = new List<int>();
            foreach (var num in hashOfN)
            {
                for (int i = 0; i < hashOfM.Count(); i++)
                {
                    if (hashOfM.Contains(num))
                    {
                        numbers.Add(num);
                    }
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
