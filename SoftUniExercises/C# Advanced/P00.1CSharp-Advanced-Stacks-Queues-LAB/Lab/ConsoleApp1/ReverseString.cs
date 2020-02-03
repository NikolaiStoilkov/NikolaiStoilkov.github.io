using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_EXERCISES
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);


            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
