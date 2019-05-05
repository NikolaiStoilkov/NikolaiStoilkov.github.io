using System;

namespace _08
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double biggerV = 0.0;
            string biggerM = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double raidus = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double formula = raidus * raidus * height * Math.PI;

                if (formula > biggerV)
                {
                    biggerV = formula;
                    biggerM = model;
                }


            }

            Console.WriteLine(biggerM);
        }
    }
}
