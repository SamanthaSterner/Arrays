using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] nums = new int[51];
            for (int n = 0; n < nums.Length - 1; n++)
            {
                nums[n] = r.Next(1, 50);
            }
            for (int a = 0; a < nums.Length - 1; a++)
            {
                if (a == 9 || a == 19 || a == 29 || a ==39 || a == 49)
                {
                    Console.WriteLine(nums [a] + " \n");
                }
                else
                {
                    Console.Write(nums[a] + ",");
                }
            }
            int max = nums.Max();
            int min = nums.Min();
            Console.WriteLine("min: " + min);
            Console.Write("max: " + max);

        }

    }
}
