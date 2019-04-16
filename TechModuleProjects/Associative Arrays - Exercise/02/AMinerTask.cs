using System;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            while (command != "Stop")
            {

                if (resources.ContainsKey(command) == false)
                {
                    resources.Add(command, amount);
                }
                else if (resources.ContainsKey(command))
                {
                    resources[command] += amount;
                }


                command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }
                amount = int.Parse(Console.ReadLine());

            }

            foreach (var rs in resources)
            {
                string separator = " -> ";
                Console.WriteLine(rs.Key +
                                            separator +
                                            rs.Value);
            }
        }
    }
}
