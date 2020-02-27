using System;
using System.Linq;

namespace FunctionalProgramingExe
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Action<string> namesForPrint = x =>
            {
                Console.WriteLine(x);
            };

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(namesForPrint);

        }
    }
}
