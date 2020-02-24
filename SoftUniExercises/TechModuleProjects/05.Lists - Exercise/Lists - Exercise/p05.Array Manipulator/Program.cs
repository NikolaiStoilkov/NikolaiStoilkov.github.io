using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine()
                             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            List<string> commands = new List<string>();
            string receivedCommands = "";

            List<int> listOfNumbers = new List<int>(arrNumbers);

            while (receivedCommands != "print")
            {
                commands = Console.ReadLine()
                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .ToList();
                receivedCommands = commands[0];

                if (receivedCommands == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    listOfNumbers.Insert(index, element);

                }
                else if (receivedCommands == "addMany")
                {
                    int index = int.Parse(commands[1]);

                    for (int i = commands.Count - 1; i >= 2; i--)
                    {
                        int element = int.Parse(commands[i]);
                        listOfNumbers.Insert(index, element);
                    }
                }
                else if (receivedCommands == "contains")
                {
                    int findNumber = int.Parse(commands[1]);
                    if (listOfNumbers.Contains(findNumber))
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] == findNumber)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (receivedCommands == "remove")
                {
                    int removeNumber = int.Parse(commands[1]);
                    listOfNumbers.RemoveAt(removeNumber);
                }
                else if (receivedCommands == "shift")
                {
                    int shiftNumber = int.Parse(commands[1]);
                    shiftNumber = shiftNumber % listOfNumbers.Count;
                    var result = listOfNumbers.GetRange(shiftNumber, listOfNumbers.Count - shiftNumber);
                    result.AddRange(listOfNumbers.GetRange(0, shiftNumber));
                    listOfNumbers = result;
                }
                else if (receivedCommands == "sumPairs")
                {
                    int count = 0;
                    List<int> listSum = new List<int>();
                    for (int i = 0; i < listOfNumbers.Count; i += 2)
                    {
                        count++;
                        if (count <= listOfNumbers.Count / 2)
                        {
                            listSum.Add(listOfNumbers[i] + listOfNumbers[i + 1]);
                        }
                        else
                        {
                            listSum.Add(listOfNumbers[i]);
                        }
                    }
                    listOfNumbers = listSum;
                }
                else if (receivedCommands == "print")
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", listOfNumbers));
                    Console.Write("]");
                    Console.WriteLine();

                }
            }
        }
    }
}