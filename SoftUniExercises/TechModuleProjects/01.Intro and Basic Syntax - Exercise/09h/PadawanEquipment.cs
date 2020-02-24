using System;

namespace _09h
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int coutOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());


            double sum = 0;

            int lightsabers = coutOfStudents  + (int)Math.Ceiling(coutOfStudents * 0.10);
            sum += priceOfLightsabers * lightsabers;
            sum += priceOfRobes * coutOfStudents;
            int belts = coutOfStudents - (coutOfStudents / 6);
            sum += priceOfBelts * belts;

            if (sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else if (sum > money)
            {
                double neededSum = Math.Abs(sum - money);
                Console.WriteLine($"Ivan Cho will need {neededSum:f2}lv more.");
            }
        }
    }
}
