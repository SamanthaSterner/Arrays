using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static bool isMatchColumn (string[,] board, string player, int column)
        {
            return board[0, column] == player && (board[0, column] == board[1, column] && board[1, column] == board[2, column]);
        }

        static void printBoard (string[,] board)
        {
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
            for (int e = 0; e <= 9; e++)
            {
                if (e % 2 == 0)
                {
                    Console.Write(" Player X, where do you want to move: ");
                    String play = Console.ReadLine();
                    int firstnum = Convert.ToInt32(play[0].ToString());
                    int secnum = play[1] - 'A' + 1;
                    if (board[firstnum, secnum] != " _ ")
                    {
                        Console.Write("INVALID MOVE");
                    }
                    board[firstnum, secnum] = " X ";
                    
                   if (board[1,1] != " _ " && board[1, 1] == board[1, 2] && board[1, 2] == board[1, 3])
                   {
                        Console.Write("Player X wins! \n");
                         e = 10;
                        printBoard(board);
                    }
                   if (board[2, 1] != " _ " && board[2, 1] == board[2, 2] && board[2, 2] == board[2, 3])
                   {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                   if (board[3, 1] != " _ " && board[3, 1] == board[3, 2] && board[3, 2] == board[3, 3])
                   {
                         Console.Write("Player X wins!\n");
                         e = 10;
                        printBoard(board);
                    }
                   if (board[1, 1] != " _ " && board[1,1] == board[2,1] && board[2,1] == board[3,1])
                    {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 2] != " _ " && board[1, 2] == board[2, 2] && board[2, 2] == board[3, 2])
                    {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 3] != " _ " && board[1, 3] == board[2, 3] && board[2, 3] == board[3, 3])
                    {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1,1] != " _ " && board[1,1] == board[2,2] && board[2,2] == board[3,3])
                    {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 3] != " _ " && board[1,3] == board[2, 2] && board[2, 2] == board[3, 1])
                    {
                        Console.Write("Player X wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                }
                else
                {
                    Console.Write("Player O, where do you want to move: ");
                    String play = Console.ReadLine();
                    int firstnum = Convert.ToInt32(play[0].ToString());
                    int secnum = play[1] - 'A' + 1;
                    if (board[firstnum, secnum] != " _ ")
                    {
                        Console.Write("INVALID MOVE");
                    }
                    board[firstnum, secnum] = " O ";
                    if (board[1, 1] != " _ " && board[1, 1] == board[1, 2] && board[1, 2] == board[1, 3])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[2, 1] != " _ " && board[2, 1] == board[2, 2] && board[2, 2] == board[2, 3])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[3, 1] != " _ " && board[3, 1] == board[3, 2] && board[3, 2] == board[3, 3])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 1] != " _ " && board[1, 1] == board[2, 1] && board[2, 1] == board[3, 1])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 2] != " _ " && board[1, 2] == board[2, 2] && board[2, 2] == board[3, 2])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 3] != " _ " && board[1, 3] == board[2, 3] && board[2, 3] == board[3, 3])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 1] != " _ " && board[1, 1] == board[2, 2] && board[2, 2] == board[3, 3])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                    if (board[1, 3] != " _ " && board[1, 3] == board[2, 2] && board[2, 2] == board[3, 1])
                    {
                        Console.Write("Player O wins!\n");
                        e = 10;
                        printBoard(board);
                    }
                }


                printBoard(board);
            }
        }
    }
}
