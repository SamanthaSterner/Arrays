using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            String[] main = new string [100];
            for (int i = 0; i <= main.Length + 1; i++)
            {
                if (nums % 3 == 0 && nums % 5 == 0)
                {
                    Console.Write("FizzBuzz. ");
                }
                if (nums % 3 == 0 && nums % 5 != 0)
                {
                   Console.Write("Fizz. ");
                }
                if (nums % 5 == 0 && nums % 3 !=0)
                {
                   Console.Write("Buzz. ");
                }
                else
                {
                    Console.Write(nums + ". ");
                }
                nums++;
            }
            
        }   
    }
}
