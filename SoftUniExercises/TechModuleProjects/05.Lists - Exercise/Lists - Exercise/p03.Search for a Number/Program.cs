using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var inputArgs = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        bool yesOrNo = GetNumbers(input, inputArgs);
        if (yesOrNo)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }

    private static bool GetNumbers(List<int> input, List<int> inputArgs)
    {
        int cntIndex = inputArgs[0];
        int cntToRemove = inputArgs[1];
        int currentNumber = inputArgs[2];

        List<int> currentElements = new List<int>();

        for (int i = 0; i < cntIndex; i++)
        {
            currentElements.Add(input[i]);
        }

        int fakeCnt = 0;
        for (int i = 0; i < cntToRemove; i++)
        {
            i = 0;
            if (cntToRemove == fakeCnt)
            {
                break;
            }
            currentElements.Remove(currentElements[i]);
            fakeCnt++;
        }

        for (int i = 0; i < currentElements.Count; i++)
        {
            if (currentElements[i] == currentNumber)
            {
                return true;
            }
        }

        return false;
    }
}
