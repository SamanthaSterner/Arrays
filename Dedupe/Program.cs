using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random r = new Random();
            int[] nums = new int[5000];
            for (int n = 0; n < nums.Length - 1; n++)
            {
                nums[n] = r.Next(1, 50);
            }
            int[] change = nums.OrderByDescending(c => c).ToArray();
            for (int b = 0; b < nums.Length; b++)
            {
                for (int a = 0; a < nums.Length; a++)
                {
                    if (nums[b] == nums[a] && a != b)
                    {
                        nums[a] = -1;
                        nums[b] = -1;

                    }
                }
                if(nums[b] != -1)
                {
                    count++;
                }
            }
            Console.Write(count);
        }
    }
}
