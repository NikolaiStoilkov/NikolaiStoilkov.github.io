using System;
namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currSum = 0;
            int prevSum = 0;
            int diff = 0;
            int maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                prevSum = currSum;
                currSum = 0;
                currSum += int.Parse(Console.ReadLine());
                currSum += int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs(currSum - prevSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                
            }
            if (prevSum == currSum || n == 1)
            {
                Console.WriteLine("Yes, value={0}", currSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}