using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = new string[3];
            letter[0] = "1";
            letter[1] = "2";
            letter[2] = "3";
            string[,] board = new string[3, 3];
            Console.Write("  A  B  C \n");
            for (int a = 0; a < board.GetLength(0); a ++)
            {
                for (int b = 0; b < board.GetLength(1) ; b++)
                {
                    if (b == 0)
                    {
                        board[a, b] = letter[a] + " _ ";
                    }
                    else
                    {
                        board[a, b] = " _ ";
                    }
                   

                }
            }
            for (int c = 0; c < board.GetLength(0); c++)
            {
                for(int d = 0; d < board.GetLength(1); d++)
                {
                    Console.Write(board[c, d]);
                    if (d == 2)
                    {
                        Console.Write("\n");
                    }

                }
            }
        }
    }
}
