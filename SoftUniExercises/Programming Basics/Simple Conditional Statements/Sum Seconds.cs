using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondsSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int sumOfSeconds = firstSeconds +
                               secondsSeconds +
                               thirdSeconds;

            int minutes = sumOfSeconds / 60;
            int seconds = sumOfSeconds % 60;

            if (seconds <= 9)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
