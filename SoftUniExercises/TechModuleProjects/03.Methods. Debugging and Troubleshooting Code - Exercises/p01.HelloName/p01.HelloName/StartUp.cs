using System;

namespace p01.HelloName
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Print(name);
        }

        public static void Print(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
