using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');

            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }


            int sum = 0;
            int reminider = 0;
            StringBuilder sb = new StringBuilder();
            int num = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = num1[i] - 48 + num2[i] - 48 + reminider;
                num = sum % 10;
                if (sum > 9)
                {
                    reminider = 1;
                }
                else
                {
                    reminider = 0;
                }


                sb.Append(num);

                if (i == 0 && reminider == 1)
                {
                    sb.Append(reminider);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());

        }
    }
}