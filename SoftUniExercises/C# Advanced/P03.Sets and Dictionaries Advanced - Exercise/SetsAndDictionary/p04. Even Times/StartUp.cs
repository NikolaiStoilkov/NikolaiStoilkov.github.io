using System;
using System.Linq;
using System.Collections.Generic;


namespace P03
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int cnt = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(curr))
                {
                    dict[curr] = 0;
                }

                dict[curr]++;

            }


            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }

            }
        }
    }
}
