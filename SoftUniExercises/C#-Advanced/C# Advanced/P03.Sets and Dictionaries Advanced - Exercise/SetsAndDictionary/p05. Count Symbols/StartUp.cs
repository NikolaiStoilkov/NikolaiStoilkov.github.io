using System;
using System.Linq;
using System.Collections.Generic;


namespace _05
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> symbols = new Dictionary<char, int>();


            int textSize = text.Length;

            for (int i = 0; i < textSize; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols[text[i]] = 1;
                }
                else
                {
                    symbols[text[i]]++;
                }

            }

            foreach (var (key, value) in symbols.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value} time/s");
            }

        }
    }
}
