using System;
using System.Linq;
using System.Collections.Generic;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            string input = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                else if (symbols.ContainsKey(input[i]) == false)
                {
                    symbols.Add(input[i], count);

                }
                else if (symbols.ContainsKey(input[i]))
                {
                    symbols[input[i]] += 1;
                }
            }

            foreach (var ch in symbols)
            {
                string separator = " -> ";
                Console.WriteLine(ch.Key
                                           + separator
                                           + ch.Value);
            }
        }
    }
}
