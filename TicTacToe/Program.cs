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
            int counter = 0;

            Console.WriteLine("Let's play Tic-Tac-Toe");
            Console.WriteLine("Player One is X and Player Two is O");
            Console.WriteLine("\n");

            while (!winner)
            {
                Console.WriteLine("Turn: Player One");
                string playerOne = Console.ReadLine();

                string[] board = new string[]
                {
                "_","_","_","_","_","_","_","_","_"
                };

                foreach (string place in board)
                {
                    Console.Write(" " + place);
                    if (counter == 2)
                    {
                        Console.WriteLine("");
                        counter = 0;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }
    }
}
