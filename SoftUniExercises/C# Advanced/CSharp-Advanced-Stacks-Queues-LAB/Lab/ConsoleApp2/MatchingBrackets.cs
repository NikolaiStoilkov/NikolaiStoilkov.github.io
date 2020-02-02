using System;
using System.Linq;
using System.Collections.Generic;


class MatchingBrackets
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var stack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == '(')
            {
                stack.Push(i);
            }
            else if (ch == ')')
            {
                int startIndex = stack.Pop();
                string contest = input.Substring(startIndex, i - startIndex + 1);
                Console.WriteLine(contest);
            }

        }
    }
}
