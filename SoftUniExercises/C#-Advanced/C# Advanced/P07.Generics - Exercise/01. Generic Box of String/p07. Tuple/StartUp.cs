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
            string addres = input[2];
            string town = input[3];



            CustomTuple<string, string,string> custamTuple = new CustomTuple<string, string,string>(name,addres,town);
            Console.WriteLine(custamTuple);

            string[] inputOfMark = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var secondName = inputOfMark[0];
            var secondLitersOfBeer = int.Parse(inputOfMark[1]);
            var secondTypeOfFeeling = inputOfMark[2] == "drunk" ? true : false;

            CustomTuple<string, int,bool> markCustamTuple = new CustomTuple<string, int,bool>(secondName, secondLitersOfBeer,secondTypeOfFeeling);

            Console.WriteLine(markCustamTuple);

            string[] bankAccountInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var nameOfPerson = bankAccountInfo[0];
            var accountBalance = double.Parse(bankAccountInfo[1]);
            var bankName = bankAccountInfo[2];

            CustomTuple<string, double,string> tupleNumbers = new CustomTuple<string, double, string>(nameOfPerson,accountBalance,bankName);

            Console.WriteLine(tupleNumbers);
        }
    }
}
