using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] nums = new int[50];
            bool check = true;
            for (int n = 0; n < nums.Length -1; n++)
            {
                nums[n] = r.Next(2, 50);
            }
            for (int b = 0; b < nums.Length; b++)
            {
                check = true;
                for (int a = 0; a < nums.Length; a++)
                {
                    if (nums[b] == nums[a] && a != b)
                    {
                        check = false;
                    }
                }

                if (check)
                    Console.Write(nums[b] + " ");
            }

            }
        }
    }

