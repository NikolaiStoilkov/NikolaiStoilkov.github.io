using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenPosition
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        double oddsum = 0.0;
        double oddmin = double.MaxValue;
        double oddmax = double.MinValue;
        double evensum = 0.0;
        double evenmin = double.MaxValue;
        double evenmax = double.MinValue;

        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (!(i % 2 == 0))
            {
                evensum += array[i];
                evenmin = evenmin > array[i] ? array[i] : evenmin;
                evenmax = evenmax < array[i] ? array[i] : evenmax;
            }
            else
            {
                oddsum += array[i];
                oddmin = oddmin > array[i] ? array[i] : oddmin;
                oddmax = oddmax < array[i] ? array[i] : oddmax;
            }
        }

        Console.WriteLine("OddSum={0},", oddsum);
        Console.WriteLine("OddMin={0},", oddmin == double.MaxValue ? "No" : oddmin.ToString());
        Console.WriteLine("OddMax={0},", oddmax == double.MinValue ? "No" : oddmax.ToString());
        Console.WriteLine("EvenSum={0},", evensum);
        Console.WriteLine("EvenMin={0},", evenmin == double.MaxValue ? "No" : evenmin.ToString());
        Console.WriteLine("EvenMax={0}", evenmax == double.MinValue ? "No" : evenmax.ToString());
    }
}