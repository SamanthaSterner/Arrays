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
            board[0, 1] = "   A ";
            board[0, 2] = " B ";
            board[0, 3] = " C ";
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

            // we printin things

            // Input in Number Letter form. EX 1A
            // A colum (X,1)
            // B collum (X,2)
            //C Collum (X,3)
            // 1 row (1,X)
            // 2 row (2,X)
            //3 row (3,X)
            for (int e = 0; e < board.GetLength(0); e++)
            {
                if (e % 2 == 0)
                {
                    Console.Write(" Player X, where do you want to move: ");
                    String play = Console.ReadLine();
                    int firstnum = Convert.ToInt32(play[0].ToString());
                    int secnum = play[1] - 'A' + 1;
                   board[firstnum, secnum] = " X ";
                    if (board [1,1] == board [1,2] && board [1,2] == board[1,3])
                    {
                        Console.Write("Player X wins!");
                    }
                }
                else
                {
                    Console.Write("Player O, where do you want to move: ");
                    String play = Console.ReadLine();
                    int firstnum = Convert.ToInt32(play[0].ToString());
                    int secnum = play[1] - 'A' + 1;
                    board[firstnum, secnum] = " O ";
                }


                for (int c = 0; c < board.GetLength(0); c++)
                {

                    for (int d = 0; d < board.GetLength(1); d++)
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
}
