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
            string[,] board = new string[3, 3];
            for (int a = 0; a < board.Length; a ++)
            {
                for (int b = 0; b < board.Length; b++)
                {
                    board[a , b] = "+---\n\n|";
                }
            }
            for (int c = 0; c < board.Length; c++)
            {
                for(int d = 0; d < board.Length; d++)
                {
                    Console.Write(board[c, d]);
                }
            }
        }
    }
}
