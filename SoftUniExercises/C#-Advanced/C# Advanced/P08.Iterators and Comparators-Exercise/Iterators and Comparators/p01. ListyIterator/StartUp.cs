using System;
using System.Linq;

namespace IteratorsAndComperators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listIterator = new ListyIterator<string>();

            var inputArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            while (inputArgs[0] != "END")
            {
                string command = inputArgs[0];

                if (command == "Create")
                {
                    if (inputArgs.Length == 1)
                    {
                       throw new InvalidOperationException(
                                    "Invalid Operation!"
                       );
                    }
                    else
                    {
                        for (int i = 1; i < inputArgs.Length; i++)
                        {
                            listIterator.Create(inputArgs[i]);
                        }
                    }
                }
                else if (command == "HasNext")
                {
                    Result(listIterator.HasNext());
                }
                else if (command == "Move")
                {
                    Result(listIterator.Move());
                }
                else if (command == "Print")
                {
                    listIterator.Print();
                }
                else if (command == "END")
                {
                    break;
                }

                inputArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        private static void Result(bool v)
        {
            Console.WriteLine(v);
        }

    }
}
