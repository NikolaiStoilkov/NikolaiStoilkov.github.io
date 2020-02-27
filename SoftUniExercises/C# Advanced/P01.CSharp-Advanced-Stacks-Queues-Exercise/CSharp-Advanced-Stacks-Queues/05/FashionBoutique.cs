using System;
using System.Linq;
using System.Collections.Generic;



namespace _05
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            var boxOfClothes = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var rackCapacity = int.Parse(Console.ReadLine());

            var clothes = new Stack<int>(boxOfClothes);
            var rack = new Stack<int>();
            var numberOfRacks = 0;
            var sumOfClothes = 0;



            while (clothes.Any())
            {
                
                int cloth = clothes.Pop();

                if (cloth <= rackCapacity)
                {
                    if ((sumOfClothes + cloth) > rackCapacity)
                    {
                        numberOfRacks++;
                        sumOfClothes = 0;
                    }

                    sumOfClothes += cloth;


                }

            }

            Console.WriteLine(numberOfRacks);

        }


    }
}
