using System;

namespace _07
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double coins = 0.0;
            while (command != "Start")
            {
                if (command == "0.1")
                {
                    coins += double.Parse(command);
                }
                else if (command == "0.2")
                {
                    coins += double.Parse(command);
                }
                else if (command == "0.5")
                {
                    coins += double.Parse(command);
                }
                else if (command == "1")
                {
                    coins += double.Parse(command);
                }
                else if (command == "2")
                {
                    coins += double.Parse(command);
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", command);
                }

                command = Console.ReadLine();
            }


            double priceOfNuts = 2.0;
            double priceOfWater = 0.7;
            double priceOfCrisps = 1.5;
            double priceOfSoda = 0.8;
            double priceOfCoke = 1.0;


            while (command != "End")
            {
                if (command == "Coke")
                {
                    if ((coins - priceOfCoke) >= 0)
                    {
                        coins -= priceOfCoke;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    if ((coins - priceOfSoda) >= 0)
                    {
                        coins -= priceOfSoda;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    if ((coins - priceOfCrisps) >= 0)
                    {
                        coins -= priceOfCrisps;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    if ((coins - priceOfWater) >= 0)
                    {
                        coins -= priceOfWater;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Nuts")
                {
                    if ((coins - priceOfNuts) >= 0)
                    {
                        coins -= priceOfNuts;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Start")
                {

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine("Change: {0:f2}", coins);
        }
    }
}
