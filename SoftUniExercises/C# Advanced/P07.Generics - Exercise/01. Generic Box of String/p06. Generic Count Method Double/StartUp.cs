using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();
            List<double> list = new List<double>();


            for (int i = 0; i < n; i++)
            {
                double stringArgs = double.Parse(Console.ReadLine());

                list.Add(stringArgs);
            }


            var typeToCompare = double.Parse(Console.ReadLine());


            var boxOfvalues = box.CountOfValues(list, typeToCompare);
            Console.WriteLine(boxOfvalues);

        }
    }
}
