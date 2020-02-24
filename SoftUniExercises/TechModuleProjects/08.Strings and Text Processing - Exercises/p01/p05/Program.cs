using System;
using System.Collections.Generic;
using System.Linq;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string w1 = input[0];
            string w2 = input[1];

            if (areExchanegeable(w1, w2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool areExchanegeable(string w1, string w2)
        {
            bool areExg = true;
            Dictionary<char, char> chars = new Dictionary<char, char>();


            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
            {
                if (!chars.ContainsKey(w1[i]))
                {
                    chars.Add(w1[i], w2[i]);
                }
                else
                {
                    if (w2[i] == chars[w1[i]])
                    {

                    }
                    else
                    {
                        areExg = false;
                    }
                }
            }


            if (w1.Length != w2.Length)
            {
                if (w1.Length > w2.Length)
                {
                    for (int i = w2.Length; i < w1.Length; i++)
                    {
                        if (!chars.ContainsKey(w1[i]))
                        {
                            areExg = false;
                        }
                    }
                }
                else
                {

                    for (int i = w1.Length; i < w2.Length; i++)
                    {
                        if (!chars.ContainsValue(w2[i]))
                        {
                            areExg = false;
                        }
                    }
                }
            }
            return areExg;
        }
    }
}
