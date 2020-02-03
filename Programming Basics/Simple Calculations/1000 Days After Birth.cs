using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ThousandDays
{
    class ThousandDays
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            string format= "dd-MM-yyyy";
            DateTime result=DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime output = Convert.ToDateTime(result).AddDays(999);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}