using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(new string('*', n));
                }
                else
                {
                    Console.WriteLine('*' + new string(' ', n - 2) + '*');
                }
        }
    }
}
