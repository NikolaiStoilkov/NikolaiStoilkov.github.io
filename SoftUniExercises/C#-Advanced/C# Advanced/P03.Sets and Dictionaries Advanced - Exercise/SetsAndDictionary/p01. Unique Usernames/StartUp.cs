using System;
using System.Linq;
using System.Collections.Generic;

namespace SetAndDictionariesExes
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();


            int countOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfNames; i++)
            {
                string names = Console.ReadLine();

                uniqueNames.Add(names);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
