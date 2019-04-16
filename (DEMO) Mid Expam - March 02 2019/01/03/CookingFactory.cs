using System;
using System.Linq;
using System.Collections.Generic;

namespace _03
{
    class CookingFactory
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<int> sum = new List<int>();
            List<string> inputsAfter = new List<string>();
            List<int> averange = new List<int>();


            while (command != "Bake it!")
            {
                List<int> input = command
                    .Split('#')
                    .Select(int.Parse)
                    .ToList();

                inputsAfter.Add(input.ToString());

                for (int j = 0; j < input.Count; j++)
                {
                    numbers.Add(input[j]);
                }

                int lastSum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    lastSum += numbers[i];
                }

                sum.Add(lastSum);
                averange.Add(numbers.Count / lastSum);

                command = Console.ReadLine();
            }

            

            sum.Sort();
            averange.Sort();

           
        }
        
    }
}
