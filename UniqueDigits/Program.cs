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
            for (int n = 0; n < nums.Length -1; n++)
            {
                nums[n] = r.Next(1, 50);
            }
            for (int b = 0; b < nums.Length - 1; b++)
            { 
                for (int n = 1; n < nums.Length - 1; n++)
                {
                    if (nums[b] != nums[n])
                    {
                        Console.Write(nums[n] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            }
        }
    }

