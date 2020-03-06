using System;
using System.Linq;

namespace CustomizedTuple
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = input[0] + " " + input[1];
            string town = input[2];

            CustomTuple<string, string> custamTuple = new CustomTuple<string, string>(name,town);
            Console.WriteLine(custamTuple);

            string[] inputOfMark = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var secondName = inputOfMark[0];
            var secondLitersOfBeer = int.Parse(inputOfMark[1]);

            CustomTuple<string, int> markCustamTuple = new CustomTuple<string, int>(secondName, secondLitersOfBeer);

            Console.WriteLine(markCustamTuple);

            string[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var fNum = int.Parse(numbers[0]);
            var sNum = double.Parse(numbers[1]);

            CustomTuple<int, double> tupleNumbers = new CustomTuple<int, double>(fNum,sNum);

            Console.WriteLine(tupleNumbers);
        }
    }
}
