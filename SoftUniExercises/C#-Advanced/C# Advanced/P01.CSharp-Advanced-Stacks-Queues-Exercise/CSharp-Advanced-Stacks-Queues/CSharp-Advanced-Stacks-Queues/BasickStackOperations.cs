using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace _01
{
    class BasickStackOperations
    {

        public static Stack<int> lastNumbers = new Stack<int>();
        public static int bigNumber = 1;
        public static void Main(string[] args)
        {
            List<int> nsxNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbersFromStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int numberToPush = nsxNums[0];
            int numberToPop = nsxNums[1];
            int numberToFind = nsxNums[2];


            bool getNumberIfExist = IfNumberExist(numbersFromStack, numberToPush, numberToPop, numberToFind);

            if (getNumberIfExist)
            {
                Console.WriteLine("true");
            }
            else
            {

                if (bigNumber == 0
                    && getNumberIfExist == false)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(SmallestNumberInStack());
                }
            }
        }

        public static int SmallestNumberInStack()
        {
            int smallestNumber = 0;
            List<int> numbers = new List<int>();
            int numberToCount = lastNumbers.Count;

            for (int i = 0; i < numberToCount; i++)
            {
                numbers.Add(lastNumbers.Pop());
            }

            numbers.Sort();
            smallestNumber = numbers[0];

            return smallestNumber;
        }

        private static bool IfNumberExist(List<int> numbers, int nToPush, int nToPop, int numberToFind)
        {
            // Stack<int> stackSecond = new Stack<int>();

            Stack<int> stackFirst = new Stack<int>();

            bool getRightNumber = false;

            for (int index = 0; index < nToPush; index++)
            {
                stackFirst.Push(numbers[index]);
            }

            for (int indexToPop = 0; indexToPop < nToPop; indexToPop++)
            {
                stackFirst.Pop();
            }

            for (int ifExistSameNumber = stackFirst.Count - 1; ifExistSameNumber >= 0; ifExistSameNumber--)
            {

                lastNumbers.Push(stackFirst.Peek());

                if (numberToFind == stackFirst.Pop()
                    && stackFirst.Count > 0)
                {
                    getRightNumber = true;
                }
            }

            if (lastNumbers.Count == 0)
            {
                bigNumber = 0;
                return false;
            }

            return getRightNumber;

        }
    }
}
