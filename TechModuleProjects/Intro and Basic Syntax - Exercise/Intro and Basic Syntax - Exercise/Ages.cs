using System;

namespace Intro_and_Basic_Syntax___Exercise
{
    class Ages
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());

            if (ages >= 0 && ages < 3)
            {
                Console.WriteLine("baby");
            }
            else if (ages >= 3 && ages < 14)
            {
                Console.WriteLine("child");
            }
            else if (ages >= 14 && ages < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (ages >= 20 && ages < 66)
            {
                Console.WriteLine("adult");
            }
            else if (ages >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
