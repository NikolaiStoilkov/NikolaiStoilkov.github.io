using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int currentSize = size - 2;

            string topAndBotRow = "+";

            for (int i = 0; i < currentSize; i++)
            {
                topAndBotRow = topAndBotRow + " -";
            }

            topAndBotRow = topAndBotRow + " +";

            Console.WriteLine(topAndBotRow);


            string middlePipes = "|";

            for (int j= 0; j < currentSize; j++)
            {
                middlePipes = middlePipes + " -";
            }

            middlePipes = middlePipes + " |";


            for (int row = 0; row < currentSize; row++)
            {
                Console.WriteLine(middlePipes);
            }

            
            Console.WriteLine(topAndBotRow);
        }     
    }
}