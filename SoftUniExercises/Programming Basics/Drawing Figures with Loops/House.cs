using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int countOfStars = size % 2 == 0 ? 2 : 1;
            int countOfDashes = (size - countOfStars) / 2;
            int rooftopRows =(size + 1) / 2;

            for (int row = 0; row < rooftopRows; row++)
            {
                string dashes = new string('-', countOfDashes);
                string stars = new string('*', countOfStars);

                Console.WriteLine("{0}{1}{0}", dashes,stars);


                countOfDashes--;
                countOfStars += 2;
            }


            int bodyRows = size / 2;
            for (int row = 0; row < bodyRows; row++)
            {
                string stars = new string('*', size - 2);

                Console.WriteLine("|{0}|",stars);
            }



        }     
    }
} 