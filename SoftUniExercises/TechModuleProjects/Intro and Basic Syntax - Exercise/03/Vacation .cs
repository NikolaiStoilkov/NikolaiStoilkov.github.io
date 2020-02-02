using System;

namespace _03
{
    class Vacation
    {
        
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string partOfWeek = Console.ReadLine();

            double sum = 0;

            if (typeOfGroup == "Students")
            {
                if (partOfWeek == "Friday")
                {
                    sum += countOfPeople * 8.45;
                }
                else if (partOfWeek == "Saturday")
                {
                    sum += countOfPeople * 9.80;
                }
                else if (partOfWeek == "Sunday")
                {
                    sum += countOfPeople * 10.46;
                }

                double newSum = 0;
                if (countOfPeople >= 30)
                {
                    newSum += sum * 0.85;
                    Console.WriteLine($"Total price: {newSum:f2}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Total price: {sum:f2}");
                    return;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }
               

                if (partOfWeek == "Friday")
                {
                    sum += countOfPeople * 10.90;
                }
                else if (partOfWeek == "Saturday")
                {
                    sum += countOfPeople * 15.60;
                }
                else if (partOfWeek == "Sunday")
                {
                    sum += countOfPeople * 16.0;
                }

                Console.WriteLine($"Total price: {sum:f2}");
                
            }
            else if (typeOfGroup == "Regular")
            {
                if (partOfWeek == "Friday")
                {
                    sum += countOfPeople * 15.0;
                }
                else if (partOfWeek == "Saturday")
                {
                    sum += countOfPeople * 20.0;
                }
                else if (partOfWeek == "Sunday")
                {
                    sum += countOfPeople * 22.50;
                }

                double newSum = 0;
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    newSum += sum * 0.95;
                    Console.WriteLine($"Total price: {newSum:f2}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Total price: {sum:f2}");
                }
            }
        }
    }
}
