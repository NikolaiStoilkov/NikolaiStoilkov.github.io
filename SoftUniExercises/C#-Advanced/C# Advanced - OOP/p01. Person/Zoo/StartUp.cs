using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Lizard lizard = new Lizard(name);

            Console.WriteLine(lizard);

        }
    }
}