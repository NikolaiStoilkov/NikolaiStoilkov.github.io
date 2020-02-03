using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());

            double bonusPoints = 0.0;

            if (initialPoints <= 100)
            {
                bonusPoints = 5;
            }
            
            else if (initialPoints > 1000)
            {

                bonusPoints = initialPoints * 0.1;

            }
            else if (initialPoints > 100)
            {
                bonusPoints = initialPoints * 0.2;
            }
            if (initialPoints % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (initialPoints % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(initialPoints + bonusPoints);
        }
    }
}
