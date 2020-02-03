using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());


            //Прочитане на потребителския вход и добавяне към leftSum

            int leftSum = 0;

            for (int i = 0; i < numberToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                leftSum += readNumber;
            }



            //Прочитане на потребителския вход и добавяне към rightSum

            int rightSum = 0;

            for (int i = 0; i < numberToRead ; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                rightSum += readNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int deferences = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {deferences}");
            }
        }
    }
}
