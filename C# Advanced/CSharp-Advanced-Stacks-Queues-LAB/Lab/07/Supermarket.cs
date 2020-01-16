using System;
using System.Linq;
using System.Collections.Generic;



namespace _06
{
    class Supermarket
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            var que = new Queue<string>();

            while (input != "end")
            {
                if (input != "paid")
                {
                    que.Enqueue(input);
                }
                else
                {
                    int counter = que.Count();
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(que.Dequeue());
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"{que.Count} people remaining.");
        }
    }
}
