using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);
                }
                else if (commands[0] == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if (commands[0] == 3 
                    && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (commands[0] == 4 
                    && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            int count = stack.Count();
            int a = 1;

            foreach (int value in stack)
            {
                Console.Write(value);
                if (a <= count - 1)
                {
                    Console.Write(", ");
                    a++;
                }


            }

            Console.WriteLine();
        }
    }
}