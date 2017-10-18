using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] nums = new int[5000];
            for (int n = 0; n < nums.Length - 1; n++)
            {
                nums[n] = r.Next(1, 1000000);
            }
            int[] change = nums.OrderByDescending(c => c).ToArray();
            Console.Write(change[0] + " " + change[1]);
        }
    }
}
