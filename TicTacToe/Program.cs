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
            bool playerOneTurn = true;
            bool boardFull = false;

            Console.WriteLine("Let's play Tic-Tac-Toe\n");
            Console.WriteLine("Player One is X and Player Two is O\n");

            int[] board = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int boardCounter = 0;

            for (int i = 0; i < board.Length; i++)
            {
                if (playerOneTurn)
                {
                    Console.WriteLine("Player One please pick a number.");
                    string playerOneChoice = Console.ReadLine();
                }
                else if (!playerOneTurn)
                {
                    Console.WriteLine("Player Two please pick a number.");
                    string playerTwoChoice = Console.ReadLine();
                }
            }

            foreach (int place in board)
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

            /*while (!winner)
            {
                
            }*/
        }
    }
}
