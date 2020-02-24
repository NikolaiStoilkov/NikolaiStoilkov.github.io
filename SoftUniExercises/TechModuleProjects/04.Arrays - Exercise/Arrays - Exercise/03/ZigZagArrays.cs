using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];


            int takenNum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (takenNum == 0)
                {
                    firstArr[i] += input[takenNum];
                    secondArr[i] += input[takenNum + 1];
                    takenNum++;
                }
                else if (takenNum ==1)
                {
                    firstArr[i] += input[takenNum];
                    secondArr[i] += input[takenNum - 1];
                    takenNum = 0;
                }
            }

            Console.WriteLine(String.Join(' ',firstArr));
            Console.WriteLine(String.Join(' ',secondArr));
        }
    }
}
