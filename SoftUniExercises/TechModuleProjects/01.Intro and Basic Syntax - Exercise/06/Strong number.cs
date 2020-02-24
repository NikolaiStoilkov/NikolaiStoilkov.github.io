using System;

namespace _06
{
    class Strong_number
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            if (num == 0)
            {
                Console.WriteLine("no");
                return;
            }

            sum = num * (num - 1);

            for (int i = 2; i < num; i++)
            {
                if (i == num)
                {
                    break;
                }
                else
                {
                    sum = sum * (num - i);
                }

            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
