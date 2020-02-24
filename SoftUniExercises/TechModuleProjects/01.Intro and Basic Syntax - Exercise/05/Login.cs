using System;

namespace _05
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string[] pass = new string[username.Length];
            string endPass = string.Empty;

            // if input Acer 
            // should be recA
            for (int i = 0; i < username.Length; i++)
            {
                pass[i] += username[username.Length - i - 1];
                endPass += pass[i];
            }


            string currentPass = Console.ReadLine();

            int counter = 0;

            while (currentPass != endPass)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                currentPass = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");

        }
    }
}
