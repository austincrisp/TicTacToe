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
            bool noWinner = true;
            bool boardFull = false;
            string player = "One";
            int i = 1;

            string[] board = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };

            Console.WriteLine("Let's play Tic-Tac-Toe\n");
            Console.WriteLine("Player One is X and Player Two is O. \n");

            while (noWinner || boardFull)
            {
                if (WinConditions(board, player))
                {
                    ShowBoard(board);
                    noWinner = false;
                }
                else if (BoardFull(board))
                {
                    ShowBoard(board);
                    Console.WriteLine("The game has ended in a draw.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Turn {i} \n");
                    ShowBoard(board);
                    Console.Write($"Player {player} make a move: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (i % 2 != 0)
                    {
                        player = "Two";
                        board[choice - 1] = "X";
                    }
                    else
                    {
                        player = "One";
                        board[choice - 1] = "O";
                    }

                    i++;
                }
            }
        }

        static void ShowBoard(string[] board)
        {
            int boardCounter = 0;
            foreach (string choice in board)
            {
                Console.Write(" " + choice);
                if (boardCounter == 2)
                {
                    Console.WriteLine("\n");
                    boardCounter = 0;
                }
                else
                {
                    boardCounter++;
                }
            }
        }

        static bool WinConditions(string[] board, string user)
        {

            user = user == "One" ? "Two" : "One";

            if (board[0] == "X" && board[3] == "X" && board[6] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }

            return false;
        }

        static bool BoardFull(string[] board)
        {
            return !board.Contains<string>("_");
        }
    }
}
