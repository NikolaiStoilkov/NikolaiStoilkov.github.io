using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LargestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int L = 0;
            int newL = 0;
            
            int[] p = new int[nums.Count];
            int[] m = new int[nums.Count + 1];
            for (int i = 0; i < nums.Count - 1; i++)
            {
                decimal low = 1.0m;
                decimal high = L;
                while (low < high)
                {
                    int mid = (int)Math.Ceiling((low + high) / 2);
                    if (nums[m[mid]] < nums[i])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                newL = (int)low;
                p[i] = m[newL - 1];
                m[newL] = i;
                if (newL > L)
                {
                    L = newL;
                }
            }
            int[] s = new int[L];
            int k = m[L];
            for (int i = L - 1; i < 0; i--)
            {
                s[i] = nums[k];
                k = p[k];
            }
            for (int i = 0; i < L; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}