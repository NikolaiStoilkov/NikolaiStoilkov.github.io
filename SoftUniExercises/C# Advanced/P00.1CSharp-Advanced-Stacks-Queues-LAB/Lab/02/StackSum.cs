using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
    
            Stack<int> stack = new Stack<int>(input);

            string[] command = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    PushNumberToStack(stack, firstNumber, secondNumber);
                }
                else if (command[0] == "remove")
                {
                    if (stack.Count >= int.Parse(command[1]))
                    {
                        int itemsToRemove = int.Parse(command[1]);

                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                command = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();
            }

            Console.WriteLine("Sum: {0}", stack.Sum());
        }

        private static void PushNumberToStack(Stack<int> stack, int n1, int n2)
        {
            stack.Push(n1);
            stack.Push(n2);
        }

    }
}
