using System;
using System.Linq;
using System.Collections.Generic;


namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsInQue = new Queue<string>();
            Queue<string> songsPlayed = new Queue<string>();


            List<string> input = Console.ReadLine()
                 .Split(',', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (songsPlayed.Count == 0)
            {
                List<string> command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();



            }

        }
    }
}
