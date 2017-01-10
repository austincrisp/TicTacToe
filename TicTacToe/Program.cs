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
            bool winner = false;
            string[,] choice = new string[3, 3]
            {
                { "_", "X", "O" },
                { "_", "X", "O" },
                { "_", "X", "O" }
            };

            Console.WriteLine("Let's play Tic-Tac-Toe");
            Console.WriteLine("Player One is X and Player Two is O");
            Console.WriteLine("\n");

            while (!winner)
            {
                playerOne();
                showBoard();
                playerTwo();
                showBoard();

                foreach (string option in choice)
                {
                    int choiceCounter = 0;
                    //if (
                    Console.Write(" " + option);
                    if (choiceCounter == 2)
                    {
                        Console.WriteLine("");
                        choiceCounter = 0;
                    }
                    else
                    {
                        choiceCounter++;
                    }
                }
            }
        }

        public static void showBoard()
        {
            string[] board = new string[]
                {
                    "_","_","_","_","_","_","_","_","_"
                };

            int boardCounter = 0;
            foreach (string place in board)
            {
                Console.Write(" " + place);
                if (boardCounter == 2)
                {
                    Console.WriteLine("");
                    boardCounter = 0;
                }
                else
                {
                    boardCounter++;
                }
            }
        }

        public static void playerOne()
        {
            Console.WriteLine("Turn: Player One");
            string playerOne = Console.ReadLine();
        }

        public static void playerTwo()
        {
            Console.WriteLine("Turn: Player Two");
            string playerTwo = Console.ReadLine();
        }
    }
}
