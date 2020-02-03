using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            switch (figures)
            {
                case "square":
                    double n = double.Parse(Console.ReadLine());
                    double result = n * n;
                    Console.WriteLine(result); break;
                case "rectangle":
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double first = a * b;
                    Console.WriteLine(first); break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    double second = Math.PI * r * r;
                    Console.WriteLine("{0:F3}", second); break;
                case "triangle":
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    double third = c * d / 2;
                    Console.WriteLine(third); break;
            }
        }
    }
}