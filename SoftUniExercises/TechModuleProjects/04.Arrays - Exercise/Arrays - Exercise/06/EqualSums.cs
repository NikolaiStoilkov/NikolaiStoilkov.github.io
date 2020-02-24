using System;
using System.Linq;


namespace _06
{
    class EqualSums
    {
        static void Main(string[] args)
        {

            // Test Input :
            // 10 5 5 99 3 4 2 5 1 1 4
            // 1 2 3 3
            // 1 2 1 5 1 1 2
            // 1 1 1 1 1 1 1 1 1 5 9
            // 0 2 0
            // 0 0 0 0 0 0 0 0 0 0 0

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                ReturnZero();
            }
            else if (IsItZero(arr))
            {
                Console.WriteLine(0);
            }
            else if (arr.Length > 1)
            {
                GetSum(arr);
            }
        }

        private static bool IsItZero(int[] arr)
        {
            bool yes = false;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
            }

            if (count == arr.Length)
            {
                yes = true;
                return yes;
            }

            return yes;
        }

        private static void ReturnZero()
        {
            Console.WriteLine("0");
        }

       public static bool FirstIsBigger(int[] arr)
        {
            bool big = false;
            int left = 0;
            int rigth = 0;

            left = arr[0];

            for (int i = 2; i < arr.Length; i++)
            {
                rigth += arr[i];
            }

            if (left == rigth)
            {
                big = true;
                return big;
            }

            return big;
        }

        private static void GetSum(int[] arr)
        {
            int leftSum = 0;
            int rightSum = 0;

            bool equal = false;
            var k = 0;
            int indexCounter = 0;
            int midNumber = k + 2;

            if(FirstIsBigger(arr) == false)
            {
                for (k = 0; k < arr.Length - 2; k++)
                {
                    midNumber = k + 2;

                    for (int j = 0; j < midNumber; j++)
                    {
                        leftSum += arr[j];
                        indexCounter++;
                    }

                    for (int i = midNumber + 1; i < arr.Length; i++)
                    {
                        rightSum += arr[i];
                    }

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(indexCounter);
                        equal = true;
                        break;
                    }

                    if (k == arr.Length - 2)
                    {
                        break;
                    }

                    leftSum = 0;
                    rightSum = 0;
                    indexCounter = 0;

                }

                if (equal != true)
                {
                    Console.WriteLine("no");
                }
                
            }
            else
            {
                Console.WriteLine("1");
            }
            
        }
    }
}
