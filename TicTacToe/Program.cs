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
            string[,] board = new string[4, 4];
            //sets the outsided to the coordinates
            board[0, 0] = "   A ";
            board[0, 1] = " B ";
            board[0, 2] = " C ";
            board[1, 0] = "1 ";
            board[2, 0] = "2 ";
            board[3, 0] = "3 ";

            //Assign the board to the array
            for (int a = 1; a < board.GetLength(0); a ++)
            {
                for (int b = 1; b < board.GetLength(1) ; b++)
                {
                    if (b == 0)
                    {
                        board[a, b] = " _ ";
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
                        if (d == 3)
                        {
                            Console.Write("\n");
                        }
                }
            }
        }
    }
}
