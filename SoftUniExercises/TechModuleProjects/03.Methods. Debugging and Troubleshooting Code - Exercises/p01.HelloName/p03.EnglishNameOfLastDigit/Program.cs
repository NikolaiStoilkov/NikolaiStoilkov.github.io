using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());


            if (GetNumberOfIt(input) == '0')
            {
                Console.WriteLine("zero");
            }
            else if (GetNumberOfIt(input) == '1')
            {
                Console.WriteLine("one");
            }
            else if (GetNumberOfIt(input) == '2')
            {
                Console.WriteLine("two");
            }
            else if (GetNumberOfIt(input) == '3')
            {
                Console.WriteLine("three");
            }
            else if (GetNumberOfIt(input) == '4')
            {
                Console.WriteLine("four");
            }
            else if (GetNumberOfIt(input) == '5')
            {
                Console.WriteLine("five");
            }
            else if (GetNumberOfIt(input) == '6')
            {
                Console.WriteLine("six");
            }
            else if (GetNumberOfIt(input) == '7')
            {
                Console.WriteLine("seven");
            }
            else if (GetNumberOfIt(input) == '8')
            {
                Console.WriteLine("eigth");
            }
            else if (GetNumberOfIt(input) == '9')
            {
                Console.WriteLine("nine");
            }
        }

        public static char GetNumberOfIt(long n)
        {
            string text = n.ToString();
            int size = text.Length - 1;

            return text[size];
        }
    }
}