using System;

namespace _03
{
    class Elevator
    {
        static void Main(string[] args)
        {
            double peoples = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double courses = peoples / capacity;
            Console.WriteLine(Math.Ceiling(courses));

        }
    }
