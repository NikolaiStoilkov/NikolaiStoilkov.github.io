using System;
using System.Linq;

namespace _02
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secondArr = Console.ReadLine()
                .Split()
                .ToArray();

            string commonWords = string.Empty;

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        commonWords += firstArr[j] + " ";
                    }
                }
            }

            Console.WriteLine(string.Join(' ',commonWords.Split().ToArray()));
        }
    }
}
