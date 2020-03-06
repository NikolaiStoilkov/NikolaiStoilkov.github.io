using System;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string stringArgs = Console.ReadLine();


                box.AddValue(stringArgs);
            }

            string typeToCompare = Console.ReadLine();

            Console.WriteLine(box.CountOfValues(typeToCompare));


        }
    }
}
