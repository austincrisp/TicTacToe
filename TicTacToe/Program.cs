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
            // variable declaration
            bool noWinner = true;
            bool boardFull = false;
            string player = "One";
            int i = 1;

            // array of lines to use in ShowBoard()
            string[] board = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };

            Console.WriteLine("Let's play Tic-Tac-Toe\n");
            Console.WriteLine("Player One is X and Player Two is O. \n");

            // keep the program running until there is a winner or the board is full
            while (noWinner || boardFull)
            {
                // if a win condition is met
                if (WinConditions(board, player))
                {
                    // draw the board
                    ShowBoard(board);
                    // set noWinner to false which ends the game
                    noWinner = false;
                }
                // else if the board is full
                else if (BoardFull(board))
                {
                    // draw board and end game by breaking out of the if-else block
                    ShowBoard(board);
                    Console.WriteLine("The game has ended in a draw.");
                    break;
                }
                // else if there is no win condition and the board is not full, play another turn
                else
                {
                    Console.WriteLine($"Turn {i} \n");
                    ShowBoard(board);
                    Console.Write($"Player {player} make a move: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    // if invalid move
                    if (!board[choice - 1].Contains("_"))
                    {
                        Console.Write("Invalid move. Try again. \n");
                        choice = int.Parse(Console.ReadLine());

                        // mod logic to determine who is playing the current turn
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
                    }
                    // if no invalid move
                    else
                    {
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
                    }

                    i++;
                }
            }
        }

        // method to draw/show the board
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


        // this is atrocious; will revisit to clean up and reduce duplication
        static bool WinConditions(string[] board, string user)
        {

            user = user == "One" ? "Two" : "One";

            if (board[0] == "X" && board[3] == "X" && board[6] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[1] == "X" && board[4] == "X" && board[7] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[2] == "X" && board[5] == "X" && board[8] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[0] == "X" && board[1] == "X" && board[2] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[3] == "X" && board[4] == "X" && board[5] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[6] == "X" && board[7] == "X" && board[8] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[0] == "X" && board[4] == "X" && board[8] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[2] == "X" && board[4] == "X" && board[6] == "X")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[0] == "O" && board[3] == "O" && board[6] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[1] == "O" && board[4] == "O" && board[7] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[2] == "O" && board[5] == "O" && board[8] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[0] == "O" && board[1] == "O" && board[2] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[3] == "O" && board[4] == "O" && board[5] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[6] == "O" && board[7] == "O" && board[8] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[0] == "O" && board[4] == "O" && board[8] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }
            else if (board[2] == "O" && board[4] == "O" && board[6] == "O")
            {
                Console.WriteLine($"CONGRATULATIONS!!! Player {user} wins!");
                return true;
            }

            return false;
        }

        // method to check if board is full (CAT/no winner/draw)
        static bool BoardFull(string[] board)
        {
            return !board.Contains<string>("_");
        }
    }
}
