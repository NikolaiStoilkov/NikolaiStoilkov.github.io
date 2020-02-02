using System;

namespace _06
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char j = 'a'; j < 'a' + n; j++)
                {
                    for (char k = 'a'; k < 'a' + n; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }

                }
            }
        }
    }
}
