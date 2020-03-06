using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        /*
         * 
         *  3
            Pesho 3
            Gosho 4
            Annie 5

         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int members = 0; members < n; members++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
