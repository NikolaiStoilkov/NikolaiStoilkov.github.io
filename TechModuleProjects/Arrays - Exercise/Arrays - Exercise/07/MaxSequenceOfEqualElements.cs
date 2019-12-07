using System;
using System.Linq;
using System.Collections.Generic;


namespace _07
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            List<int> numbers = GetNumbersFromInput(input);

            Console.WriteLine(string.Join(' ', numbers));
        }

        private static List<int> GetNumbersFromInput(List<int> input)
        {
            Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>>();
            int indexCounterOfDict = 0;
            int lastIndex = input.Count - 1;
            List<int> secondNum = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == input[i + 1] && i != lastIndex)
                {
                    for (int j = 0; j < input.Count - i; j++)
                    {
                        if (input[j] == input[j + 1] && j != lastIndex)
                        {
                            secondNum.Add(input[j]);

                        }
                    }
                }
            }


        }
    }
}
