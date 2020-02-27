using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class BasicQueuesOperations
    {
        
        public static Queue<int> queOf = new Queue<int>();
        static void Main(string[] args)
        {
            List<int> nsxNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int length = nsxNumbers[0];
            int countToRemove = nsxNumbers[1];
            int numberToFind = nsxNumbers[2];

            bool existedNumber = IfNumberExist(numbersInput, length, countToRemove, numberToFind);

            if (existedNumber)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(SamllerQueueNumber());
            }
        }

        private static int SamllerQueueNumber()
        {
            if (queOf.Count == 0)
            {
                return 0;
            }

            int smallNumber = 0;
            List<int> smaller = new List<int>();
            int count = queOf.Count;
            for (int i = 0; i < count; i++)
            {
                smaller.Add(queOf.Dequeue());
            }

            smaller.Sort();
            smallNumber = smaller[0];

            return smallNumber;
        }

        private static bool IfNumberExist(List<int> numbers, int numberToEnque, int countToRemove, int numberToFind)
        {
            var queue = new Queue<int>();

            bool existedNumber = false;

            for (int index = 0; index < numberToEnque; index++)
            {
                queue.Enqueue(numbers[index]);
            }

            for (int index = 0; index < countToRemove; index++)
            {
                queue.Dequeue();
            }

            int counter = queue.Count;
            for (int index = 0; index < counter; index++)
            {
                queOf.Enqueue(queue.Peek());

                if (numberToFind == queue.Dequeue()
                    && queOf.Count > 0)
                {
                    existedNumber = true;
                }
            }

            return existedNumber;
        }
    }
}
