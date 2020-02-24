using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_BombNumbers
{
    class Program
    {
        static void Main()
        {
            // Read the input - List of Integers, Array- Bomb number [0]; Power[1];
            // Remove elements form left and right of the bomb element - for loops to power and RemoveAt();
            // Remove the bomb numbers- Remove();
            // Check if not out of range;
            // Sum remining elements;

            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = arr[0];
            int power = arr[1];

            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] == bomb)
                {
                    for (int i = 0; i < power; i++)
                    {
                        if (index < list.Count)
                        {
                            list.RemoveAt(index + 1);
                        }
                    }

                    for (int i = 0; i < power; i++)
                    {
                        if (index > 0)
                        {
                            list.RemoveAt(index - 1);
                            index--;
                        }
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                list.Remove(bomb);
            }

            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }
    }
}